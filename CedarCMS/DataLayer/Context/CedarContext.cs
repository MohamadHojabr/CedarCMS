using System.Data.Entity;
using DomainClasses.Models;

namespace DataLayer.Context
{
    public class CedarContext : DbContext, IUnitOfWork
    {
        public CedarContext()
            : base("CedarContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }


        public DbSet<Blog> Blogs { set; get; }


        #region IUnitOfWork Members
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        #endregion
    }
}
