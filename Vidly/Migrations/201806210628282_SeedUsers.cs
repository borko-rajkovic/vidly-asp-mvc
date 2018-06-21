namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'048147c2-b049-4964-a8fb-6b7c06a733b1', N'admin@vidly.com', 0, N'AOp1oo5xr2KcD8eeBH07vKUNTNzXvV9X8/WhjGnASgdftvvN2YxVL1ewTa9pELPboQ==', N'795052af-81ee-4beb-9cef-6b68de2b5851', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'36aad932-9136-41d0-b0d5-90ab31300cb0', N'guest@vidly.com', 0, N'AG4gmDrSjEOJjNLJJDIC7eEess/1kqjWShjMN/qxLOea9ofqmnA+fQOnWSs3W3FP7w==', N'7f97cdad-652a-44d8-b593-bb3060155f6e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'40322e14-bf10-4084-97bc-7631eb9b9ed1', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'048147c2-b049-4964-a8fb-6b7c06a733b1', N'40322e14-bf10-4084-97bc-7631eb9b9ed1')
");
        }
        
        public override void Down()
        {
        }
    }
}
