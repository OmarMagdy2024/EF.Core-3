using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core_3.Classes
{
    internal class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Course> courses { get; set; } = new HashSet<Course>();
    }
}
