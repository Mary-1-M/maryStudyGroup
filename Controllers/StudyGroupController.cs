using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace maryStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            List<Models.StudyGroup> students = new List<Models.StudyGroup>();

            students.Add(new Models.StudyGroup { StudentNumber = "23643570", Name = "Mary", Surname = "Modiba", EmailAddress = "u23643570@tuks.co.za" });
            students.Add(new Models.StudyGroup { StudentNumber = "24765377", Name = "Oratile", Surname = "Seshabela", EmailAddress = "u24765377@tuks.co.za" });
            students.Add(new Models.StudyGroup { StudentNumber = "23972123", Name = "Mosa", Surname = "Mane", EmailAddress = "u23972123@tuks.co.za" });
            students.Add(new Models.StudyGroup { StudentNumber = "23854830", Name = "Dakalo", Surname = "Nemamilwe", EmailAddress = "u23854830@tuks.co.za" });
            students.Add(new Models.StudyGroup { StudentNumber = "23598744", Name = "Khumo", Surname = "Mokaila", EmailAddress = "u23598744@tuks.co.za" });

            return View(students);
        }
    }
}