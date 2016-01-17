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

            modelBuilder.Entity<CategoriesContent>()
                        .HasOptional(x => x.Parent)
                        .WithMany(x => x.Children)
                        .HasForeignKey(x => x.ParentId)
                        .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);

        }


        public DbSet<Blog> Blogs { set; get; }
        public DbSet<CategoriesContent> CategoriesContents { set; get; }
        public DbSet<Content> Contents { set; get; }


        #region IUnitOfWork Members
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        #endregion
    }
}
