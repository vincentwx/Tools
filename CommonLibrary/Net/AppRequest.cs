using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Reflection;

namespace CommonLibrary
{
	
	public class AppRequest: Dictionary<string, object>
	{
		public static AppRequest Parase(string jstr)
		{
			var req = JsonSerializer.Deserialize<AppRequest>(jstr);
			return req;
		}

		public string RequestCode
		{
			get
			{
				if (this.ContainsKey("RequestCode"))
					return (string)this[RequestCode];
				else
					return "";
			}
			set { this["RequestCode"] = value; }
		}
		public Type EntityType
		{
			get {
				string strType =(string) this["EntityType"];
				Type type = Type.GetType(strType);
				return type;
			}
			set
			{
				string strType = Assembly.CreateQualifiedName(value.Assembly.GetName().Name, value.FullName);
				this["EntityType"] = strType;
			}
		}
		public void SetParameters(object[] args)
		{
			List<Parameter> paramList = new List<Parameter>();
			foreach (object o in args)
			{
				Parameter param = new Parameter() { TypeName = o.GetType().Name, Value = o };
				paramList.Add(param);
			}
			this["Parameters"] = paramList;
		}
		public object[] GetParameters()
		{
			if (!this.ContainsKey("Parameters"))
				return new object[0];	
			JsonElement je =(JsonElement)this["Parameters"];
			List<Parameter> paramList = je.Deserialize<List<Parameter>>();

			object[] args = new object[paramList.Count];
			for (int i = 0; i < paramList.Count; i++)
			{
				Parameter param = paramList[i];
				object o = null;
				string typeName = param.TypeName;
				JsonElement jeVal = (JsonElement)param.Value;
				if (typeName == "Int32")
					o = jeVal.Deserialize<int>();
				else if (typeName == "String")
					o = jeVal.Deserialize<string>();
				else if (typeName == "Decimal")
					o = jeVal.Deserialize<decimal>();
				else if (typeName == "Double")
					o = jeVal.Deserialize<double>();
				else if (typeName == "DateTime")
					o = jeVal.Deserialize<DateTime>();
				else if (typeName == "DateTimeOffset")
					o = jeVal.Deserialize<DateTimeOffset>();
				else if (typeName == "Int16")
					o = jeVal.Deserialize<short>();
				else if (typeName == "Int64")
					o = jeVal.Deserialize<long>();
				else if (typeName == "Byte")
					o = jeVal.Deserialize<byte>();
				else if (typeName == "Single")
					o = jeVal.Deserialize<float>();
				args[i] = o;
			}
			return args;
		}
	}
}
