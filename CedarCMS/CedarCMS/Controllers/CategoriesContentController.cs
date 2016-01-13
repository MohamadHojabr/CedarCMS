using System.Collections.Generic;
using System.Web.Http;
using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.IServices;

namespace CedarCMS.Controllers
{
    public class CategoriesContentController : ApiController
    {
        private IUnitOfWork _ouw;
        private ICategoriesContent _categoriesContent;

        public CategoriesContentController(IUnitOfWork ouw, ICategoriesContent categoriesContent)
        {
            _ouw = ouw;
            _categoriesContent = categoriesContent;
        }

        public IEnumerable<CategoriesContent> GetAllCategoriesContents()
        {
           var list = _categoriesContent.GetAllCategoriesContents();
           return list;
        }

        public IHttpActionResult GetCategoriesContentsById(int id)
        {
            var item = _categoriesContent.GetCategoriesContentById(id);
            
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
