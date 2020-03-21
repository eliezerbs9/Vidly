namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd8242849-95b0-4ee9-9f9b-bfe45fcd30d7', N'admin@vidly.com', 0, N'AKrRPguaf+JEubDn7lakNG0Box7+fcdcGV+OPREanRbJ7RJXA3ULaFTr+vlYz+4fJw==', N'2c1063e1-ccf2-4c96-ba39-454dfa7a046e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e07ec7eb-55e8-4594-997d-36ee4e0031f6', N'guest@vidly.com', 0, N'AD4gu8hEJjeHG0/qf8CLOplea3G/J5YsfrfnyAgh3/CbSAEHAaXwgyXG/2qXZY68zQ==', N'7a226785-378a-44a0-a464-f3e7612aed6b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5e9e3602-fd4d-4450-9dd0-bd7e95229258', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd8242849-95b0-4ee9-9f9b-bfe45fcd30d7', N'5e9e3602-fd4d-4450-9dd0-bd7e95229258')

");
        }
        
        public override void Down()
        {
        }
    }
}
