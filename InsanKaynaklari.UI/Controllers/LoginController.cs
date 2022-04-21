﻿using InsanKaynaklari.UI.ViewModels.Login;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsanKaynaklari.DataAccess.Context;
using InsanKaynaklari.Business.Mailing;
using Microsoft.AspNetCore.Http;

namespace InsanKaynaklari.UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMailService _mailService;

        public LoginController(DatabaseContext context, IMailService mailService)
        {
            _context = context;
            _mailService = mailService;
        }
        [HttpGet]
        public IActionResult LogIn(string yonlen)
        {
            ViewBag.yonlen = yonlen;
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(LogInViewModel model, string yonlen)
        {
            if (!ModelState.IsValid) return View();
            var user = _context.Personels.FirstOrDefault(x => x.Email.Equals(model.Email) && x.Password.Equals(model.Password));
            var username = _context.PersonelDetails.Select(x => x.FirstName);
            var companyname = _context.Companies.Select(x => x.CompanyName);
            if (user is null)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!!");
                return View();
            }

            HttpContext.Session.SetString("userId", user.ID.ToString());
            HttpContext.Session.SetString("username", username.ToString());
            HttpContext.Session.SetString("usercompany", companyname.ToString());

            if (string.IsNullOrEmpty(yonlen))
            {
                return RedirectToAction("Index", "Home");
            }

            return Redirect(yonlen);
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("userId");
            HttpContext.Session.Remove("companyname");
            return RedirectToAction("Index", "Home");
        }
    }
}
