using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace garbageDetetionApi.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate : Migration
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
                    PhotoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfidenceSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weather = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Humidity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WindSpeed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garbages", x => x.Id);
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
