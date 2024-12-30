using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormApp.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CMRAFormModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePMBOpened = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatePMBClosed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddressDelivery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PMBNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessZIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoIDPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressIDPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Form1583Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMRAFormModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMRAFormModels");
        }
    }
}
