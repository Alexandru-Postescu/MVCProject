using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        /*
         * example of how to use the models. My idea is the register to be only with email and password
         * then it will direct the user to a new form with user details 
         * in this way we don't have to store the password in our local db 
         * also, to use the Bussiness Logic, Data Access and SqlDataAccess, don't forget to add the references
         * the models are tested and they work ok
         *
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(UsersModel model)
        {

            if (ModelState.IsValid)
            {
                int recordsCreated =
                    UsersProcessor.CreateUsers(model.UsersId, model.FirstName, model.LastName, model.UserEmail);
                return RedirectToAction("Index");
            }

            return View();
        }
        */
    }
}