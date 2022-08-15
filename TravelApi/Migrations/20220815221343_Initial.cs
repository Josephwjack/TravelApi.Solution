using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "varchar(300) CHARACTER SET utf8mb4", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Country", "Description", "Name", "State" },
                values: new object[] { 1, "United States", "Built in the 1960s for the world fair", "Space Needle", "Washington" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Country", "Description", "Name", "State" },
                values: new object[] { 2, "United States", "Home of the trailblazers", "Portland", "Oregon" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Country", "Description", "Name", "State" },
                values: new object[] { 3, "Canada", "Canada's Seattle", "Vancouver", "British Columbia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
