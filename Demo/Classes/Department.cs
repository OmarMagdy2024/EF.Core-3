using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class Department
    {
        public string Name { get; set; }
        public int ID {  get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public ICollection<Employee> employees { get; set; }=new HashSet<Employee>();  
    }
}
