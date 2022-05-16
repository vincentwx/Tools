using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntityToDB
{
	public class DbModelGenerator
	{

		public string DbContextFilePath { get; set; } = "";
		public string DbModelFilePath { get; set; } = "";
	

		public (string  , string ) GenerateAll(ODatabase database)
		{
			string contextFile = GenE2DBHandle(database);
			string modelFile = GenDBModel(database);
			return (contextFile, modelFile);
		}

		public string GenE2DBHandle(ODatabase database)
		{
			string fileName = string.Format(string.Format("{0}DbHandle.cs", database.DBName));
			string fullPathName = Path.Combine(DbContextFilePath, fileName);

			using (StreamWriter sw = new StreamWriter(fullPathName))
			{
				sw.WriteIndentLine("using System;");
				sw.WriteIndentLine("using System.Collections.Generic;");
				sw.WriteIndentLine("using EntityToDB;");
				sw.WriteIndentLine(string.Format("using {0}Model;", database.DBName));
				sw.WriteIndentLine(string.Format("namespace {0}Database", database.DBName));
				sw.WriteIndentLine("{");
				sw.WriteIndentLine(1, string.Format("public class {0}DbHandle : DbHandle", database.DBName));
				sw.WriteIndentLine(1, "{");

				sw.WriteIndentLine(2, string.Format("public {0}DbHandle(string connectiongString): base(connectiongString)", database.DBName));
				sw.WriteIndentLine(2, "{");
				sw.WriteIndentLine(2, "}");

				sw.WriteIndentLine(2, "protected override void OnDbConfig()");
				sw.WriteIndentLine(2, "{");
				sw.WriteIndentLine(3, "base.OnDbConfig();");

				foreach (OTable otable in database.Tables.OrderBy(t => t.TableName))
				{
					if (otable.PrimaryKeys != "") //configure primary key
					{
						sw.WriteIndentLine(3, string.Format("AddPrimaryKeyConfig(typeof({0}).Name, \"{1}\");", otable.TableName, otable.PrimaryKeys));
					}
				}
				sw.WriteIndentLine(2, "}");
				sw.WriteIndentLine(1, "}");
				sw.WriteIndentLine("}");
			}
			return fullPathName;
		}
		public string GenDBModel(ODatabase database)
		{
			string fileName = string.Format(string.Format("{0}Model.cs", database.DBName));
			string fullPathName = Path.Combine(DbModelFilePath, fileName);
			using (StreamWriter sw = new StreamWriter(fullPathName))
			{
				sw.WriteIndentLine("using System;");
				sw.WriteIndentLine("using System.Collections.Generic;");
				sw.WriteIndentLine("using System.Collections.ObjectModel;");
				sw.WriteIndentLine("using System.ComponentModel;");
				sw.WriteIndentLine("using System.Runtime.CompilerServices;");

				sw.WriteIndentLine(string.Format("namespace {0}Model", database.DBName));
				sw.WriteIndentLine("{");
				foreach (OTable otable in database.Tables.OrderBy(t => t.TableName))
				{
					GenClass(otable.TableName, otable.Columns, sw);
				}
				foreach (OView oview in database.Views.OrderBy(t => t.ViewName))
				{
					GenClass(oview.ViewName, oview.Columns, sw);
				}
				sw.WriteIndentLine("}");
			}
			return fullPathName;
		}
		private void GenClass(string name, List<OColumn> columns, StreamWriter sw)
		{
			sw.WriteIndentLine(1, string.Format("public partial class {0} : INotifyPropertyChanged", name));
			sw.WriteIndentLine(1, "{");

			sw.WriteIndentLine(2, @"public event PropertyChangedEventHandler PropertyChanged;");
			sw.WriteIndentLine(2, @"protected void NotifyPropertyChanged([CallerMemberName] string name = null)");
			sw.WriteIndentLine(2, @"{");
			//sw.WriteIndentLine(3, @"if (name == null)");
			//sw.WriteIndentLine(4, @"return;");
			sw.WriteIndentLine(3, @"PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));");
			sw.WriteIndentLine(2, @"}");
			foreach (OColumn oc in columns)
			{
				string propertyType = GetPropertyType(oc);
				if (oc.Type == "string")
				{
					sw.WriteIndentLine(2, string.Format("private {0} m_{1} = \"\";", propertyType, oc.ColumnName));
				}
				else
				{
					sw.WriteIndentLine(2, string.Format("private {0} m_{1};", propertyType, oc.ColumnName));
				}
				sw.WriteIndentLine(2, string.Format("public {0} {1} {{ get=>m_{1}; set {{ m_{1} = value; NotifyPropertyChanged(); }}}}", propertyType, oc.ColumnName));

			}
			sw.WriteIndentLine(2, string.Format("public {0}()", name));
			sw.WriteIndentLine(2, "{");

			sw.WriteIndentLine(2, "}");
			sw.WriteIndentLine(1, "}");
		}

		private string GetPropertyType(OColumn oc)
		{
			if ((oc.Type == "DateTime" || oc.Type == "DateTimeOffset") && !oc.IsRequired)
				return oc.Type + "?";
			else
				return oc.Type;
		}
		private bool CanTakeNull(string clrType)
		{
			if (
				clrType == "int"
				|| clrType == "Int64"
				|| clrType == "short"
				|| clrType == "byte"
				|| clrType == "bool"
				|| clrType == "DateTime"
				|| clrType == "DateTimeOffset"
				|| clrType == "decimal"
				|| clrType == "double"
				|| clrType == "float"
				|| clrType == "TimeSpan"
				)
				return false;
			else
				return true;
		}
	}
}
