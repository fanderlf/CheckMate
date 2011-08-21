using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckMate.Contracts.Services;
using CheckMate.Services.Implementations;
using CheckMate.UI.Web.Fakes;
using CheckMate.UI.Web.Models;

namespace CheckMate.UI.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public UserController()
            :this(new UserService())
        {
            
        }

        public ActionResult Login()
        {
            return View(new UserLoginViewModel());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Login(UserLoginViewModel userLoginViewModel)
        {
            var username = userLoginViewModel.Username;
            var password = userLoginViewModel.Password;

            if (_userService.Login(username, password))
                return RedirectToAction("Home");

            return View(userLoginViewModel);
        }

        public ActionResult Home()
        {
            return View(new UserHomeViewModel());
        }
    }
}
