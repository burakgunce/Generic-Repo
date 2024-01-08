using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenericRepo.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreationDate", "Name" },
                values: new object[] { 1, "Alibeyköy", new DateTime(2024, 1, 2, 14, 11, 3, 251, DateTimeKind.Local).AddTicks(7402), "Bilgi" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreationDate", "Name" },
                values: new object[] { 2, "Fatih", new DateTime(2024, 1, 2, 14, 11, 3, 251, DateTimeKind.Local).AddTicks(7413), "KHAS" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassName", "CreationDate", "Name", "SchoolId" },
                values: new object[,]
                {
                    { 1, "EEEN", new DateTime(2024, 1, 2, 14, 11, 3, 251, DateTimeKind.Local).AddTicks(7520), "Bg", 1 },
                    { 2, "EEEN", new DateTime(2024, 1, 2, 14, 11, 3, 251, DateTimeKind.Local).AddTicks(7522), "OÜ", 1 },
                    { 3, "CMPE", new DateTime(2024, 1, 2, 14, 11, 3, 251, DateTimeKind.Local).AddTicks(7522), "AÖY", 2 },
                    { 4, "CMPE", new DateTime(2024, 1, 2, 14, 11, 3, 251, DateTimeKind.Local).AddTicks(7523), "TY", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
