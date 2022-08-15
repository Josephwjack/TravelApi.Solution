using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Country", "Name", "State" },
                values: new object[] { 1, "United States", "Space Needle", "Washington" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Country", "Name", "State" },
                values: new object[] { 2, "United States", "Portland", "Oregon" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Country", "Name", "State" },
                values: new object[] { 3, "Canada", "Vancouver", "British Columbia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);
        }
    }
}
