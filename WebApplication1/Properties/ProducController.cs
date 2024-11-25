using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Properties
{
    public class ProducController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
