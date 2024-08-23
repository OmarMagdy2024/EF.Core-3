using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core_3.Classes
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; }

        [InverseProperty("departments")]
        [ForeignKey("Inst_ID")]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Instructor instructor { get; set; }

        [InverseProperty("department")]
        public ICollection<Instructor> instructors { get; set; } = new HashSet<Instructor>();
    }
}
