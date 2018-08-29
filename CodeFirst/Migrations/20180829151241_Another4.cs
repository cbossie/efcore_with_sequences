using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSequence.Migrations
{
    public partial class Another4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "RoleAttributes",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "NEXT VALUE FOR dbo.roleAttributeIds");

            migrationBuilder.AlterColumn<int>(
                name: "RoleAttributeId",
                table: "RoleAttributes",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR dbo.roleAttributeIds",
                oldClrType: typeof(int));

            migrationBuilder.RestartSequence(
                name: "roleAttributeIds",
                startValue: 19777L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "RoleAttributes",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR dbo.roleAttributeIds",
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "RoleAttributeId",
                table: "RoleAttributes",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "NEXT VALUE FOR dbo.roleAttributeIds");

            migrationBuilder.RestartSequence(
                name: "roleAttributeIds",
                startValue: 5000L);
        }
    }
}
