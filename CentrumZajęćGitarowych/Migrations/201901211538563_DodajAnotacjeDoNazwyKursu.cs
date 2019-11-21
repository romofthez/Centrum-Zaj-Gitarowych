namespace CentrumZajęćGitarowych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajAnotacjeDoNazwyKursu : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kurs", "Nazwa", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kurs", "Nazwa", c => c.String());
        }
    }
}
