using Microsoft.EntityFrameworkCore.Migrations;

namespace CubrisProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThemeParks",
                columns: table => new
                {
                    ThemeParkId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ThemeParkName = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThemeParks", x => x.ThemeParkId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThemeParks");
        }
    }
}
