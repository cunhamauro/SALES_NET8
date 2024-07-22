using Microsoft.AspNetCore.Mvc;

namespace Sales_NET8.Web.Controllers
{
    [Route("Sobre")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
