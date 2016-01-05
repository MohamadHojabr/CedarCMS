namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        BlogName = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Blogs");
        }
    }
}
