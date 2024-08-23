using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core_3.Classes
{
    internal class Course_Inst
    {
        public int CourseID { get; set; }
        public int InstructorID { get; set; }
        public string Evaluate { get; set; }

        public Course course { get; set; }

        public Instructor instructor { get; set; }
    }
}
