namespace CentrumZajęćGitarowych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajWpisyDoStopniZaawansowania : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO StopieńZaawansowania (Id, Nazwa) VALUES (1, 'Początkujący')");
            Sql("INSERT INTO StopieńZaawansowania (Id, Nazwa) VALUES (2, 'Średni')");
            Sql("INSERT INTO StopieńZaawansowania (Id, Nazwa) VALUES (3, 'Średnio-zaawansowany')");
            Sql("INSERT INTO StopieńZaawansowania (Id, Nazwa) VALUES (4, 'Zaawansowany')");
        }
        
        public override void Down()
        {
        }
    }
}
