using System;
using System.Collections.Generic;
using DomainClasses.Models;
using ServiceLayer.IServices;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using DataLayer.Context;


namespace ServiceLayer.EFServices
{
    public class EfCategoriesContent : ICategoriesContent , IDisposable
    {
        IUnitOfWork _ouw;
        IDbSet<CategoriesContent> _categoriesContents;

        public EfCategoriesContent(IUnitOfWork ouw)
        {
            _ouw = ouw;
            _categoriesContents = _ouw.Set<CategoriesContent>();
        }
        public IEnumerable<CategoriesContent> GetAllCategoriesContents()
        {
            var list = _categoriesContents.ToList();
            return list;
        }

        public CategoriesContent GetCategoriesContentById(int id)
        {
            var item = _categoriesContents.Find(id);
            return item;
        }

        public void InsertCategoriesContent(CategoriesContent categoriesContent)
        {
            _categoriesContents.Add(categoriesContent);
            return;

        }

        public void DeleteCategoriesContent(int id)
        {
           var item = _categoriesContents.Find(id);
            _categoriesContents.Remove(item);
            return;
        }

        public void UpdateCategoriesContent(CategoriesContent categoriesContent)
        {
            _categoriesContents.AddOrUpdate(categoriesContent);
        }

        public void Save()
        {
            _ouw.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _ouw.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}