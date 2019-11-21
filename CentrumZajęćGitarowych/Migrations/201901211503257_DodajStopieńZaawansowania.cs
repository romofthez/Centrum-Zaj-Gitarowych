namespace CentrumZajęćGitarowych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajStopieńZaawansowania : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StopieńZaawansowania",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Kurs", "StopieńZaawansowaniaId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Kurs", "StopieńZaawansowaniaId");
            AddForeignKey("dbo.Kurs", "StopieńZaawansowaniaId", "dbo.StopieńZaawansowania", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kurs", "StopieńZaawansowaniaId", "dbo.StopieńZaawansowania");
            DropIndex("dbo.Kurs", new[] { "StopieńZaawansowaniaId" });
            DropColumn("dbo.Kurs", "StopieńZaawansowaniaId");
            DropTable("dbo.StopieńZaawansowania");
        }
    }
}
