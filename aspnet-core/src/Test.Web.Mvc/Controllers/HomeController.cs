using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Test.Controllers;

namespace Test.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
