using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }
        public ICollection<CouseStudent> couseStudents { get; set; } = new HashSet<CouseStudent>();
    }
}
