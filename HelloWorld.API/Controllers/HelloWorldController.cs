using HelloWorld.API.Business;
using HelloWorld.Domain.Interface;

using System.Web.Http;

namespace HelloWorld.API.Controllers
{
    /// <summary>
    /// Independent API which returns given message
    /// </summary>
    public class HelloWorldController : ApiController
    {
        private IDataRepository Repository { get; set; }
        public HelloWorldController() { }
        public HelloWorldController(IDataRepository _repository) => Repository = _repository;

        /// <summary>
        /// Returns the message
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult Print()
        {
            return Json(new WorkHandler(Repository).GetMessage());
        }
    }
}
