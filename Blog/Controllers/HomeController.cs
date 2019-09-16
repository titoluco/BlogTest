using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public JsonResult LatestBlogPosts()
        {
            var posts = new List<BlogPost>() {
                         new BlogPost { PostId = 1, Title =
                        "xxx", ShortDescription = "xxx" },
                         new BlogPost { PostId = 2, Title =
                        "xxx", ShortDescription = "xxx" },
                         new BlogPost { PostId = 3, Title =
                        "xxx", ShortDescription = "xxx" },
                         new BlogPost { PostId = 4, Title =
                        "xxx", ShortDescription = "xxx" },
                         new BlogPost { PostId = 5, Title =
                        "xxx", ShortDescription = "xxx" }
            };
            return Json(posts);
        }

    }
}
