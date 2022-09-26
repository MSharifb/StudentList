using List.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace List.Controllers
{

    public class HomeController : Controller
    {
        student_Listv DATA = new student_Listv();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var StudentList = DATA.StudentListData();
            return View(StudentList);
        }

        [HttpPost]
        public ActionResult About(int i = 1)
        {
            //StudentListData DataTable = new StudentListData();

            var StudentList = DATA.StudentListData();
            string strserialize = JsonConvert.SerializeObject(StudentList);

            System.IO.File.WriteAllText(@"C:\Users\SHARIF\source\repos\practice\Json&XML\Test.json", strserialize);
            return View(StudentList);
        }

        public ActionResult About_Read()
        {
            string ReadFile = System.IO.File.ReadAllText(@"C:\Users\SHARIF\source\repos\practice\Json&XML\Test.json");
            var students = JsonConvert.DeserializeObject<List<student_List>>(ReadFile);


            return View(students);
        }

        //public ActionResult About_Read()
        //{
        //    string ReadFile = System.IO.File.ReadAllText(@"C:\Users\SHARIF\source\repos\practice\Json&XML\Test.json");
        //    var students = JsonConvert.DeserializeObject<List<student_List>>(ReadFile);


        //    return View(students);
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public ActionResult Pagination()
        //{
        //    return View();
        //}
    }

    
}

