using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace CommonLibrary
{
	public class AppResponse
	{
		private JObject m_jo;
		public string ResponseCode
		{
			get
			{
				return Get<string>("ResponseCode");
			}
			set
			{
				Set("ResponseCode", value);
			}
		}
		public AppResponse()
		{
			m_jo = new JObject();
		}
		public AppResponse(string jrsp)
		{
			m_jo = JObject.Parse(jrsp);
		}
		public bool IsSuccess()
		{
			return ResponseCode == "SUCCESS";
		}
		public void SetSuccess()
		{
			ResponseCode = "SUCCESS";
		}
		public void SetResult(object o)
		{
			Set("Result", o);
		}
		public T GetResult<T>()
		{
			T o = m_jo.Get<T>("Result");
			return o;
		}

		public T Get<T>(string name)
		{
			T o = m_jo.Get<T>(name);
			return o;
		}
		public void Set<T>(string name, T o)
		{
			m_jo.Set(name, o);
		}
		public override string ToString()
		{
			string jstr = m_jo.ToString();
			return jstr;
		}
	}
}
