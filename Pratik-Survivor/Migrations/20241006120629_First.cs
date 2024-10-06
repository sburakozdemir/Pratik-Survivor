using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pratik_Survivor.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competitors_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5138), false, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5147), "Ünlüler" },
                    { 2, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5149), false, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5149), "Gönüllüler" }
                });

            migrationBuilder.InsertData(
                table: "Competitors",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "FirstName", "IsDeleted", "LastName", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5231), "Acun", false, "Ilıcalı", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5231) },
                    { 2, 1, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5233), "Aleyna", false, "Avcı", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5234) },
                    { 3, 1, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5235), "Hadise", false, "Açıkgöz", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5235) },
                    { 4, 1, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5236), "Sertan", false, "Bozkuş", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5236) },
                    { 5, 1, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5237), "Özge", false, "Açık", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5237) },
                    { 6, 1, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5238), "Kıvanç", false, "Tatlıtuğ", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5239) },
                    { 7, 2, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5239), "Ahmet", false, "Yılmaz", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5240) },
                    { 8, 2, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5240), "Elif", false, "Demirtaş", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5241) },
                    { 9, 2, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5241), "Cem", false, "Öztürk", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5242) },
                    { 10, 2, new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5243), "Ayşe", false, "Karaca", new DateTime(2024, 10, 6, 15, 6, 29, 199, DateTimeKind.Local).AddTicks(5243) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_CategoryId",
                table: "Competitors",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competitors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
