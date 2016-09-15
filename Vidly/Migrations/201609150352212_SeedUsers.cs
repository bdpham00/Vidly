namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'44be0ab8-947f-4766-9f54-6b277db824e6', N'admin@bao.com', 0, N'AEUklpnN2RsvfA5di0urUmaTsRcFfPQpgux6QUUuiJ7/msN8c7AsRhdRH4ir543fng==', N'54c3e050-f66e-481f-a11b-609cde5ddd7f', NULL, 0, 0, NULL, 1, 0, N'admin@bao.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6c0a124e-919a-41d7-b522-dafa9b24500b', N'guest@bao.com', 0, N'AIsGoeYq3IEeZhulCvU4gkWr9vKHLgLb7OCVLiHC0SamyUNZCGzmDsKnMGwoaUJdYA==', N'3cb643b8-ea1f-4627-b726-6570f158ed52', NULL, 0, 0, NULL, 1, 0, N'guest@bao.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a89ffe09-d889-4b9f-9d1e-ccd867ae5dfd', N'bdpham00@gmail.com', 0, N'AB1ngJJ8buVoBPTe6GnooXqL/7ogdVde0Ye+kkFLu6JApWRALtExMnfI62Q7ZiBRHQ==', N'db081279-18bc-4dd3-97f6-0b79dfc6a199', NULL, 0, 0, NULL, 1, 0, N'bdpham00@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'724afb33-9e4f-4802-87fc-7df4825fa947', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'44be0ab8-947f-4766-9f54-6b277db824e6', N'724afb33-9e4f-4802-87fc-7df4825fa947')

        ");
        }
        
        public override void Down()
        {
        }
    }
}
