using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Properties
{
    public class StudentController : Controller
    {
        private static List<StudentModel> students = new List<StudentModel>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                students.Add(model);
                var sameMajorCount = students.Count(s => s.ChuyenNganh == model.ChuyenNganh);
                ViewBag.SameMajorCount = sameMajorCount - 1;
                return View("ShowKQ", model);
            }
            return View(Index);
        }
        public IActionResult ShowKQ(StudentModel model)
        {
            return View(model);
        }
    }
}
