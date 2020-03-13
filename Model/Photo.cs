using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class Photo
    {
        public int id { get; set; }
        public  string PhotoPath { get; set; }
        public Nullable<int> StudentId { get; set; }
        public virtual Student Student{ get; set; }
    }
}
