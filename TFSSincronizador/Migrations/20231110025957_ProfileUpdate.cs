using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFSSincronizador.Migrations
{
    public partial class ProfileUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JProject",
                table: "Profiles",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SyncDirection",
                table: "Profiles",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TFSCollection",
                table: "Profiles",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TFSProject",
                table: "Profiles",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JProject",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "SyncDirection",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "TFSCollection",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "TFSProject",
                table: "Profiles");
        }
    }
}
