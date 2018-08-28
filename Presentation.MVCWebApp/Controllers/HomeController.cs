using Services.Implementation.SqlPesistance;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.MVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        IUserManager _userManager;

        public HomeController()
        {
            this._userManager = new UserManagerSQL();
        }

        public ActionResult Index()
        {
            var userList = this._userManager.List();
            return View(userList);
        }
    }
}