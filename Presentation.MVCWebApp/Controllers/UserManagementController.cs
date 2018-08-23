using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.MVCWebApp.Controllers
{
    public class UserManagementController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}