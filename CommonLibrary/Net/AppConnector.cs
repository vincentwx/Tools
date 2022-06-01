using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
	public class AppConnector
	{
		public string ServerHost { get; set; }
		public AppResponse Send(AppRequest req)
		{
			return SendAsync(req).Result;		
		}
		public List<T> Query<T>(string sqlSelect, params object[] args) where T : class, new()
		{
			return QueryAsync<T>(sqlSelect, args).Result;
		}
		public List<T> Read<T>(string options, params object[] args) where T : class, new()
		{
			return ReadAsync<T>(options, args).Result;
		}
		public T Find<T>(string options, params object[] args) where T : class, new()
		{
			return FindAsync<T>(options, args).Result;
		}
		public int Insert<T>(T o)
		{
			return InsertAsync<T>(o).Result;
		}
		public int InsertRange<T>(List<T> list)
		{
			return InsertRangeAsync<T>(list).Result;
		}
		public int InsertRange<T>(List<T> list, string sqlClear, params object[] args)
		{
			return InsertRangeAsync<T>(list, sqlClear, args).Result;
		}
		public int Update<T>(T o)
		{
			return UpdateAsync<T>(o).Result;
		}
		public int UpdateRange<T>(List<T> list)
		{
			return UpdateRangeAsync<T>(list).Result;
		}
		public int Delete<T>(T o)
		{
			return DeleteAsync<T>(o).Result;
		}
		public int DeleteRange<T>(List<T> list)
		{
			return DeleteRangeAsync<T>(list).Result;
		}
		public int Execute(string sqlExecute, params object[] args)
		{
			return ExecuteAsync(sqlExecute, args).Result;
		}
		public T ExecuteSclar<T>(string sqlExecute, params object[] args)
		{
			return ExecuteSclarAsync<T>(sqlExecute, args).Result;
		}
		public int Save<T>(ChangeTrackableCollection<T> collection) where T:class,new()
		{
			return SaveAsync<T>(collection).Result;
		}
		public async Task<AppResponse> SendAsync(AppRequest req)
		{
			string jreq = req.ToString();

			HttpClient httpClient = new HttpClient();
			httpClient.Timeout = new TimeSpan(0, 0, 30);
			StreamContent streamContent = HttpUtil.CreateStreamContent(jreq);
			string url = ServerHost + "/api/ServiceMain/Process";
			HttpResponseMessage httpRsp = await httpClient.PostAsync(url, streamContent).ConfigureAwait(false);
			if (httpRsp.IsSuccessStatusCode)
			{
				string jrsp = HttpUtil.ExtractResponse(httpRsp);
				AppResponse rsp = new AppResponse(jrsp);
				if (rsp.IsSuccess())
					return rsp;
				else
				{
					string error = rsp.Get<string>("ErrorMsg");
					throw new Exception(error);

				}
			}
			else
			{
				string msg = httpRsp.ReasonPhrase;
				if (msg == null || msg == "")
					msg = "Unknown Error";
				throw new Exception(msg);
			}
		}
		//DB client method

		public async Task<List<T>> QueryAsync<T>(string sqlSelect, params object[] args) where T : class, new()
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.Query";
			req.Set("SqlSelect", sqlSelect);
			req.SetParameters(args);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			List<T> list = rsp.GetResult<List<T>>();
			return list;
		}
		public async Task<List<T>> ReadAsync<T>(string options, params object[] args) where T : class, new()
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.Read";
			req.Set("Options", options);
			req.SetParameters(args);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			List<T> list = rsp.GetResult<List<T>>();
			return list;
		}
		public async Task<T> FindAsync<T>(string options, params object[] args) where T : class, new()
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.Find";
			req.Set("Options", options);
			req.SetParameters(args);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			T o = rsp.GetResult<T>();
			return o;
		}
		public async Task<int> InsertAsync<T>(T o)
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.Insert";
			req.Set("RequestData", o);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			int n = rsp.GetResult<int>();
			return n;
		}
		public async Task<int> InsertRangeAsync<T>(List<T> list)
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.InsertRange";
			req.Set("RequestData", list);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			int n = rsp.GetResult<int>();
			return n;
		}
		public async Task<int> InsertRangeAsync<T>(List<T> list, string sqlClear, params object[] args)
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.InsertRange";
			req.Set("RequestData", list);
			req.Set("SqlClear", sqlClear);
			req.SetParameters(args);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			int n = rsp.GetResult<int>();
			return n;
		}
		public async Task<int> UpdateAsync<T>(T o)
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.Update";
			req.Set("RequestData", o);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			int n = rsp.GetResult<int>();
			return n;
		}
		public async Task<int> UpdateRangeAsync<T>(List<T> list)
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.UpdateRange";
			req.Set("RequestData", list);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			int n = rsp.GetResult<int>();
			return n;
		}
		public async Task<int> DeleteAsync<T>(T o)
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.Delete";
			req.Set("RequestData", o);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			int n = rsp.GetResult<int>();
			return n;
		}
		public async Task<int> DeleteRangeAsync<T>(List<T> list)
		{
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.DeleteRange";
			req.Set("RequestData", list);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			int n = rsp.GetResult<int>();
			return n;
		}
		public async Task<int> ExecuteAsync(string sqlExecute, params object[] args)
		{
			AppRequest req = new AppRequest();
			req.RequestCode = "Db.Execute";
			req.Set("SqlExecute", sqlExecute);
			req.SetParameters(args);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			int n = rsp.GetResult<int>();
			return n;
		}
		public async Task<T> ExecuteSclarAsync<T>(string sqlExecute, params object[] args)
		{
			AppRequest req = new AppRequest();
			req.RequestCode = "Db.ExecuteScalar";
			req.Set("SqlExecute", sqlExecute);
			req.SetParameters(args);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			T o = rsp.GetResult<T>();
			return o;
		}
		public async Task<int> SaveAsync<T>(ChangeTrackableCollection<T> collection) where T: class, new()
		{		
			List<ChangeRecord<T>> changeList = collection.GetChanges();
			AppRequest req = new AppRequest();
			req.SetEntityType(typeof(T));
			req.RequestCode = "Db.Save";
			req.Set("RequestData", changeList);
			AppResponse rsp = await SendAsync(req).ConfigureAwait(false);
			collection.AcceptChanges();
			int  n = rsp.GetResult<int>();
			return n;
		}
	}
}
