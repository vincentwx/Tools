using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace EntityToDB
{
	public class ODatabase
	{
		public string DBName { get; set; } = "";
		public List<OTable> Tables { get; set; }
		public List<OView> Views { get; set; }

		public ODatabase()
		{
			Tables = new List<OTable>();
			Views = new List<OView>();
		}
	}
	public class OTable
	{
		public string TableName { get; set; }

		public List<OColumn> Columns { get; set; }
		public string PrimaryKeys { get; set; } = "";
		public List<OIndex> Indexes { get; set; }

		public OTable()
		{
			Columns = new List<OColumn>();
			Indexes = new List<OIndex>();
		}

	}
	public class OView
	{
		public string ViewName { get; set; }
		public List<OColumn> Columns { get; set; }
		public string CreateSql { get; set; } = "";
		public OView()
		{
			Columns = new List<OColumn>();
		}

	}
	public class OColumn : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public string ColumnName { get; set; } = "";
		public string Type { get; set; } = "";
		public string SqlType { get; set; } = "";
		public int MaxLength { get; set; } = 0;
		public bool IsRequired { get; set; } = true;

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	public class OIndex
	{
		public string IndexName { get; set; } = "";
		public string Description { get; set; } = "";
		public string Keys { get; set; } = "";

	}
}
