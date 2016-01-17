using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;
using ServiceLayer.IServices;

namespace ServiceLayer.EFServices
{
    public class EfContent : IContent
    {
        public IList<Content> GetAllContents()
        {
            throw new NotImplementedException();
        }

        public Content Get(int id)
        {
            throw new NotImplementedException();
        }

        public Content Add(Content categoriesContent)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Content categoriesContent)
        {
            throw new NotImplementedException();
        }
    }
}
