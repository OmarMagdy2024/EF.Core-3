﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<CouseStudent>  couseStudents { get; set; } = new HashSet<CouseStudent>();
    }
}
