using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        
        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs
                            .Where(i => i.Confirm == true && i.HomePage == true)
                            .Select(i => new BlogModel()
                            {
                                Id = i.Id,
                                Title = i.Title.Length > 100 ? i.Title.Substring(0, 50) + "..." : i.Title,
                                Description = i.Description,
                                DateAdded = i.DateAdded,
                                HomePage = i.HomePage,
                                Confirm = i.Confirm,
                                Image = i.Image

                            });
            
            return View(blogs.ToList());
        }
    }
}