using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MV.Controllers
{
    public class BlogController : Controller
    {

        public MO.BlogSvc svc;

        public BlogController() {
            svc = new MO.BlogSvc();
            }

        public ActionResult Index()
        {
            ViewBag.Day = svc.MathCalc.DateDifference(DateTime.Now, DateTime.Now.AddDays(-4));
            return View();
        }

        //GetAll
        public ActionResult GetAll()
        {
            var model = svc.BlogUserRepo.GetAll();
            return View(model);
        }


        //CreateBlogForm
        public ActionResult CreateBlogForm()
        {
            return View();
        }


        //CreateBlogger
        public ActionResult CreateBlogger(MD.BlogUser model)
        {
            svc.BlogUserRepo.Add(model);
            svc.BlogUserRepo.SaveTheChanges();
            return View("Index");
        }

        //ValidateUser
        public ActionResult ValidateUser(MD.BlogUser model)
        {
            var blogger = svc.BlogUserRepo.GetBlogger(model.Username, model.Password);
            if (blogger == null)
            {
               return RedirectToAction("Index");
            }

            Session["bloggerID"] = blogger.ID;
            Session["bloggerUser"] = blogger.Username;
            var BlogData = svc.BlogData.GetAll();
            return View("ShowBlogPage", BlogData);
        }

        //ShowBlogForm
        public ActionResult ShowBlogForm()
        {
            return View();
        }


        //AddBlog
        public ActionResult AddBlog(MD.BlogData model)
        {
            model.BlogID = Convert.ToInt16(Session["bloggerID"]);
            model.BlogDate = DateTime.UtcNow;
            model.BlogUser = svc.BlogUserRepo.GetByID(model.BlogID);

            svc.BlogData.Add(model);

            //var foo = svc.BlogUser.GetByID(model.BlogID);

            //var m = new List<MD.BlogData>();
            //m.Add(model);
            //foo.BlogDatas = m;
            
            //svc.BlogUser.SaveTheChanges();


            var BlogData = svc.BlogData.GetAll();
            return View("ShowBlogPage", BlogData);
        }


    }
}
