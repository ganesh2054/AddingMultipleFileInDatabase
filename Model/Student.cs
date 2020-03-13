using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }

       
    }
}
