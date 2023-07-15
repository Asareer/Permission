using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewP.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles] (UserId, RoleId) SELECT '7433a0c4-7443-4214-aa10-086fcbcd5125' , Id FROM [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId = '7433a0c4-7443-4214-aa10-086fcbcd5125'");
        }
    }
}
