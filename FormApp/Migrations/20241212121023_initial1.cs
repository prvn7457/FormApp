using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormApp.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressIDContentType",
                table: "CMRAFormModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "AddressIDData",
                table: "CMRAFormModels",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressIDFileName",
                table: "CMRAFormModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Form1583ContentType",
                table: "CMRAFormModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Form1583Data",
                table: "CMRAFormModels",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Form1583FileName",
                table: "CMRAFormModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoIDContentType",
                table: "CMRAFormModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PhotoIDData",
                table: "CMRAFormModels",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoIDFileName",
                table: "CMRAFormModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressIDContentType",
                table: "CMRAFormModels");

            migrationBuilder.DropColumn(
                name: "AddressIDData",
                table: "CMRAFormModels");

            migrationBuilder.DropColumn(
                name: "AddressIDFileName",
                table: "CMRAFormModels");

            migrationBuilder.DropColumn(
                name: "Form1583ContentType",
                table: "CMRAFormModels");

            migrationBuilder.DropColumn(
                name: "Form1583Data",
                table: "CMRAFormModels");

            migrationBuilder.DropColumn(
                name: "Form1583FileName",
                table: "CMRAFormModels");

            migrationBuilder.DropColumn(
                name: "PhotoIDContentType",
                table: "CMRAFormModels");

            migrationBuilder.DropColumn(
                name: "PhotoIDData",
                table: "CMRAFormModels");

            migrationBuilder.DropColumn(
                name: "PhotoIDFileName",
                table: "CMRAFormModels");
        }
    }
}
