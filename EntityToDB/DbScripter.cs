using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json;
using System.IO;
namespace EntityToDB
{

	public class DbScripter
	{
		private SortedList<string, string> m_dataTypeMap;

		public ODatabase ScriptDatabase(string connectiongString)
		{

			using (SqlConnection db = new SqlConnection(connectiongString))
			{
				db.Open();
				ODatabase database = ScriptDatabase(db);
				return database;
			}
		}
		public ODatabase ScriptDatabase(SqlConnection db)
		{
			InitDataTypeMap();
			ODatabase database = new ODatabase();
			database.DBName = db.Database;
			ScriptTables(database, db);
			ScriptViews(database, db);

			return database;
		}
		public bool DatabaseExist(string connectionString)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
			string dbName = builder.InitialCatalog;
			builder.InitialCatalog = "master";
			string masterString = builder.ToString();
			using (SqlConnection db = new SqlConnection(masterString))
			{
				db.Open();
				DataTable table = db.GetSchema("Databases", new string[] { dbName });
				if (table.Rows.Count == 0)
					return false;
				else
					return true;
			}
		}
		public void CreateDatabase(string connectionString)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
			string dbName = builder.InitialCatalog;
			builder.InitialCatalog = "master";
			string masterString = builder.ToString();
			using (SqlConnection db = new SqlConnection(masterString))
			{
				db.Open();
				string sql = string.Format("create database {0}", dbName);
				db.Execute(sql);
			}
		}
		public void Migrate(string connectiongString, ODatabase source)
		{

			if (!DatabaseExist(connectiongString))
			{
				CreateDatabase(connectiongString);
			}
			using (SqlConnection db = new SqlConnection(connectiongString))
			{
				db.Open();
				ODatabase destination = this.ScriptDatabase(db);
				MigrateTable(source, destination, db);
				MigrateView(source, destination, db);
			}
		}
		private void MigrateTable(ODatabase source, ODatabase destination, SqlConnection db)
		{
			foreach (OTable stable in source.Tables.OrderBy(t => t.TableName))
			{
				OTable dtable = destination.Tables.Where(t => string.Compare(t.TableName, stable.TableName, true) == 0).FirstOrDefault();
				if (dtable == null)
					CreateTable(db, stable);
				else
					AlterTable(db, stable, dtable);
				foreach (OIndex sindex in stable.Indexes)
				{
					if (dtable == null)
						CreateIndex(stable.TableName, sindex, db);
					else
					{
						OIndex dindex = dtable.Indexes.Where(i => i.IndexName == sindex.IndexName).FirstOrDefault();
						if (dindex == null)
							CreateIndex(stable.TableName, sindex, db);
					}
				}
			}
		}
		private void MigrateView(ODatabase source, ODatabase destination, SqlConnection db)
		{
			foreach (OView sview in source.Views)
			{

				OView dview = destination.Views.Where(v => v.ViewName == sview.ViewName).FirstOrDefault();
				if (dview != null)
					db.Execute("DROP VIEW  " + sview.ViewName);
				db.Execute(sview.CreateSql);
			}
		}
		private void CreateIndex(string tableName, OIndex oindex, SqlConnection db)
		{
			string sql = string.Format("CREATE INDEX {0} ON {1} ({2})", oindex.IndexName, tableName, oindex.Keys);
			db.Execute(sql);
		}
		private void AlterTable(SqlConnection db, OTable stable, OTable dtable)
		{
			foreach (OColumn scol in stable.Columns)
			{
				string sql = ("ALTER  TABLE " + DbUtil.GetQuotedName(stable.TableName));
				OColumn dcol = dtable.Columns.Where(c => c.ColumnName == scol.ColumnName).FirstOrDefault();
				if (dcol == null)
				{
					sql += " ADD ";
					sql += FormatColumDefinition(scol);
					db.Execute(sql);
				}
				else
				{
					if (scol.SqlType != dcol.SqlType || scol.MaxLength > dcol.MaxLength)
					{
						sql += " ALTER COLUMN ";
						sql += FormatColumDefinition(scol);
						db.Execute(sql);
					}
				}

			}
		}

		private void CreateTable(SqlConnection db, OTable stable)
		{
			string sql = string.Format("Create Table {0} (\n", DbUtil.GetQuotedName(stable.TableName));

			for (int i = 0; i < stable.Columns.Count; i++)
			{
				if (i > 0)
					sql += ",\n";
				OColumn col = stable.Columns[i];
				sql += FormatColumDefinition(col);
			}
			if (stable.PrimaryKeys != "")
			{
				sql += ",\n";
				sql += string.Format(" CONSTRAINT [pk_{0}_PrimaryKey] PRIMARY KEY CLUSTERED (", stable.TableName);
				string[] keys = stable.PrimaryKeys.Split(',');
				for (int i = 0; i < keys.Length; i++)
				{
					if (i > 0)
						sql += ",";
					sql += DbUtil.GetQuotedName(keys[i].Trim()) + " ASC";
				}
				sql += ")\n";
			}

			sql += ")";

			db.Execute(sql);
		}
		private string FormatColumDefinition(OColumn col)
		{
			string colDef = DbUtil.GetQuotedName(col.ColumnName) + " " + DbUtil.GetQuotedName(col.SqlType);
			if ((col.SqlType.ToLower() == "nvarchar" || col.SqlType.ToLower() == "varchar") && col.MaxLength != 0)
			{
				if (col.MaxLength > 0)
					colDef += "(" + col.MaxLength.ToString() + ")";
				else
					colDef += "(max)";
			}
			if (col.IsRequired)
				colDef += " NOT NULL";
			else
				colDef += " NULL";
			return colDef;
		}
		public void Save(ODatabase odb, string fileName)
		{
			JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };
			string jstr = JsonSerializer.Serialize(odb, options);
			File.WriteAllText(fileName, jstr);
		}
		public ODatabase Load(string fileName)
		{
			string jstr = File.ReadAllText(fileName);
			ODatabase odb = JsonSerializer.Deserialize<ODatabase>(jstr);
			return odb;
		}
		public ODatabase Parse(string jstr)
		{			
			ODatabase odb = JsonSerializer.Deserialize<ODatabase>(jstr);
			return odb;
		}
		private void InitDataTypeMap()
		{
			m_dataTypeMap = new SortedList<string, string>();
			m_dataTypeMap["bigint"] = "Int64";
			m_dataTypeMap["binary"] = "byte[]";
			m_dataTypeMap["bit"] = "bool";
			m_dataTypeMap["char"] = "string";
			m_dataTypeMap["date"] = "DateTime";
			m_dataTypeMap["datetime"] = "DateTime";
			m_dataTypeMap["datetime2"] = "DateTime";
			m_dataTypeMap["datetimeoffset"] = "DateTimeOffset";
			m_dataTypeMap["decimal"] = "decimal";
			m_dataTypeMap["FILESTREAM"] = "byte[]";
			m_dataTypeMap["float"] = "double";
			m_dataTypeMap["image"] = "byte[]";
			m_dataTypeMap["int"] = "int";
			m_dataTypeMap["money"] = "decimal";
			m_dataTypeMap["nchar"] = "string";
			m_dataTypeMap["ntext"] = "string";
			m_dataTypeMap["numeric"] = "decimal";
			m_dataTypeMap["nvarchar"] = "string";
			m_dataTypeMap["real"] = "float";
			m_dataTypeMap["rowversion"] = "byte[]";
			m_dataTypeMap["smalldatetime"] = "DateTime";
			m_dataTypeMap["smallint"] = "short";
			m_dataTypeMap["smallmoney"] = "decimal";
			m_dataTypeMap["sql_variant"] = "object";
			m_dataTypeMap["text"] = "string";
			m_dataTypeMap["time"] = "TimeSpan";
			m_dataTypeMap["timestamp"] = "byte[]";
			m_dataTypeMap["tinyint"] = "byte";
			m_dataTypeMap["uniqueidentifier"] = "Guid";
			m_dataTypeMap["varbinary"] = "byte[]";
			m_dataTypeMap["varchar"] = "string";
			m_dataTypeMap["xml"] = "Xml";
		}

		private void ScriptTables(ODatabase database, SqlConnection db)
		{
			DataTable table = db.GetSchema("Tables", new string[] { null, null, null, "BASE TABLE" });
			foreach (DataRow row in table.Rows)
			{
				string tableName = (string)row["table_name"];
				ScriptTable(db, database, tableName);
			}
		}
		private void ScriptViews(ODatabase database, SqlConnection db)
		{
			DataTable table = db.GetSchema("Tables", new string[] { null, null, null, "VIEW" });
			foreach (DataRow row in table.Rows)
			{
				string tableName = (string)row["table_name"];
				ScriptView(db, database, tableName);
			}
		}
		private void ScriptTable(SqlConnection db, ODatabase database, string tableName)
		{
			OTable otable = new OTable() { TableName = tableName };

			DataTable table = db.GetSchema("Columns", new string[] { null, null, tableName });
			foreach (DataRow row in table.Rows)
			{
				OColumn oc = GetColumn(row);
				otable.Columns.Add(oc);
			}
			DataTable indexTable = db.OpenTable(string.Format("sp_helpIndex {0}", otable.TableName));
			foreach (DataRow row in indexTable.Rows)
			{
				OIndex oi = new OIndex();
				oi.IndexName = (string)row["index_name"];
				oi.Description = (string)row["index_description"];
				oi.Keys = (string)row["index_keys"];

				otable.Indexes.Add(oi);
			}

			OIndex pkindex = otable.Indexes.Where(i => i.Description.Contains("primary key")).FirstOrDefault();
			if (pkindex != null)
			{
				otable.PrimaryKeys = pkindex.Keys;
				otable.Indexes.Remove(pkindex);
			}
			database.Tables.Add(otable);
		}
		private void ScriptView(SqlConnection db, ODatabase database, string viewName)
		{
			OView oview = new OView() { ViewName = viewName };
			DataTable table = db.GetSchema("Columns", new string[] { null, null, viewName });
			foreach (DataRow row in table.Rows)
			{
				OColumn oc = GetColumn(row);
				oview.Columns.Add(oc);
				oview.CreateSql = GetCreateSql(db, oview.ViewName);
			}
			database.Views.Add(oview);
		}
		private OColumn GetColumn(DataRow row)
		{
			OColumn oc = new OColumn();
			oc.ColumnName = (string)row["COLUMN_NAME"];
			oc.SqlType = (string)row["DATA_TYPE"];
			oc.SqlType = oc.SqlType.ToLower();
			oc.IsRequired = (string)row["IS_NULLABLE"] == "NO";
			oc.Type = ConvertDateType(oc.SqlType, oc.IsRequired);

			if (!row.IsNull("CHARACTER_MAXIMUM_LENGTH"))
				oc.MaxLength = (int)row["CHARACTER_MAXIMUM_LENGTH"];
			return oc;
		}
		private string GetCreateSql(SqlConnection db, string objectName)
		{
			string sqlSelect = string.Format("sp_helptext {0}", objectName);
			DataTable table = db.OpenTable(sqlSelect);
			if (table.Rows.Count == 0)
				return "";
			else
			{
				string sql = "";
				foreach (DataRow row in table.Rows)
				{
					string str = (string)row["text"];
					sql += str;
				}
				sql = sql.Replace("\n", " ");
				sql = sql.Replace("\r", " ");
				return sql;
			}
		}
		private string ConvertDateType(string sqlType, bool required)
		{
			if (m_dataTypeMap.ContainsKey(sqlType))
			{
				string clrType = m_dataTypeMap[sqlType];
				return clrType;
			}
			else
				throw new Exception(string.Format("Cannot map {0} to .net date type"));
		}
	}
}
