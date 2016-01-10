using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.IServices
{
    public interface ICategoriesContent
    {
        IList<CategoriesContent> GetAllCategoriesContents();
        CategoriesContent Get(int id);
        CategoriesContent Add(CategoriesContent categoriesContent);
        void Remove(int id);
        bool Update(CategoriesContent categoriesContent);

    }
}
