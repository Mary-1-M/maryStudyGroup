using System;
using System.Collections.Generic;
using System.Web.Mvc;
using maryStudyGroup.Models;

namespace maryStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // This static list keeps data in memory while the app is running
        private static readonly List<StudyGroup> students = new List<StudyGroup>()
        {
            new StudyGroup { StudentNumber = "23643570", Name = "Mary", Surname = "Modiba", EmailAddress = "u23643570@tuks.co.za" },
            new StudyGroup { StudentNumber = "24765377", Name = "Oratile", Surname = "Seshabela", EmailAddress = "u24765377@tuks.co.za" },
            new StudyGroup { StudentNumber = "23972123", Name = "Mosa", Surname = "Mane", EmailAddress = "u23972123@tuks.co.za" },
            new StudyGroup { StudentNumber = "23854830", Name = "Dakalo", Surname = "Nemamilwe", EmailAddress = "u23854830@tuks.co.za" },
            new StudyGroup { StudentNumber = "23598744", Name = "Khumo", Surname = "Mokaila", EmailAddress = "u23598744@tuks.co.za" }
        };

        // GET: StudyGroup
        public ActionResult Index()
        {
            return View(students);
        }

        // GET: StudyGroup/Add
        public ActionResult Add()
        {
            return View();
        }

        // POST: StudyGroup/Add
        [HttpPost]
        public ActionResult Add(StudyGroup newStudent)
        {
            if (ModelState.IsValid)
            {
                students.Add(newStudent);
                return RedirectToAction("Index");
            }
            return View(newStudent);
        }
    }
}
