using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23533057_Practical_02.Models;

namespace u23533057_Practical_02.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentsList()
        {
            List<StudentsList> students = new List<StudentsList>
            {
                new StudentsList()
                {
                    StudentNumber = "u23533057",
                    FirstName = "Xolani",
                    LastName = "Tobo",
                    EmailAddress = "u23533057@tuks.co.za",
                    myLink = "~/HTML/Person 01.html",
                   
                },

                new StudentsList()
                {
                    StudentNumber = "u23552311",
                    FirstName = "Unathi",
                    LastName = "Mokgoetsi",
                    EmailAddress = "u23552311@tuks.co.za",
                    myLink = "~/HTML/Person 02.html"
                },

                new StudentsList()
                {
                    StudentNumber = "u22626752",
                    FirstName = "Sihle",
                    LastName = "Shange",
                    EmailAddress = "u22626752@tuks.co.za",
                    myLink = "~/HTML/Person 03.html"
                },

                new StudentsList()
                {
                    StudentNumber = "u23534134",
                    FirstName = "Khensani",
                    LastName = "Nkwinika",
                    EmailAddress = "u23534134@tuks.co.za",
                    myLink = "~/HTML/Person 04.html"
                },

                new StudentsList()
                {
                    StudentNumber = "u23583569",
                    FirstName = "Makgoshi",
                    LastName = "Mariri",
                    EmailAddress = "u23583569@tuks.co.za",
                    myLink = "~/HTML/Person 05.html"
                },

            };


            return View(students);
        }

    }
}