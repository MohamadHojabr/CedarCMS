using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.IServices;

namespace ServiceLayer.EFServices
{
    public class EfBlog:IBlog
    {
        IUnitOfWork _uow;
        IDbSet<Blog> _blog;
        public EfBlog(IUnitOfWork uow)
        {
            _uow = uow;
            _blog = _uow.Set<Blog>();
        }

        public IList<Blog> GetAllBlogs()
        {
            var list = _blog.ToList();
            return list;
        }
    }
}
