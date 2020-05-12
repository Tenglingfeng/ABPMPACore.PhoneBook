using Microsoft.AspNetCore.Antiforgery;
using Test.Controllers;

namespace Test.Web.Host.Controllers
{
    public class AntiForgeryController : TestControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
