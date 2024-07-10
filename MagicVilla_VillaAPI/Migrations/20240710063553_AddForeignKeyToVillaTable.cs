using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "Numbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 10, 9, 35, 52, 483, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 10, 9, 35, 52, 483, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 10, 9, 35, 52, 483, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 10, 9, 35, 52, 483, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 10, 9, 35, 52, 483, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.CreateIndex(
                name: "IX_Numbers_VillaID",
                table: "Numbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Numbers_Villas_VillaID",
                table: "Numbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Numbers_Villas_VillaID",
                table: "Numbers");

            migrationBuilder.DropIndex(
                name: "IX_Numbers_VillaID",
                table: "Numbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "Numbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 16, 48, 30, 157, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 16, 48, 30, 157, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 16, 48, 30, 157, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 16, 48, 30, 157, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 16, 48, 30, 157, DateTimeKind.Local).AddTicks(4790));
        }
    }
}
