using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class BlogPostController : Controller
    {
        //Create the context to avoid having to use "using" statements
        BlogPostContext db = new BlogPostContext();

        // GET: BlogPost
        public ActionResult Index()
        {
            ViewBag.AllBlogPosts = db.BlogPosts.OrderByDescending(p => p.Created).ToList();
            return View();
        }

        //Annotated post-to method
        //https://www.youtube.com/watch?v=wNVNy2V5PwQ
        [HttpPost]
        public ActionResult Create(BlogPost blogPost)
        {

            blogPost.Created = DateTime.Now;
            db.BlogPosts.Add(blogPost);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}