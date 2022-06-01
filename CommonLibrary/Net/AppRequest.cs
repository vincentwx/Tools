using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace CommonLibrary
{
	public class AppRequest
	{
		private JObject m_jo;

		public string RequestCode
		{
			get
			{
				return Get<string>("RequestCode");
			}
			set
			{
				Set("RequestCode", value);
			}
		}
		public AppRequest()
		{
			m_jo = new JObject();
		}
		public AppRequest(string jstr)
		{
			m_jo = JObject.Parse(jstr);
		}
		public T Get<T>(string name)
		{
			T o = m_jo.Get<T>(name);
			return o;
		}
		public T TryGet<T>(string name)
		{
			T o = m_jo.TryGet<T>(name);
			return o;
		}
		public object Get(Type type, string name)
		{
			object o = m_jo.GetValue(name).ToObject(type);
			return o;
		}
		public List<object> GetList(Type type, string name)
		{
			List<object> list = m_jo.GetList(type, name);
			return list;
		}
		public List<ChangeRecord<object>> GetChangeList(Type type, string name)
		{
			List<ChangeRecord<object>> list = new List<ChangeRecord<object>>();
			JArray ja = m_jo.Value<JArray>(name);
			foreach (JObject jo in ja)
			{
				object curnet = jo.GetValue("Current").ToObject(type);
				object original = jo.GetValue("Original").ToObject(type);
				string str = jo.GetValue("State").ToString();
				ObjectState state = (ObjectState) Enum.Parse(typeof(ObjectState), str);

				ChangeRecord<object> record = new CommonLibrary.ChangeRecord<object> { Current = curnet, Original = original, State = state };
				list.Add(record);
			}
			return list;
		}
		public void Set<T>(string name, T o)
		{
			m_jo.Set(name, o);
		}
		public void SetParameters(object[] args)
		{
			JArray ja = new JArray();
			foreach(object o in args)
			{
				JObject jo = new JObject();

				jo.Add("TypeName", o.GetType().Name);
				jo.Add("Val", JToken.FromObject(o));

				ja.Add(jo);
			}
			m_jo.Set("Parameters", ja);

		}
		public object[] GetParameters()
		{
			JArray ja = m_jo.Value<JArray>("Parameters");
			if (ja == null)
				return new object[0];
			object[] args = new object[ja.Count];
			for (int i = 0; i < ja.Count; i++)
			{
				JObject jo = (JObject)ja[i];
				object o = null;
				string typeName = jo.Value<string>("TypeName");
				if (typeName == "Int32")
					o = jo.Value<int>("Val");
				else if (typeName == "String")
					o = jo.Value<string>("Val");
				else if (typeName == "Decimal")
					o = jo.Value<decimal>("Val");
				else if (typeName == "Double")
					o = jo.Value<double>("Val");
				else if (typeName == "DateTime")
					o = jo.Value<DateTime>("Val");
				else if (typeName == "DateTimeOffset")
					o = jo.Value<DateTimeOffset>("Val");
				else if (typeName == "Int16")
					o = jo.Value<short>("Val");
				else if (typeName == "Int64")
					o = jo.Value<long>("Val");
				else if (typeName == "Byte")
					o = jo.Value<byte>("Val");
				else if (typeName == "Single")
					o = jo.Value<float>("Val");
				args[i] = o;
			}
			return args;
		}

		public void SetEntityType(Type type)
		{
			string strType = 	Assembly.CreateQualifiedName(type.Assembly.GetName().Name, type.FullName);
			m_jo.Set("EntityType", strType);
		}
		public Type GetEntityType()
		{
			string strType = m_jo.Get<string>("EntityType");

			Type type = Type.GetType(strType);
			return type;
		}
		public override string ToString()
		{
			string jstr = m_jo.ToString();
			return jstr;
		}
	}
}
