using System;
using System.Collections.Generic;
using DomainClasses.Models;
using ServiceLayer.IServices;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WebGrease.Css.Extensions;



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
                    CategoriesContentId = 1,
                    Name = "Root",
                    Children = new Collection<CategoriesContent>
                    {
                        new CategoriesContent
                        {
                            CategoriesContentId = 2,
                            Name = "Games",
                            Children = new Collection<CategoriesContent>
                            {
                                new CategoriesContent
                                {
                                    CategoriesContentId = 3,
                                    Name = "PSP",
                                    Children = Enumerable.Empty<CategoriesContent>().ToSafeReadOnlyCollection(),
                                },
                                new CategoriesContent
                                {
                                    CategoriesContentId = 4,
                                    Name = "PC",
                                    Children = Enumerable.Empty<CategoriesContent>().ToSafeReadOnlyCollection(),
                                },
                                new CategoriesContent
                                {
                                    CategoriesContentId = 5,
                                    Name = "PS3",
                                    Children = Enumerable.Empty<CategoriesContent>().ToSafeReadOnlyCollection(),
                                },
                            }
                        },
                        new CategoriesContent
                        {
                            CategoriesContentId = 6,
                            Name = "Application",
                            Children = new Collection<CategoriesContent>
                            {
                                new CategoriesContent
                                {
                                    CategoriesContentId = 7,
                                    Name = "Windows",
                                    Children = Enumerable.Empty<CategoriesContent>().ToSafeReadOnlyCollection(),
                                },
                                new CategoriesContent
                                {
                                    CategoriesContentId = 8,
                                    Name = "Android",
                                    Children = Enumerable.Empty<CategoriesContent>().ToSafeReadOnlyCollection(),
                                }
                            }
                        }
                    }
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
