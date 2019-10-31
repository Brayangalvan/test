namespace EmpleoJIC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Usuario = c.String(),
                    Contraseña = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Companies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    City = c.String(),
                    Email = c.String(),
                    IdUser = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser);

            CreateTable(
                "dbo.PraticalOffers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    Description = c.String(),
                    IdCompany = c.Int(nullable: false),
                    IdProfile = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.IdCompany, cascadeDelete: true)
                .ForeignKey("dbo.Profiles", t => t.IdProfile, cascadeDelete: true)
                .Index(t => t.IdCompany)
                .Index(t => t.IdProfile);

            CreateTable(
                "dbo.Profiles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Companies", "IdUser", "dbo.Users");
            DropForeignKey("dbo.PraticalOffers", "IdProfile", "dbo.Profiles");
            DropForeignKey("dbo.PraticalOffers", "IdCompany", "dbo.Companies");
            DropIndex("dbo.PraticalOffers", new[] { "IdProfile" });
            DropIndex("dbo.PraticalOffers", new[] { "IdCompany" });
            DropIndex("dbo.Companies", new[] { "IdUser" });
            DropTable("dbo.Profiles");
            DropTable("dbo.PraticalOffers");
            DropTable("dbo.Companies");
            DropTable("dbo.Users");
        }
    }
}