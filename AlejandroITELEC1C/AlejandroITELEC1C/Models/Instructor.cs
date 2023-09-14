using AlejandroITELEC1C.Models;

namespace AlejandroITELEC1C.Models
{
    public enum InstructorRank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {
        public int InstructorId { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
        public Boolean IsTenured { get; set; }
        public DateTime DateHired { get; set; }
        public InstructorRank InstructorRank { get; set; }
        public string InstructorEmail { get; set; }

    }
}