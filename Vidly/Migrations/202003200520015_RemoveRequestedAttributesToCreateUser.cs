namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequestedAttributesToCreateUser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "DrivingLicense");
            DropColumn("dbo.AspNetUsers", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "DrivingLicense", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
