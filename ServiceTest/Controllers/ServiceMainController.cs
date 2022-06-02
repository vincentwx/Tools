using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CommonLibrary;
using TSDataDatabase;
using AppService;
using EntityToDB;
namespace ServiceTest.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ServiceMainController : ControllerBase
	{
		[HttpGet]
		public string Get()
		{
			return "Reached Service Hub:" + DateTime.Now.ToLongTimeString();
		}

		[HttpPost]
		public IActionResult Process()
		{

			string jreq = HttpUtil.ExtractText(Request.Body);
			AppRequest req = new AppRequest(jreq);
			AppResponse rsp = ProcessRequest(req);
			string jrsp = rsp.ToString();
			var rspStream  = HttpUtil.CreateStream(jrsp);
			return File(rspStream, "application/octet-stream");
		}
		private AppResponse ProcessRequest(AppRequest req)
		{
			try
			{
				AppResponse rsp;

				string reqCode = req.RequestCode;

				string connectionString = DbUtil.GetConnectionString(@".\EXPRESS17", "", "", "TSData");

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
