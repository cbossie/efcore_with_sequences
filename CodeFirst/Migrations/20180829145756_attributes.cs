using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSequence.Migrations
{
    public partial class attributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleAttributes",
                columns: table => new
                {
                    RoleAttributeId = table.Column<int>(nullable: false),
                    UserRoleId = table.Column<int>(nullable: false),
                    Attribute = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.RoleAttributeId);
                    table.ForeignKey(
                        name: "FK_UserRoles_RoleAttributes",
                        column: x => x.UserRoleId,
                        principalTable: "UserRole",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleAttributes_UserRoleId",
                table: "RoleAttributes",
                column: "UserRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleAttributes");
        }
    }
}
