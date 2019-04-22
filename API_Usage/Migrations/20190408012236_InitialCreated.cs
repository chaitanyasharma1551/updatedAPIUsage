using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API_Usage.Migrations
{
    public partial class InitialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewShortInterest",
                table: "NewShortInterest");

            migrationBuilder.AlterColumn<string>(
                name: "DaystoCover",
                table: "NewShortInterest",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SettlementDate",
                table: "NewShortInterest",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewShortInterest",
                table: "NewShortInterest",
                column: "DaystoCover");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewShortInterest",
                table: "NewShortInterest");

            migrationBuilder.AlterColumn<string>(
                name: "SettlementDate",
                table: "NewShortInterest",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DaystoCover",
                table: "NewShortInterest",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewShortInterest",
                table: "NewShortInterest",
                column: "SettlementDate");
        }
    }
}
