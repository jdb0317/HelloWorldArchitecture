using HelloWorld.API.Business;
using HelloWorld.Domain.Interface;

using System.Web.Http;

namespace HelloWorld.API.Controllers
{
    /// <summary>
    /// Independent API which returns given message
    /// </summary>
    [Route("HelloWorld")]
    public class HelloWorldController : ApiController
    {
        IDataRepository Repository { get; set; }

        public HelloWorldController(IDataRepository _repository)
        {
            Repository = _repository;
        }

        [HttpGet]
        public IHttpActionResult Print()
        {
            return Json(new WorkHandler(Repository).GetMessage());
        }
    }
}
