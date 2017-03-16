namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b5534600-430e-4349-ba97-e174a9dda75c', N'admin@vidly.com', 0, N'AGhd5gSZwV5OFfvhhqKiR+TzUBbC+jzSLsp12rBKi09OX9UFDS6DS9ONB2yur+/0JA==', N'872cf737-882a-44e2-8bd1-87c244ddbba7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'eababc33-7d1f-4d42-ac4d-f37310274055', N'guest@vidly.com', 0, N'ANfoz19a/AZlfyLuzNZgthRJUf5H/IHpl6EhJUvY1XkTjvFr3US+nluyuhnudoJkZg==', N'f50ef322-46a7-4055-8085-83cf6767a22e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2b8373a8-a633-486d-be34-5d013af09102', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b5534600-430e-4349-ba97-e174a9dda75c', N'2b8373a8-a633-486d-be34-5d013af09102')

");
            
        }
        
        public override void Down()
        {
        }
    }
}
