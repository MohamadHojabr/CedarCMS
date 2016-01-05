using System.Web.Mvc;
using DataLayer.Context;
using ServiceLayer.IServices;

namespace CedarCMS.Controllers
{
    public class HomeController : Controller
    {

        private IUnitOfWork _uow;
        private IBlog _blog;

        

        public HomeController(IUnitOfWork uow, IBlog blog)
        {
            _uow = uow;
            _blog = blog;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.list = _blog.GetAllBlogs();
            return View();
        }
    }
}
