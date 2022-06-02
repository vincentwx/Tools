using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Data;
namespace EntityToDB
{

	public static class DbUtil
	{
		public static string GetConnectionString(string server, string userName, string password, string dbName)
		{
			SqlConnectionStringBuilder connStrBuilder = new SqlConnectionStringBuilder();
			connStrBuilder.DataSource = server;
			if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
			{
				connStrBuilder.IntegratedSecurity = true;
				connStrBuilder.InitialCatalog = dbName;
			}
			else
			{
				connStrBuilder.UserID = userName;
				connStrBuilder.Password = password;
			}

			string connStr = connStrBuilder.ToString();

			return connStr;
		}
		public static string FormatSql(string sql)
		{
			MatchCollection list = Regex.Matches(sql, "{[0-9]*}");
			foreach (Match match in list)
			{
				string paramName = "@P" + match.Value.Trim('{', '}');
				sql = sql.Replace(match.Value, paramName);
			}
			return sql;
		}

		public static string FormatInsertSql(string tableName, PropertyInfo[] piList)
		{

			string fieldList = "";
			string valList = "";
			foreach (PropertyInfo pi in piList)
			{
				if (fieldList != "")
					fieldList += ",";
				if (valList != "")
					valList += ",";
				fieldList += GetQuotedName(pi.Name);

				valList += "@" + pi.Name;
			}
			string sql = string.Format("Insert into {0} ({1}) Values ({2})", tableName, fieldList, valList);
			return sql;
		}
		public static string FormatUpdateSql(string tableName, PropertyInfo[] piList, string[] keys)
		{

			string setList = "";
			string whereClause = "";
			foreach (PropertyInfo pi in piList)
			{
				if (setList != "")
					setList += ",";
				setList += string.Format("{0} = @{1}", GetQuotedName(pi.Name), pi.Name);
			}
			for (int i = 0; i < keys.Length; i++)
			{
				if (whereClause != "")
					whereClause += " and ";

				whereClause += string.Format("({0} = @P{1})", GetQuotedName(keys[i]), i);
			}
			string sql = string.Format("Update {0} set {1} where {2}", tableName, setList, whereClause);
			return sql;
		}
		public static string FormatDeleteSql(string tableName, PropertyInfo[] piList, string[] keys)
		{
			string whereClause = "";
			for (int i = 0; i < keys.Length; i++)
			{
				if (whereClause != "")
					whereClause += " and ";

				whereClause += string.Format("({0} = @P{1})", GetQuotedName(keys[i]), i);
			}
			string sql = string.Format("Delete from {0} where {1}", tableName, whereClause);
			return sql;
		}
		//Database Extension Method

