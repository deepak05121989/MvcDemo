using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class WelcomeController : Controller
    {
        List<Student> students = new List<Student>();
        public WelcomeController()
        {
           
            students.Add(new Student
            {

                Name = "Trest",
                Address = "ddd",
                Mobile = "787878787",
                RollNo = 4578

            });
            students.Add(new Student
            {

                Name = "Trest",
                Address = "ddd",
                Mobile = "787878787",
                RollNo = 7545

            });
            students.Add(new Student
            {

                Name = "Trest",
                Address = "ddd",
                Mobile = "787878787",
                RollNo = 445212

            });
            students.Add(new Student
            {

                Name = "Trest",
                Address = "ddd",
                Mobile = "787878787",
                RollNo = 78787

            });
        }
        // GET: Welcome
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            var name = formCollection["name"];
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Student student)
        {
            var name = student.Name;
            return View();
        }
        [HttpGet]
        public ActionResult StudentsDetails()
        {
            

            return View(students);
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var name = students.FirstOrDefault(x => x.RollNo == id);
            return View(name);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            var name = student.Name;
            return View();
        }
    }
   
}