﻿namespace Nathan.Controllers
{
    using System.Web.Mvc;
    using Nathan.Helpers;
    using ViewModels;

    public class ContactController : BaseController
    {
        public ActionResult Index()
        {
            var viewModel = new ContactViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel submission)
        {
            if (ModelState.IsValid)
            {
                Emailer.SendMsg(
                    submission.Email, // From email
                    submission.Name, // From name
                    submission.Subject, // Subject
                    submission.Message, // Email body
                    null, // cc
                    null); // bcc
                return View("Confirm");
            }

            var viewModel = new ContactViewModel();
            return View(viewModel);
        }

        public ActionResult Confirm()
        {
            var viewModel = new ContactViewModel();
            return View("Confirm");
        }
    }
}