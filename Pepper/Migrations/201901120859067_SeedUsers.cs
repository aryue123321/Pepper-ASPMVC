namespace Pepper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5cd508d4-b5ee-47cd-af4c-fb9dadace46b', N'guste@pepper.com', 0, N'AOolyiuL2k1/8LNkKJSgnTdyJXz8c+Sbqxg3ZNwUC3k1zOWaTBo0ab/h58PyMC9kAw==', N'eb4f1f9f-3272-4be8-99f7-cb4f38fd601c', NULL, 0, 0, NULL, 1, 0, N'guste@pepper.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bd4d7d07-fecc-4ff4-a2db-8fe9ad1cc5d1', N'admin@pepper.com', 0, N'AEgeLJY5bjzTt2akgSz5txrxmnhmKNr6Pgj+LV+bFstP9h6ZKbz6Ebipas2UlKyvRQ==', N'0ed73dcd-9249-4131-9e18-1109def564c3', NULL, 0, 0, NULL, 1, 0, N'admin@pepper.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e264e08f-a504-4908-a7a0-2445d20bd529', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bd4d7d07-fecc-4ff4-a2db-8fe9ad1cc5d1', N'e264e08f-a504-4908-a7a0-2445d20bd529')
        ");
        


            }

        
        public override void Down()
        {
        }
    }
}
