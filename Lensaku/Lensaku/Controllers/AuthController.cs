using Lensaku.Helpers;
using Lensaku.ViewModels.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lensaku.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            if(Session[SessionEnum.USER_ID] == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        //[HttpPost]
        //public async Task<ActionResult> Login(AuthViewModel User)
        //{
        //    //Simple Validation
        //    if (User.Username == null || User.Username.Trim() == "")
        //    {
        //        return Json(new { Status = "Fail", Message = "Username must be filled" });
        //    }
        //    if (User.Password == null || User.Password.Trim() == "")
        //    {
        //        return Json(new { Status = "Fail", Message = "Password must be filled" });
        //    }
        //}
    }
}