using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrainingManagement.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]  // Fetch property from datavase
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(AdminTb objUser) {
            if (ModelState.IsValid) {
                using (AssignmentWebDatabaseEntities db = new AssignmentWebDatabaseEntities()) {
                    var obj = db.AdminTbs.Where(a => a.Id.Equals(objUser.Id)).FirstOrDefault();
                    if (obj != null) {
                        Session["AdminId"] = obj.Id.ToString();
                        return RedirectToAction("AdminMenu");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult AdminMenu() {  // Redirect to admin menu if the login id is valid
            if (Session["AdminId"] != null) {
                return View();
            }
            else {
                return RedirectToAction("AdminLogin");
            }
        }
    }
}