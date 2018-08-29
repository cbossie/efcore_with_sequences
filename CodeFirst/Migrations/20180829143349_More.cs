using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSequence.Migrations
{
    public partial class More : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "UserRole",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR dbo.UserIDs",
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "UserRole",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "NEXT VALUE FOR dbo.UserIDs");
        }
    }
}
