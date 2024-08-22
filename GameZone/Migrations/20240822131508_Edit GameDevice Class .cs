using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZone.Migrations
{
    /// <inheritdoc />
    public partial class EditGameDeviceClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "GameDevices");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "GameDevices");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "GameDevices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "GameDevices",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }
    }
}
