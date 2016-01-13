using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.IServices;

namespace CedarCMS.Controllers
{
    public class ValuesController : ApiController
    {
        private IUnitOfWork _uow;
        private ICategoriesContent _categoriesContent;



        public ValuesController(IUnitOfWork uow, ICategoriesContent categoriesContent)
        {
            _uow = uow;
            _categoriesContent = categoriesContent;
        }

        // GET api/values
        public IList<CategoriesContent> Get()
        {
            var list = _categoriesContent.GetAllCategoriesContents().ToList();
                
            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
