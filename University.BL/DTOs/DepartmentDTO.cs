using System;
namespace University.BL.DTOs
{
    public class DeparmentDTO
    {
        public InstructorDTO Instructor;

        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }

        public int InstructorID { get; set; }

    }
}
