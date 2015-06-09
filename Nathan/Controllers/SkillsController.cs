namespace Nathan.Controllers
{
    using System.Web.Mvc;
    using ViewModels;

    public class SkillsController : BaseController
    {
        public ActionResult Index()
        {
            var viewModel = new BaseViewModel
            {
                CurrentTab = "Skills"
            };
            return View(viewModel);
        }
    }
}