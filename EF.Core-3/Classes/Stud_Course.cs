using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core_3.Classes
{
    internal class Stud_Course
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int Grade { get; set; }

        public Student Student { get; set; }

        public Course course { get; set; }
    }
}
