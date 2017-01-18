namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'664e0666-428d-4009-b706-70ca2e2bed0e', N'guest@gmail.com', 0, N'AFU8hcojyYGfR5UTrP6fmjrqbE+pJH4T3/IXKxf+XX9yzTPU4iYin1M0yPhVJS4XDA==', N'f1210ec7-9677-4064-a3bc-ff67e7ae3cfc', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ab82e8cb-3e87-4216-b5ec-290379ff849a', N'admin@gmail.com', 0, N'ADnkODTaBl3YzSSRadN7cujDLO/v5m4oqFIgSnk3SasgpAcp/kMjCBUvQUHILaXqVA==', N'cc180160-cb57-4232-8866-4791fb944456', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b729f412-df42-403c-8367-0f6ec88bfe59', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ab82e8cb-3e87-4216-b5ec-290379ff849a', N'b729f412-df42-403c-8367-0f6ec88bfe59')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
