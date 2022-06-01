using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLibrary
{
	public static class JsonExtension
	{
		public static void Set<T>(this JObject jo, string name, T o)
		{
			JToken jt = jo.SelectToken(name);
			if (jt == null)
				jo.Add(name, o == null ? null : JToken.FromObject(o));
			else
				jt.Replace(o == null ? null : JToken.FromObject(o));
		}
		public static T Get<T>(this JObject jo, string name)
		{
			JToken jt = jo.GetValue(name);
			if (jt == null)
				throw new Exception(string.Format("Property {0} not found in JObject", name));
			var val = jt.ToObject<T>();
			return val;
		}
		public static T TryGet<T>(this JObject jo, string name)
		{
			JToken jt = jo.GetValue(name);
			if (jt == null)
			{
				return default(T);
			}
			var val = jt.ToObject<T>();
			return val;
		}
		public static List<object> GetList(this JObject jo, Type type, string name)
		{
			List<object> list = new List<object>();
			JArray ja = jo.Value<JArray>(name);
			foreach (JToken jt in ja)
			{
				object o = jt.ToObject(type);
				list.Add(o);
			}
			return list;
		}
	}
}
