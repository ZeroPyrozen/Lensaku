using Lensaku.Helpers;
using Lensaku.Model.User;
using Lensaku.Service.Modules;
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
        public IUserService UserService;
        public AuthController(IUserService UserService)
        {
            this.UserService = UserService;
        }
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

        [HttpPost]
        public async Task<ActionResult> Login(AuthViewModel User)
        {
            //Simple Validation
            if (User.Username == null || User.Username.Trim() == "")
            {
                return Json(new { Status = "Fail", Message = "Username must be filled" });
            }
            if (User.Password == null || User.Password.Trim() == "")
            {
                return Json(new { Status = "Fail", Message = "Password must be filled" });
            }

            //Inisialisasi variable yang akan memvalidasi Password
            UserModel UserData = null;
            string username = "";
            string password = "";
            bool successVerifyPassword = false;

            try
            {
                username = User.Username;
                password = User.Password;
                UserData = await UserService.GetUser(username, password);
                if(UserData!=null)
                {
                    successVerifyPassword = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                successVerifyPassword = false;
            }
            if (successVerifyPassword)
            {
                if(UserData!=null)
                {
                    Session[SessionEnum.USER_ID] = UserData.UserID;
                    Session[SessionEnum.USER_ROLE_ID] = UserData.UserRole;
                    Session[SessionEnum.FULLNAME] = UserData.UserName;
                    Session[SessionEnum.EMAIL] = UserData.UserEmail;
                    return Json(new { Status = "Success", Message = "Success to Login" });
                }
                else
                {
                    return Json(new { Status = "Fail", Message = "Invalid Username or Password" });
                }
            }
            else
            {
                return Json(new { Status = "Fail", Message = "Invalid Username or Password" });
            }
        }
    }
}