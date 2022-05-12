using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web123456.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string name, string account, string password)
        {
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入姓名"; // 要 using Microsoft.Ajax.Utilities;
            }

            if (account == null || account == "")
            {
                ViewBag.AccountMessage = "請輸入帳號";
            }

            if (password == null || password == "")
            {
                ViewBag.PasswordMessage = "請輸入密碼";
            }

            if (name != "" && account != "" && password != "") {
                ViewBag.Message = "註冊成功";
            }

            return View();
        }
    }
}