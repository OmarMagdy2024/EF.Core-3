using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string? Address {  get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [ForeignKey("Dept_Id")]
        public Department Department { get; set; }
    }
}
