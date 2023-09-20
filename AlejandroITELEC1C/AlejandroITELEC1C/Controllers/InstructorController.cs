using AlejandroITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlejandroITELEC1C.Controllers
{
        public class InstructorController : Controller
        {
            List<Instructor> InstructorList = new List<Instructor>()
        {
        new Instructor()
        {
            InstructorId = 1,
            InstructorFirstName = "Gabriel", InstructorLastName = "Montano", DateHired = DateTime.Now,
            InstructorEmail = "gdmontano@ust.edu.ph", InstructorRank = InstructorRank.Instructor, IsTenured = true
        },
        new Instructor()
        {
            InstructorId = 2,
            InstructorFirstName = "Leo", InstructorLastName = "Lintag", DateHired = DateTime.Parse("25/2/2002"),
            InstructorEmail = "Llintag@ust.edu.ph", InstructorRank = InstructorRank.AssistantProfessor, IsTenured = true
        },
        new Instructor()
        {
            InstructorId = 3,
            InstructorFirstName = "Zyx", InstructorLastName = "Lintag", DateHired = DateTime.Parse("25/3/2000"),
            InstructorEmail = "zmontano@ust.edu.ph", InstructorRank = InstructorRank.Professor, IsTenured = true
        },
        };

        public IActionResult Index()
        {

            return View(InstructorList);
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the instructors whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();

        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.InstructorId == instructorChanges.InstructorId);

            if (instructor != null)
            {
                instructor.InstructorFirstName = instructorChanges.InstructorFirstName;
                instructor.InstructorLastName = instructorChanges.InstructorLastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.InstructorRank = instructorChanges.InstructorRank;
                instructor.InstructorEmail = instructorChanges.InstructorEmail;
                instructor.DateHired = instructorChanges.DateHired;
            }

            return View("Index", InstructorList);
        }

    }
}
