using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2pssc.Models;

namespace T2pssc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Student(StudentModel obj)
        {
            ViewBag.Msg = "The student having name" + obj.Name + "of class" + obj.An + "added";
            return View();
        }
    }
}