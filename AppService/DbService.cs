using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary;
using EntityToDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace AppService
{
	public class DbService : AppServiceBase
	{
		private DbHandle m_db;
		public DbService(DbHandle db)
		{
			m_db = db;
		}
		public AppResponse ProcessRequest(AppRequest req)
		{
			string reqCode = req.RequestCode;
			object[] args = req.GetParameters();

			object result;

			if (reqCode == "Db.Query")
			{
				Type type = req.GetEntityType();
				string sqlSelect = req.Get<string>("SqlSelect");
				result = m_db.Query(type, sqlSelect, args);
			}
			else if (reqCode == "Db.Read")
			{
				Type type = req.GetEntityType();
				string options = req.Get<string>("Options");
				result = m_db.Read(type, options, args);
			}
			else if (reqCode == "Db.Find")
			{
				Type type = req.GetEntityType();
				string options = req.Get<string>("Options");
				result = m_db.Find(type, options, args);
			}
			else if (reqCode == "Db.Insert")
			{
				Type type = req.GetEntityType();
				object o = req.Get(type, "RequestData");
				result = m_db.Insert(o);
			}
			else if (reqCode == "Db.InsertRange")
			{
				Type type = req.GetEntityType();
				List<object> list = req.GetList(type, "RequestData");
				string sqlClear = req.TryGet<string>("SqlClear");
				try
				{
					m_db.BeginTransaction();
					if (!string.IsNullOrEmpty(sqlClear))
						m_db.Execute(sqlClear, args);
					result = m_db.InsertRange(list);
					m_db.Commit();
				}
				catch
				{
					m_db.RollBack();
					throw;
				}
			}
			else if (reqCode == "Db.Update")
			{
				Type type = req.GetEntityType();
				object o = req.Get(type, "RequestData");
				result = m_db.Update(o);
			}
			else if (reqCode == "Db.UpdateRange")
			{
				Type type = req.GetEntityType();
				List<object> list = req.GetList(type, "RequestData");
				try
				{
					m_db.BeginTransaction();
					result = m_db.UpdateRange(list);
					m_db.Commit();
				}
				catch
				{
					m_db.RollBack();
					throw;
				}
			}
			else if (reqCode == "Db.Delete")
			{
				Type type = req.GetEntityType();
				object o = req.Get(type, "RequestData");
				result = m_db.Delete(o);
			}
			else if (reqCode == "Db.DeleteRange")
			{
				Type type = req.GetEntityType();
				List<object> list = req.GetList(type, "RequestData");
				try
				{
					m_db.BeginTransaction();
					result = m_db.DeleteRange(list);
					m_db.Commit();
				}
				catch
				{
					m_db.RollBack();
					throw;
				}
			}
			else if (reqCode == "Db.Save")
			{
				Type type = req.GetEntityType();
				List<ChangeRecord<object>> list = req.GetChangeList(type, "RequestData");
				try
				{
					m_db.BeginTransaction();
					result = m_db.SaveChanges(list);
					m_db.Commit();
				}
				catch
				{
					m_db.RollBack();
					throw;
				}
			}
			else if (reqCode == "Db.Execute")
			{
				string sqlExecute = req.Get<string>("SqlExecute");
				result = m_db.Execute(sqlExecute, args);
			}
			else if (reqCode == "Db.ExecuteScalar")
			{
				string sqlExecute = req.Get<string>("SqlExecute");
				result = m_db.ExecuteScalar(sqlExecute, args);
			}
			else
			{
				throw new Exception(string.Format("Request Code [{0}] not found in DbService", reqCode));
			}
			AppResponse rsp = new AppResponse();
			rsp.SetSuccess();
			rsp.SetResult(result);

			return rsp;

		}
	}
}
