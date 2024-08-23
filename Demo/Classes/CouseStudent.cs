using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class CouseStudent
    {
        //[Key,Column(Order = 0)]
        public int CourseId { get; set; }

        //[Key,Column(Order = 1)]
        public int StudentId { get; set; }
        public int Grade { get; set; }
        public Course course { get; set; }
        public Student student { get; set; }
    }
}
