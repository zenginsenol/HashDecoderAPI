using Microsoft.AspNetCore.Mvc;

namespace HashDecoderAPI.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => RedirectPermanent("swagger");
    }
}
