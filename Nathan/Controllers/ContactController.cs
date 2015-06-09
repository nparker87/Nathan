namespace Nathan.Controllers
{
    using System.Web.Mvc;
    using ViewModels;

    public class ContactController : BaseController
    {
        public ActionResult Index()
        {
            var viewModel = new BaseViewModel
            {
                CurrentTab = "Contact"
            };
            return View(viewModel);
        }
    }
}