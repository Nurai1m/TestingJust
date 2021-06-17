using System;
using System.Collections.Generic;

namespace EducationSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Passport { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public List<Course> Courses { get; set; }
    }
}
