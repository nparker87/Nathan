namespace Nathan.Controllers
{
    using Models;
    using System.Web.Mvc;

    public class BaseController : Controller
    {
        private NathanDataContext _nathan;

        public NathanDataContext NathanModel
        {
            // need to build the db before this can work
            get { return _nathan; }
        }
    }
}