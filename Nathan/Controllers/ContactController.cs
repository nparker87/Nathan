namespace Nathan.Controllers
{
    using Nathan.Helpers;
    using System.Web.Mvc;
    using ViewModels;

    public class ContactController : BaseController
    {
        public ActionResult Index()
        {
            var viewModel = new ContactViewModel
            {
                CurrentTab = "Contact"
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel submission)
        {
            Emailer.SendMsg(
                submission.Email,                               // From email
                submission.Name,                                // From name
                submission.Subject,                             // Subject
                submission.Message,                             // Email body
                null,                                           // cc
                null);                                          // bcc
            return View("Confirm");
        }
    }
}