using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Properties
{
    public class SinhVienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult detail()
        {
            ViewBag.abc = "day la abc";
            ViewBag.date=DateTime.Now;
            return View();
        }

    
    }
}
