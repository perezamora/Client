using AppMVCStudent.Common.Logic.Logger;
using AppMVCStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AppMVCStudent.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger _log;

        public LoginController(ILogger log)
        {
            _log = log;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel user)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);

            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = SelectUser(user);

                    if (usuario != null)
                    {
                        FormsAuthentication.SetAuthCookie(user.Username, true);
                        return RedirectToAction("Index", "Student");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Student");
                    }
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Error en Login");
            }
            return View();
        }

        private UserModel SelectUser(UserModel user)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                using (var context = new UserContext())
                {
                    var usuario = context.Users
                   .Where(userDB => (userDB.Username == user.Username &&
                                     userDB.Password == user.Password))
                   .FirstOrDefault();

                    return usuario;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

}