using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.IServices
{
    public interface ICategoriesContent : IDisposable
    {
        IEnumerable<CategoriesContent> GetAllCategoriesContents();
        CategoriesContent GetCategoriesContentById(int categoriesContentId);
        void InsertCategoriesContent(CategoriesContent categoriesContent);
        void DeleteCategoriesContent(int categoriesContentId);
        void UpdateCategoriesContent(CategoriesContent categoriesContent);
        void Save();
    }
}
