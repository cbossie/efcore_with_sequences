using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSequence.Migrations
{
    public partial class Another : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "roleAttributeIds",
                startValue: 5000L,
                incrementBy: 14);

            migrationBuilder.CreateSequence(
                name: "UserRoleIDs",
                startValue: 5000L,
                incrementBy: 2);

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "UserRole",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR dbo.UserRoleIDs",
                oldClrType: typeof(int),
                oldDefaultValueSql: "NEXT VALUE FOR dbo.UserIDs");

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "RoleAttributes",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR dbo.roleAttributeIds",
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Seq",
                table: "RoleAttributes",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR dbo.roleAttributeIds");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "roleAttributeIds");

            migrationBuilder.DropSequence(
                name: "UserRoleIDs");

            migrationBuilder.DropColumn(
                name: "Seq",
                table: "RoleAttributes");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "UserRole",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR dbo.UserIDs",
                oldClrType: typeof(int),
                oldDefaultValueSql: "NEXT VALUE FOR dbo.UserRoleIDs");

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "RoleAttributes",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "NEXT VALUE FOR dbo.roleAttributeIds");
        }
    }
}
