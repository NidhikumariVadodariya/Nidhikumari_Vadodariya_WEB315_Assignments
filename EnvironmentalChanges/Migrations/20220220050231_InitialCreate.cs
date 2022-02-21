using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnvironmentalChanges.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EChange",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypesOfWeather = table.Column<string>(type: "TEXT", nullable: true),
                    WeatherTiming = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FoodInWeather = table.Column<string>(type: "TEXT", nullable: true),
                    WeatherGarments = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EChange", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EChange");
        }
    }
}
