using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AvarIT.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfficeLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeLocations", x => x.Id);
                });

            migrationBuilder.AddColumn<int>(
                name: "OfficeLocationId",
                table: "ComputerCases",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComputerCases_OfficeLocationId",
                table: "ComputerCases",
                column: "OfficeLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerCases_OfficeLocations_OfficeLocationId",
                table: "ComputerCases",
                column: "OfficeLocationId",
                principalTable: "OfficeLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerCases_OfficeLocations_OfficeLocationId",
                table: "ComputerCases");

            migrationBuilder.DropIndex(
                name: "IX_ComputerCases_OfficeLocationId",
                table: "ComputerCases");

            migrationBuilder.DropColumn(
                name: "OfficeLocationId",
                table: "ComputerCases");

            migrationBuilder.DropTable(
                name: "OfficeLocations");
        }
    }
}
