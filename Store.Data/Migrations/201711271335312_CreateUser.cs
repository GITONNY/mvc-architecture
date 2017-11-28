namespace Store.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CreateUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    UserID = c.Guid(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50)
                })
                .PrimaryKey(t => t.UserID);

            AddColumn("dbo.Gadgets", "Dimension", c => c.String());
        }


        public override void Down()
        {
            DropTable("dbo.Users");
            DropColumn("dbo.Gadgets", "Dimension");
        }
    }
    
}
