namespace MVCDealershipProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "Image");
        }
    }
}
