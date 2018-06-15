using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealership.Migrations
{
    public partial class InitModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Make = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    HasSunroof = table.Column<bool>(nullable: false),
                    IsFourWheelDrive = table.Column<bool>(nullable: false),
                    HasLowMiles = table.Column<bool>(nullable: false),
                    HasPowerWindows = table.Column<bool>(nullable: false),
                    HasNavigation = table.Column<bool>(nullable: false),
                    HasHeatedSeats = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
