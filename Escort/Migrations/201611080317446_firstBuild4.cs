namespace Escort.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstBuild4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        createdDate = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Transactions", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Transactions");
        }
    }
}
