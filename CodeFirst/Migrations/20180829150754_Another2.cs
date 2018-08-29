using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSequence.Migrations
{
    public partial class Another2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "UserIDs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "UserIDs",
                startValue: 5000L,
                incrementBy: 2);
        }
    }
}
