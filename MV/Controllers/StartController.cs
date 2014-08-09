using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MV.Controllers
{
    public class StartController : Controller
    {
        //
        // GET: /Start/

        public MO.BaseSvc baseSvc;

        public StartController() {

            baseSvc = new MO.BaseSvc();
        }


        public ActionResult Index()
        {
            return View();
        }

        //AddUser
        public ActionResult AddUser()
        {
            return View("AddUserForm");
        }

        public ActionResult CreateANewUser(MD.user model)
        {
            baseSvc.BusRepo.Add(model);
            baseSvc.BusRepo.Save();
            return View(model);
        }

        //RemoveUser
        public ActionResult RemoveUser()
        {
            var model = baseSvc.BusRepo.GetAll();
            return View("RemoveUserListForm", model);
        }
    }
}
