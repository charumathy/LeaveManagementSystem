using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class UserAccountController : Controller
    {
        //
        // GET: /UserAccount/

        [Authorize(Roles="HR")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
