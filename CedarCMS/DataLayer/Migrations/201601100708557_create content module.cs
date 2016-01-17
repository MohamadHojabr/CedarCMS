namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createcontentmodule : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriesContents",
                c => new
                    {
                        CategoriesContentId = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Priority = c.Int(nullable: false),
                        Description = c.String(),
                        ParentId = c.Guid(),
                    })
                .PrimaryKey(t => t.CategoriesContentId)
                .ForeignKey("dbo.CategoriesContents", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        ContentId = c.Guid(nullable: false),
                        Name = c.String(),
                        CategoriesContent_CategoriesContentId = c.Guid(),
                    })
                .PrimaryKey(t => t.ContentId)
                .ForeignKey("dbo.CategoriesContents", t => t.CategoriesContent_CategoriesContentId)
                .Index(t => t.CategoriesContent_CategoriesContentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoriesContents", "ParentId", "dbo.CategoriesContents");
            DropForeignKey("dbo.Contents", "CategoriesContent_CategoriesContentId", "dbo.CategoriesContents");
            DropIndex("dbo.Contents", new[] { "CategoriesContent_CategoriesContentId" });
            DropIndex("dbo.CategoriesContents", new[] { "ParentId" });
            DropTable("dbo.Contents");
            DropTable("dbo.CategoriesContents");
        }
    }
}
