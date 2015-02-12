namespace MapsExample2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Label = c.String(),
                        Latitude = c.Single(nullable: false),
                        Longitude = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Location");
        }
    }
}
