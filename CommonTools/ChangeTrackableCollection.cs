using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
	[System.Flags]
	public enum ObjectState : ushort { Added = 1, Unchanged = 2, Deleted = 4, Modified = 8 }
	public class ChangeRecord<T>
	{
		public T Original { get; set; }
		public T Current { get; set; }
		public ObjectState State { get; set; }
	}
	public class ChangeTrackableCollection<T> : ObservableCollection<T> where T : class, new()
	{
		private Dictionary<T, ChangeRecord<T>> m_changeSet = new Dictionary<T, ChangeRecord<T>>();




		public ChangeTrackableCollection(IEnumerable<T> collection) : base(collection)
		{
			Initialize();
		}
		public ChangeTrackableCollection(List<T> list) : base(list)
		{
			Initialize();
		}
		public List<ChangeRecord<T>> GetChanges()
		{
			return m_changeSet.Values.Where(t => t.State != ObjectState.Unchanged).ToList<ChangeRecord<T>>();
		}
		public void AcceptChanges()
		{
			m_changeSet.Clear();
			foreach (T item in this.Items)
			{
				SetAsUnchanged(item);
			}
		}
		private void SetAsUnchanged(T item)
		{
			ChangeRecord<T> record = new ChangeRecord<T>() { Current = item, Original = item.Clone<T>(), State = ObjectState.Unchanged };
			m_changeSet[item] = record;
		}
		private void Initialize()
		{
			foreach (T item in Items)
			{
				AttachPropertyChanged(item);
				SetAsUnchanged(item);
			}
		}

		private void AttachPropertyChanged(T item)
		{
			INotifyPropertyChanged notifyPropertyChanged = (INotifyPropertyChanged)item;
			notifyPropertyChanged.PropertyChanged += ItemPropertyChanged;
		}

		private void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			T item = sender as T;
			TrackChangeOnModify(item);
		}
		private void TrackChangeOnAdd(T item)
		{
			AttachPropertyChanged(item);
			ChangeRecord<T> record = new ChangeRecord<T>() { Current = item, Original = null, State = ObjectState.Added };
			m_changeSet[item] = record;
		}
		private void TrackChangeOnModify(T item)
		{
			if (!m_changeSet.ContainsKey(item))
				return;
			var record = m_changeSet[item];
			if (record.State == ObjectState.Unchanged)
			{
				record.State = ObjectState.Modified;
			}
		}
		private void TrackChangeOnDelete(T item)
		{
			if (!m_changeSet.ContainsKey(item))
				return;
			var record = m_changeSet[item];
			if (record.State == ObjectState.Added)
				m_changeSet.Remove(item);
			else
				record.State = ObjectState.Deleted;
		}
		protected override void InsertItem(int index, T item)
		{
			TrackChangeOnAdd(item);
			base.InsertItem(index, item);
		}

		protected override void RemoveItem(int index)
		{
			T item = this[index];
			TrackChangeOnDelete(item);
			base.RemoveItem(index);
		}
		protected override void ClearItems()
		{
			foreach (T item in Items)
				TrackChangeOnDelete(item);
			base.ClearItems();
		}
		protected override void SetItem(int index, T item)
		{
			throw new NotImplementedException("Do not use this method with ChangeTrackableCollection");
		}
	}
}
