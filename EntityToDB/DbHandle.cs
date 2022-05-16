using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using CommonLibrary;
namespace EntityToDB
{
	public class DbHandle : IDisposable
	{
		protected static SortedList<string, string> m_primaryKeyMap;
		protected SqlConnection m_connection;
		protected SqlTransaction m_transaction;

		public DbHandle(string connectionString)
		{
			if (m_primaryKeyMap == null)
			{
				OnDbConfig();
			}
			m_connection = new SqlConnection(connectionString);
			m_connection.Open();
		}
		public void Dispose()
		{
			if (m_connection != null)
			{
				if (m_connection.State == System.Data.ConnectionState.Open)
					m_connection.Close();
			}
		}
		protected static void AddPrimaryKeyConfig(string tableName, string columns) //comma separated
		{
			m_primaryKeyMap[tableName] = columns.Replace(" ", "");
		}
		protected static string[] GetPrimaryKeyColumns(string tableName)
		{
			if (m_primaryKeyMap.ContainsKey(tableName))
			{
				string[] cols = m_primaryKeyMap[tableName].Split(',');
				return cols;
			}
			else
				throw new Exception(string.Format("Cannot find primary config for table {0}", tableName));
		}
		protected virtual void OnDbConfig()
		{
			m_primaryKeyMap = new SortedList<string, string>();
		}
		protected SqlCommand CreateCommand(string sql, params object[] args)
		{
			string cmdText = DbUtil.FormatSql(sql);
			SqlCommand cmd = new SqlCommand(cmdText, m_connection, m_transaction);
			cmd.SetCommandParamaters(args);
			return cmd;
		}
		public void BeginTransaction()
		{
			m_transaction = m_connection.BeginTransaction();
		}
		public void Commit()
		{
			m_transaction.Commit();
		}
		public void RollBack()
		{
			m_transaction.Rollback();
		}
		public int Execute(string sqlSelect, params object[] args)
		{
			SqlCommand cmd = CreateCommand(sqlSelect, args);
			int n = cmd.ExecuteNonQuery();
			return n;
		}
		public object ExecuteScalar(string sqlSelect, params object[] args)
		{
			SqlCommand cmd = CreateCommand(sqlSelect, args);
			object o = cmd.ExecuteScalar();
			return o;
		}
		public List<T> Query<T>(string sqlSelect, params object[] args) where T : class, new()
		{
			List<T> list = new List<T>();
			PropertyInfo[] piList = typeof(T).GetProperties();
			SqlCommand cmd = CreateCommand(sqlSelect, args);
			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				int[] ordionalMap = reader.CreateOrdinalMap(piList);
				while (reader.Read())
				{
					T o = new T();
					reader.ReadToEntity(o, piList, ordionalMap);
					list.Add(o);

				}
				return list;
			}
		}
		public List<object> Query(Type type, string sqlSelect, params object[] args)
		{
			List<object> list = new List<object>();
			PropertyInfo[] piList = type.GetProperties();

			SqlCommand cmd = CreateCommand(sqlSelect, args);
			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				int[] ordionalMap = reader.CreateOrdinalMap(piList);
				while (reader.Read())
				{
					object o = Activator.CreateInstance(type);
					reader.ReadToEntity(o, piList, ordionalMap);
					list.Add(o);
				}
				return list;
			}
		}
		public List<T> Read<T>(string options, params object[] args) where T : class, new()
		{
			string sql = string.Format("select * from {0} {1}", typeof(T).Name, options);
			var list = Query<T>(sql, args);
			return list;
		}
		public List<object> Read(Type type, string options, params object[] args)
		{
			string sql = string.Format("select * from {0} {1}", type.Name, options);
			var list = Query(type, sql, args);
			return list;
		}
		public T Find<T>(string options, params object[] args) where T : class, new()
		{
			string sql = string.Format("select top 1 * from {0} {1}", typeof(T).Name, options);
			var o = Query<T>(sql, args).FirstOrDefault();
			return o;
		}
		public object Find(Type type, string options, params object[] args)
		{
			string sql = string.Format("select top 1 * from {0} {1}", type.Name, options);
			var o = Query(type, sql, args).FirstOrDefault();
			return o;
		}
		public int Insert(Object o)
		{
			Type type = o.GetType();
			PropertyInfo[] piList = type.GetProperties();

			string cmdText = DbUtil.FormatInsertSql(type.Name, piList);
			SqlCommand cmd = new SqlCommand(cmdText, m_connection, m_transaction);
			cmd.SetInsertParamaters(piList, o);
			int n = cmd.ExecuteNonQuery();
			return n;
		}
		public int InsertRange<T>(List<T> list)
		{
			int n = 0;
			if (list.Count == 0)
				return n;
			Type type = list[0].GetType();
			PropertyInfo[] piList = type.GetProperties();
			string cmdText = DbUtil.FormatInsertSql(type.Name, piList);
			SqlCommand cmd = new SqlCommand(cmdText, m_connection, m_transaction);
			foreach (object o in list)
			{
				cmd.SetInsertParamaters(piList, o);
				n += cmd.ExecuteNonQuery();
			}
			return n;
		}
		public int Update(object o)
		{
			Type type = o.GetType();
			PropertyInfo[] piList = type.GetProperties();
			string[] keys = GetPrimaryKeyColumns(type.Name);

			string cmdText = DbUtil.FormatUpdateSql(type.Name, piList, keys);
			SqlCommand cmd = new SqlCommand(cmdText, m_connection, m_transaction);
			cmd.SetUpdateParamaters(piList, o, keys);
			int n = cmd.ExecuteNonQuery();
			return n;
		}
		public int UpdateRange<T>(List<T> list)
		{
			int n = 0;
			if (list.Count == 0)
				return n;
			Type type = list[0].GetType();
			PropertyInfo[] piList = type.GetProperties();
			string[] keys = GetPrimaryKeyColumns(type.Name);
			string cmdText = DbUtil.FormatUpdateSql(type.Name, piList, keys);
			SqlCommand cmd = new SqlCommand(cmdText, m_connection, m_transaction);
			foreach (object o in list)
			{
				cmd.SetUpdateParamaters(piList, o, keys);
				n += cmd.ExecuteNonQuery();
			}
			return n;
		}

		public int Delete(object o)
		{
			Type type = o.GetType();
			PropertyInfo[] piList = type.GetProperties();
			string[] keys = GetPrimaryKeyColumns(type.Name);

			string cmdText = DbUtil.FormatDeleteSql(type.Name, piList, keys);
			SqlCommand cmd = new SqlCommand(cmdText, m_connection, m_transaction);
			cmd.SetDeleteParamaters(piList, o, keys);
			int n = cmd.ExecuteNonQuery();
			return n;
		}
		public int DeleteRange<T>(List<T> list)
		{
			int n = 0;
			if (list.Count == 0)
				return n;
			Type type = list[0].GetType();
			PropertyInfo[] piList = type.GetProperties();
			string[] keys = GetPrimaryKeyColumns(type.Name);
			string cmdText = DbUtil.FormatDeleteSql(type.Name, piList, keys);
			SqlCommand cmd = new SqlCommand(cmdText, m_connection, m_transaction);
			foreach (object o in list)
			{
				cmd.SetDeleteParamaters(piList, o, keys);
				n += cmd.ExecuteNonQuery();
			}
			return n;
		}
		public int UpdateRange<T>(List<(T Orignal, T Current)> list)
		{
			int n = 0;
			if (list.Count == 0)
				return n;
			Type type = list[0].Current.GetType();
			PropertyInfo[] piList = type.GetProperties();
			string[] keys = GetPrimaryKeyColumns(type.Name);
			string cmdText = DbUtil.FormatUpdateSql(type.Name, piList, keys);
			SqlCommand cmd = new SqlCommand(cmdText, m_connection, m_transaction);
			foreach (var change in list)
			{
				cmd.SetUpdateParamaters(piList, change.Current, keys, change.Orignal);
				n += cmd.ExecuteNonQuery();
			}
			return n;
		}
		public int Save<T>(ChangeTrackableCollection<T> collection) where T : class, new()
		{
			var changes = collection.GetChanges();
			int n = SaveChanges(changes);
			return n;

		}
		public int SaveChanges<T>(List<ChangeRecord<T>> changes)
		{
			int n = 0;
			List<T> delList = changes.Where(c => c.State == ObjectState.Deleted).Select(c => c.Original).ToList<T>();
			n += DeleteRange<T>(delList);

			List<T> insertList = changes.Where(c => c.State == ObjectState.Added).Select(c => c.Current).ToList<T>();
			n += InsertRange<T>(insertList);

			List<(T Original, T Current)> updateList = changes.Where(c => c.State == ObjectState.Modified).Select(c => (c.Original, c.Current)).ToList<(T, T)>();
			n += UpdateRange<T>(updateList);
			return n;

		}
	}
}
