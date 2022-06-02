using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CommonLibrary;
using TSDataDatabase;
using AppService;
using EntityToDB;
namespace ServiceTest.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class ServiceMainController : ControllerBase
	{
		public string Get()
		{
			return "Reached Service Hub:" + DateTime.Now.ToLongTimeString();
		}

		[ActionName("Process")]
		public HttpResponseMessage Process(HttpRequestMessage reqMsg)
		{

			string jreq = HttpUtil.ExtractRequest(reqMsg);
			AppRequest req = new AppRequest(jreq);
			AppResponse rsp = ProcessRequest(req);
			string jrsp = rsp.ToString();
			HttpResponseMessage rspMsg = HttpUtil.CreateResponse(jrsp);
			return rspMsg;
		}
		public AppResponse ProcessRequest(AppRequest req)
		{
			try
			{
				AppResponse rsp;

				string reqCode = req.RequestCode;

				string connectionString = DbUtil.GetConnectionString(@".\EXPRESS17", "TSData", "", "");

				using (TSDataDatabase.TSDataDbHandle db = new TSDataDatabase.TSDataDbHandle(connectionString))
				{
					if (reqCode.StartsWith("Db."))
					{
						DbService dbService = new DbService(db);
						rsp = dbService.ProcessRequest(req);
					}
					else
					{
						if (reqCode == "Echo")
						{
							rsp = new AppResponse();
							string content = req.Get<string>("Content");
							rsp.ResponseCode = "SUCCESS";
							rsp.Set("Content", "Back:" + content);
						}
						else
							throw new Exception(string.Format("Request Code [{0}] not found", reqCode));

					}
					return rsp;
				}
			}
			catch (Exception ex)
			{
				AppResponse rsp = new AppResponse();
				rsp.ResponseCode = "ERROR";
				rsp.Set("ErrorMsg", ex.Message);
				return rsp;
			}
		}
	}

}
