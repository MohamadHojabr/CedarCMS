using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.IServices
{
    public interface IContent
    {
        IList<Content> GetAllContents();
        Content Get(int id);
        Content Add(Content categoriesContent);
        void Remove(int id);
        bool Update(Content categoriesContent);

    }
}
