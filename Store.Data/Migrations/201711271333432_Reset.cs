namespace Store.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {
            /*CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Desc = c.String(),
                        Version = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Gadgets",
                c => new
                    {
                        GadgetID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Dimension = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 8, scale: 2),
                        Image = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GadgetID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserID);*/
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Gadgets", "CategoryID", "dbo.Categories");
            //DropIndex("dbo.Gadgets", new[] { "CategoryID" });
            DropTable("dbo.Users");
            //DropTable("dbo.Gadgets");
            //DropTable("dbo.Categories");
        }
    }
}
