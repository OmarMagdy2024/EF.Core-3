using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core_3.Classes
{
    internal class Course
    {
        public int ID { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Top_ID")]
        public Topic Topic { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();

        public ICollection<Course_Inst> Course_Insts { get; set; } = new HashSet<Course_Inst>();
    }
}
