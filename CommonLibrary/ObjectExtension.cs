using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CommonLibrary
{
	public static class ObjectExtension
	{
		public static void CopyFrom(this object o, object s)
		{
			Type ot = o.GetType();
			Type st = s.GetType();
			if (ot != st)
				throw new Exception("Cannot copy between with different type");
			PropertyInfo[] pl = ot.GetProperties();
			foreach (PropertyInfo pinfo in pl)
			{
				object val = pinfo.GetValue(s, null);
				pinfo.SetValue(o, val, null);
			}
		}
		public static T Clone<T>(this T s) where T : class, new()
		{
			Type st = typeof(T);
			T d = new T();
			PropertyInfo[] pl = st.GetProperties();
			foreach (PropertyInfo pinfo in pl)
			{
				object val = pinfo.GetValue(s, null);
				pinfo.SetValue(d, val, null);
			}
			return d;
		}
		public static void FillFrom(this object o, object s)
		{
			Type ot = o.GetType();
			Type st = s.GetType();
			PropertyInfo[] opl = ot.GetProperties();
			PropertyInfo[] spl = st.GetProperties();

			foreach (PropertyInfo pinfo in opl)
			{
				PropertyInfo sourceInfo = spl.FindProperty(pinfo.Name);
				if (sourceInfo == null)
					continue;
				object val = sourceInfo.GetValue(s, null);
				pinfo.SetValue(o, val, null);
			}
		}
		public static PropertyInfo FindProperty(this PropertyInfo[] pl, string propertyName)
		{
			foreach(PropertyInfo pinfo in pl)
			{
				if (pinfo.Name == propertyName)
					return pinfo;
			}
			return null;
		}
	}
}
