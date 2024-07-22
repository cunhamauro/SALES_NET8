using Microsoft.AspNetCore.Mvc;

namespace Sales_NET8.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
