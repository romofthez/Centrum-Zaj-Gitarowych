namespace CentrumZajęćGitarowych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodajUżytkowników : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'16e25c15-fcb0-4f17-90dc-ce21c029245e', N'nauczyciel@czg.pl', 0, N'AKXkmaSYtXiJUjrjhlvBS4L2n3EMUngI21IkcSEsHJQtHbTYKC/C0wUZSxi8B6oF0A==', N'd67bff1c-0295-4693-bb3d-3ebf6025472c', NULL, 0, 0, NULL, 1, 0, N'nauczyciel@czg.pl')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'55fb8e07-71bb-4a04-9763-c79502de1a21', N'uczen@czg.pl', 0, N'ACcUGzxfoDK9LI3WywS7OnwNph9I3XKfCGzzMC/pGpDks/xZ18sn+945fLeGe6hhKQ==', N'e65eeb84-d69f-4302-9fa1-5a2d6a21dcaa', NULL, 0, 0, NULL, 1, 0, N'uczen@czg.pl')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2372305a-4f8a-461f-a93b-103b1da9fe29', N'Nauczyciel')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'16e25c15-fcb0-4f17-90dc-ce21c029245e', N'2372305a-4f8a-461f-a93b-103b1da9fe29')

");
        }
        
        public override void Down()
        {
        }
    }
}
