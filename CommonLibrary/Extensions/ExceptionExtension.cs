using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
	public static class ExceptionExtension
	{
		public static string GetDescription(this Exception ex)
		{
			string desc = ex.Message;
			if (ex is AggregateException)
			{
				AggregateException ae = (AggregateException)ex;
				ae = ae.Flatten();
				if (ae.InnerExceptions != null)
				{
					foreach (Exception e in ae.InnerExceptions)
					{
						desc += "\n";
						desc += e.InnerException == null ? e.Message : e.InnerException.Message;

					}
				}
			}
			else
			{
				if (ex.InnerException != null)
				{
					desc += "\n";
					desc += ex.InnerException.Message;
				}
			}
			return desc;
		}
	}
}
