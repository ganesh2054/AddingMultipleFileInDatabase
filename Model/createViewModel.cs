
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    public class createViewModel
    {
        public string Name { get; set; }
        public IList<IFormFile> Photos { get; set; }
    }
}
