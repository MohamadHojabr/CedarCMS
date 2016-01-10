using System.Linq;
using System.Web.Mvc;
using DataLayer.Context;
using ServiceLayer.IServices;

namespace CedarCMS.Controllers
{
    public class HomeController : Controller
    {

        private IUnitOfWork _uow;
        private IBlog _blog;
        private ICategoriesContent _categoriesContent;


        public HomeController(IUnitOfWork uow, IBlog blog, ICategoriesContent categoriesContent)
        {
            _uow = uow;
            _blog = blog;
            _categoriesContent = categoriesContent;

        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var cat = _categoriesContent.GetAllCategoriesContents();
            ViewBag.list = cat;
            return View();
        }

    }
}
