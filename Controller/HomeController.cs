using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Model;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Index(createViewModel model, IFormFile[] imgfile)
        {
            Student newStudent = new Student
            {
                Name = model.Name
            };
            await context.Students.AddAsync(newStudent);
           await context.SaveChangesAsync();
            int latestId = newStudent.id;

           string imgsave=null;
                
                    foreach(IFormFile img in imgfile)
                    {
                     imgsave = Path.Combine(hostingEnvironment.WebRootPath, "img", img.FileName);
                    var stream = new FileStream(imgsave, FileMode.Create);
                    await img.CopyToAsync(stream);
                Photo newPhoto = new Photo();

                newPhoto.StudentId = latestId;
                newPhoto.PhotoPath = imgsave;
                await context.Photoo.AddAsync(newPhoto);
            }
                
           

           
           await context.SaveChangesAsync();

            return View(model);
        }

        
        //private string UploadFile(createViewModel model,IFormFile[] imgfile)
        //{
        //    string uniquefileName = null;
        //    if (model.Photos != null)
        //    {
        //        string Uplodefile = Path.Combine(hostingEnvironment.WebRootPath, "img");
        //        uniquefileName = Guid.NewGuid().ToString() + "_" + model.Photos.FileName;
        //        string filePath = Path.Combine(Uplodefile, uniquefileName);
        //        model.Photos.CopyTo(new FileStream(filePath, FileMode.Create));

        //    }

        //    return uniquefileName;
        //}
    }
}