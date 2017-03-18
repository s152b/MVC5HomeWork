﻿using MVC5HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC5HomeWork.Controllers
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

        public ActionResult Login(LoginVM login, string ReturnUrl = "")
        {
            if (ModelState.IsValid)
            {
                FormsAuthentication.RedirectFromLoginPage(login.Username, false);

                if (!string.IsNullOrEmpty(ReturnUrl) && ReturnUrl.StartsWith("/"))
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return View("Index");
        }
    }
}