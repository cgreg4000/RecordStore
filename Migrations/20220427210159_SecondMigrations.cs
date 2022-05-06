using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordStore.Migrations
{
    public partial class SecondMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Records");

            migrationBuilder.AddColumn<string>(
                name: "Spotify",
                table: "Records",
                nullable: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Orders",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Spotify",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Records",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");
        }
    }
}
