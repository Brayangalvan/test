namespace EmpleoJIC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Field_Address_Telephone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Address", c => c.String());
            AddColumn("dbo.Companies", "Telephone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "Telephone");
            DropColumn("dbo.Companies", "Address");
        }
    }
}
