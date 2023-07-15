using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewP.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'b33035bf-0cda-4302-8e70-bdbe2fe4e0ad', N'Admin@a.com', N'ADMIN@A.COM', N'Admin@a.com', N'ADMIN@A.COM', 0, N'AQAAAAEAACcQAAAAEIw/SLrEJLf3nNhX8nyMHer9hz1UYdI0PX9ohiVgfAVakEl6NMc/GjnriEX2xyveLQ==', N'F4JNGCOXIXOXQ5PAJYNK572P2ENFSWKE', N'0de61ce0-08fb-4ba0-8bb1-35dbd164b38f', N'717171717', 0, 0, NULL, 1, 0, N'SweetAsareer', N'Rassam', NULL");
          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = 'b33035bf-0cda-4302-8e70-bdbe2fe4e0ad'");
        }
    }
}
