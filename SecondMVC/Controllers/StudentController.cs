using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondMVC.Models;

namespace SecondMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //Mockup Data
            Student s1 = new Student() { Name = "George", Score=50 };
            Student s2 = new Student() { Name = "John", Score=60 };
            Student s3 = new Student() { Name = "Antonis", Score=70 };
            
            List<Student> students = new List<Student>(){ s1,s2,s3};

            return View(students);
        }
    }
}