namespace CentrumZajęćGitarowych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajWłaściwościDoKlasyUżytkownika : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Imię", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "Nazwisko", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "NumerTelefonu", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NumerTelefonu");
            DropColumn("dbo.AspNetUsers", "Nazwisko");
            DropColumn("dbo.AspNetUsers", "Imię");
        }
    }
}
