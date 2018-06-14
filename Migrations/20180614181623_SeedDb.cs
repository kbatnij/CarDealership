using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealership.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cars (Make, Year, Color, Price, HasSunroof, IsFourWheelDrive, HasLowMiles, "
                + "HasPowerWindows, HasNavigation, HasHeatedSeats) VALUES ('Chevy', 2016, 'Gray', 16106, 0, 1, 1, 0, 1, 0)");
            migrationBuilder.Sql("INSERT INTO Cars (Make, Year, Color, Price, HasSunroof, IsFourWheelDrive, HasLowMiles, "
                + "HasPowerWindows, HasNavigation, HasHeatedSeats) VALUES ('Toyota', 2012, 'Silver', 18696, 1, 1, 0, 1, 0, 1)");
            migrationBuilder.Sql("INSERT INTO Cars (Make, Year, Color, Price, HasSunroof, IsFourWheelDrive, HasLowMiles, "
                + "HasPowerWindows, HasNavigation, HasHeatedSeats) VALUES ('Mercedes', 2016, 'Black', 18390, 1, 0, 0, 1, 1, 0)");
            migrationBuilder.Sql("INSERT INTO Cars (Make, Year, Color, Price, HasSunroof, IsFourWheelDrive, HasLowMiles, "
                + "HasPowerWindows, HasNavigation, HasHeatedSeats) VALUES ('Toyota', 2015, 'White', 15895, 1, 0, 1, 1, 0, 1)");
            migrationBuilder.Sql("INSERT INTO Cars (Make, Year, Color, Price, HasSunroof, IsFourWheelDrive, HasLowMiles, "
                + "HasPowerWindows, HasNavigation, HasHeatedSeats) VALUES ('Ford', 2014, 'Gray', 19710, 0, 1, 0, 0, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Cars (Make, Year, Color, Price, HasSunroof, IsFourWheelDrive, HasLowMiles, "
                + "HasPowerWindows, HasNavigation, HasHeatedSeats) VALUES ('Toyota', 2014, 'Red', 19248, 1, 0, 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Cars (Make, Year, Color, Price, HasSunroof, IsFourWheelDrive, HasLowMiles, "
                + "HasPowerWindows, HasNavigation, HasHeatedSeats) VALUES ('Toyota', 2015, 'Black', 13170, 1, 0, 1, 1, 0, 0)");
            migrationBuilder.Sql("INSERT INTO Cars (Make, Year, Color, Price, HasSunroof, IsFourWheelDrive, HasLowMiles, "
                + "HasPowerWindows, HasNavigation, HasHeatedSeats) VALUES ('Mercedes', 2013, 'Gray', 15669, 0, 0, 1, 0, 0, 0)");
            migrationBuilder.Sql("INSERT INTO Cars (Make, Year, Color, Price, HasSunroof, IsFourWheelDrive, HasLowMiles, "
                + "HasPowerWindows, HasNavigation, HasHeatedSeats) VALUES ('Toyota', 2015, 'White', 16629, 0, 0, 1, 0, 0, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
