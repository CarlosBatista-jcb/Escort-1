namespace Escort.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsDisabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "IsLocked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsLocked");
            DropColumn("dbo.AspNetUsers", "IsDisabled");
        }
    }
}
