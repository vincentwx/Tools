using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CommonLibrary;
using AppService;
namespace ServiceTest.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class TSDataServiceController : ControllerBase
	{
		[HttpPost]
		public IActionResult Process()
		{
			string jreq = HttpUtil.ExtractText(Request.Body);
			AppRequest req = new AppRequest(jreq);

			DbService db = new DbService(null);

			AppResponse rsp = db.ProcessRequest(req);
			string jrsp = rsp.ToString();
			var ms = HttpUtil.CreateStream(jrsp);
			return File(ms, "application/octet-stream");
		}
	}
}
