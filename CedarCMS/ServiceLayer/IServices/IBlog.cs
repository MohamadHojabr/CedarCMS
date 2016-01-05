using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.IServices
{
    public interface IBlog
    {
        IList<Blog> GetAllBlogs();
    }
}
