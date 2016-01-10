using System;
using System.Collections.Generic;
using DomainClasses.Models;
using ServiceLayer.IServices;

namespace ServiceLayer.EFServices
{
    public class EfCategoriesContent : ICategoriesContent
    {
        public IList<CategoriesContent> GetAllCategoriesContents()
        {
            var cat = new List<CategoriesContent>
            {
                new CategoriesContent
                {
                    CategoriesContentId = new Guid("8cb1eb8a-506b-4da8-9f0a-734ffdff1da8"),
                    Description = "sfsdsf",
                    Name = "دسته والد",
                    ParentId = null,
                    Priority = 1
                },
                new CategoriesContent
                {
                    CategoriesContentId = new Guid("5a0d6276-e5c8-498f-89c9-6a68c5e957fa"),
                    Description = "sfsdsf",
                    Name = "دسته والد",
                    ParentId = new Guid("8cb1eb8a-506b-4da8-9f0a-734ffdff1da8"),
                    Priority = 1
                },
                new CategoriesContent
                {
                    CategoriesContentId = new Guid("33583877-759a-46e6-a888-69a547ba0e6c"),
                    Description = "sfsdsf",
                    Name = "دسته والد",
                    ParentId = new Guid("8cb1eb8a-506b-4da8-9f0a-734ffdff1da8"),
                    Priority = 1
                },
                new CategoriesContent
                {
                    CategoriesContentId = new Guid("49538bc1-f190-42d1-9d8c-37ea6355c972"),
                    Description = "sfsdsf",
                    Name = "دسته والد",
                    ParentId = null,
                    Priority = 1
                }
            };

            return cat;
        }

        public CategoriesContent Get(int id)
        {
            throw new NotImplementedException();
        }

        public CategoriesContent Add(CategoriesContent categoriesContent)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoriesContent categoriesContent)
        {
            throw new NotImplementedException();
        }
    }
}
