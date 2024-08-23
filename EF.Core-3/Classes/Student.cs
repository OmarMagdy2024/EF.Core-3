using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core_3.Classes
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        [ForeignKey("Dept_ID")]
        public Department Department { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();

    }
}
