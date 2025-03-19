using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went Hiking with Joe!", new DateTime(2025, 3, 7, 10, 28, 4, 604, DateTimeKind.Local).AddTicks(3942), "Went hiking" },
                    { 2, "Went shopping with Joe!", new DateTime(2025, 3, 7, 10, 28, 4, 604, DateTimeKind.Local).AddTicks(4131), "Went shopping" },
                    { 3, "Went diving with Joe!", new DateTime(2025, 3, 7, 10, 28, 4, 604, DateTimeKind.Local).AddTicks(4134), "Went diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
