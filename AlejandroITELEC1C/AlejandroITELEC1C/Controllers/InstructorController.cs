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
            InstructorEmail = "gdmontano@ust.edu.ph", InstructorRank = InstructorRank.Instructor
        },
        new Instructor()
        {
            InstructorId = 2,
            InstructorFirstName = "Leo", InstructorLastName = "Lintag", DateHired = DateTime.Parse("25/2/2002"),
            InstructorEmail = "Llintag@ust.edu.ph", InstructorRank = InstructorRank.AssistantProfessor
        },
        new Instructor()
        {
            InstructorId = 3,
            InstructorFirstName = "Zyx", InstructorLastName = "Lintag", DateHired = DateTime.Parse("25/3/2000"),
            InstructorEmail = "zmontano@ust.edu.ph", InstructorRank = InstructorRank.Professor
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
    }
    }