		public static DataTable OpenTable(this SqlConnection db, string sql)
		{
			SqlDataAdapter da = new SqlDataAdapter(sql, db);
			DataTable table = new DataTable();
			da.Fill(table);
			return table;
		}
		public static DataTable OpenTableSchema(this SqlConnection db, string sql)
		{
			SqlDataAdapter da = new SqlDataAdapter(sql, db);
			DataTable table = new DataTable();
			da.FillSchema(table, SchemaType.Mapped);
			return table;
		}
		public static int Execute(this SqlConnection db, string cmdText)
		{
			SqlCommand cmd = new SqlCommand(cmdText, db);
			int n = cmd.ExecuteNonQuery();
			return n;
		}
		public static void ReadToEntity(this SqlDataReader reader, object o, PropertyInfo[] piList, int[] ordionalMap)
		{
			object[] vals = new object[reader.FieldCount];
			reader.GetValues(vals);
			for (int i = 0; i < piList.Length; i++)
			{
				PropertyInfo pi = piList[i];
				int ordinal = ordionalMap[i];
				object val = vals[ordinal];
				if (val == DBNull.Value)
				{
					if (pi.PropertyType.Name == "String")
						val = "";
					else
						val = Activator.CreateInstance(pi.PropertyType);
				}
				pi.SetValue(o, val);

			}
		}
		public static void SetCommandParamaters(this SqlCommand cmd, object[] args)
		{
			cmd.Parameters.Clear();
			for (int i = 0; i < args.Length; i++)
			{
				object arg = args[i];
				if (arg == null || (arg is string && (string)arg == ""))
					arg = DBNull.Value;
				SqlParameter sqlParam = new SqlParameter();
				sqlParam.ParameterName = "P" + i.ToString();
				sqlParam.Value = arg;

				cmd.Parameters.Add(sqlParam);
			}
		}
		public static void SetInsertParamaters(this SqlCommand cmd, PropertyInfo[] piList, object o)
		{
			cmd.Parameters.Clear();
			cmd.AddValueParameter(piList, o);
		}
		public static void SetUpdateParamaters(this SqlCommand cmd, PropertyInfo[] piList, object o, string[] keys)
		{
			cmd.Parameters.Clear();
			cmd.AddValueParameter(piList, o);
			cmd.AddKeyParameters(piList, o, keys);
		}
		public static void SetUpdateParamaters(this SqlCommand cmd, PropertyInfo[] piList, object currnet, string[] keys, object orignal)
		{
			cmd.Parameters.Clear();
			cmd.AddValueParameter(piList, currnet);
			cmd.AddKeyParameters(piList, orignal, keys);
		}
		public static void SetDeleteParamaters(this SqlCommand cmd, PropertyInfo[] piList, object o, string[] keys)
		{
			cmd.Parameters.Clear();
			cmd.AddKeyParameters(piList, o, keys);
		}
		private static void AddKeyParameters(this SqlCommand cmd, PropertyInfo[] piList, object o, string[] keys)
		{
			for (int i = 0; i < keys.Length; i++)
			{
				object keyVal = FindValue(piList, o, keys[i]);
				if (keyVal == null || (keyVal is string && (string)keyVal == ""))
					keyVal = DBNull.Value;
				SqlParameter sqlParam = new SqlParameter();
				sqlParam.ParameterName = "P" + i.ToString();
				sqlParam.Value = keyVal;
				cmd.Parameters.Add(sqlParam);
			}
		}
		public static object FindValue(PropertyInfo[] piList, object o, string propertyName)
		{
			foreach (PropertyInfo pi in piList)
			{
				if (string.Compare(pi.Name, propertyName, true) == 0)
				{
					return pi.GetValue(o);
				}
			}
			return null;
		}
		private static void AddValueParameter(this SqlCommand cmd, PropertyInfo[] piList, object o)
		{
			foreach (PropertyInfo pi in piList)
			{
				SqlParameter sqlParam = new SqlParameter();
				sqlParam.ParameterName = pi.Name;
				object val = pi.GetValue(o);
				if (val == null || (val is string && (string)val == ""))
					val = DBNull.Value;
				sqlParam.Value = val;
				cmd.Parameters.Add(sqlParam);
			}
		}
		public static int[] CreateOrdinalMap(this SqlDataReader reader, PropertyInfo[] piList)
		{
			int count = piList.Length;
			int[] map = new int[count];
			for (int i = 0; i < piList.Length; i++)
			{
				try
				{
					PropertyInfo pi = piList[i];
					int ordinal = reader.GetOrdinal(pi.Name);
					map[i] = ordinal;
				}
				catch (IndexOutOfRangeException ex)
				{
					throw new Exception("Cannot find column in the data soruce:" + ex.Message);
				}
			}
			return map;
		}

		//Other Extension Method

		public static void WriteIndentLine(this StreamWriter sw, int numofTab, string line)
		{
			if (numofTab != 0)
				line = new string('\t', numofTab) + line;
			sw.WriteLine(line);
		}
		public static void WriteIndentLine(this StreamWriter sw, string line)
		{
			sw.WriteLine(line);
		}
		public static string GetQuotedName(string fieldName)
		{
			return "[" + fieldName + "]";
		}
	}

}
