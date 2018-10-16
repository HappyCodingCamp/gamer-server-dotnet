using Microsoft.EntityFrameworkCore.Migrations;

namespace GamerServer.Migrations
{
    public partial class FixedHappinessModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "level",
                table: "Happinesses",
                newName: "Level");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Happinesses",
                newName: "level");
        }
    }
}
