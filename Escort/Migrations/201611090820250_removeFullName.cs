namespace Escort.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeFullName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String());
        }
    }
}
