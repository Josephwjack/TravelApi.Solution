using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class Autho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Destinations");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Password = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Token = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Token", "Username" },
                values: new object[] { 1, "test", null, "Joe" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Token", "Username" },
                values: new object[] { 2, "test", null, "Matt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Destinations",
                type: "varchar(15) CHARACTER SET utf8mb4",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "UserName",
                value: "joe");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "UserName",
                value: "joe");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "UserName",
                value: "matt");
        }
    }
}
