using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
