using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace garbageDetetionApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garbages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DetectedObject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfidenceScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weather = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Humidity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WindSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garbages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Garbages",
                columns: new[] { "Id", "ConfidenceScore", "DetectedObject", "Humidity", "ImageName", "Temp", "TimeStamp", "Weather", "WindSpeed" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), 0.95m, "Plastic Bottle", 45.0m, "plastic_bottle", 22.5m, new DateTime(2025, 5, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "Sunny", 5.2m },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 0.89m, "Can", 55.0m, "can", 18.3m, new DateTime(2025, 5, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), "Cloudy", 3.8m },
                    { new Guid("33333333-3333-3333-3333-333333333333"), 0.92m, "Paper", 80.0m, "paper", 16.0m, new DateTime(2025, 5, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "Rainy", 7.1m },
                    { new Guid("44444444-4444-4444-4444-444444444444"), 0.88m, "Glass", 50.0m, "glass", 20.0m, new DateTime(2025, 5, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), "Windy", 12.0m },
                    { new Guid("55555555-5555-5555-5555-555555555555"), 0.90m, "Food Wrapper", 40.0m, "food_wrapper", 24.0m, new DateTime(2025, 5, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), "Sunny", 4.5m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garbages");
        }
    }
}
