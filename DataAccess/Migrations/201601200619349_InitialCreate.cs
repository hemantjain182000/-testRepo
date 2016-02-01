namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PartModels",
                c => new
                    {
                        PartId = c.Int(nullable: false, identity: true),
                        PartDescription = c.String(),
                        UOM = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.PartId);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        LoginName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserRole = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserDetails");
            DropTable("dbo.PartModels");
        }
    }
}
