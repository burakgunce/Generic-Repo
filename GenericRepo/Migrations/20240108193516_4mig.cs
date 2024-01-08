using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenericRepo.Migrations
{
    public partial class _4mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Schools_SchoolId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentLesson_Lesson_LessonId",
                table: "StudentLesson");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentLesson_Students_StudentId",
                table: "StudentLesson");

            migrationBuilder.DropTable(
                name: "LessonStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson");

            migrationBuilder.RenameTable(
                name: "Lesson",
                newName: "Lessons");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_SchoolId",
                table: "Lessons",
                newName: "IX_Lessons_SchoolId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreationDate", "Credit", "Name", "SchoolId" },
                values: new object[] { 1, new DateTime(2024, 1, 8, 22, 35, 16, 271, DateTimeKind.Local).AddTicks(2454), 0, "Mat", 1 });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 22, 35, 16, 271, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 22, 35, 16, 271, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 22, 35, 16, 271, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 22, 35, 16, 271, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 22, 35, 16, 271, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 22, 35, 16, 271, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.InsertData(
                table: "StudentLesson",
                columns: new[] { "LessonId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Schools_SchoolId",
                table: "Lessons",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLesson_Lessons_LessonId",
                table: "StudentLesson",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLesson_Students_StudentId",
                table: "StudentLesson",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Schools_SchoolId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentLesson_Lessons_LessonId",
                table: "StudentLesson");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentLesson_Students_StudentId",
                table: "StudentLesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons");

            migrationBuilder.DeleteData(
                table: "StudentLesson",
                keyColumns: new[] { "LessonId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentLesson",
                keyColumns: new[] { "LessonId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentLesson",
                keyColumns: new[] { "LessonId", "StudentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StudentLesson",
                keyColumns: new[] { "LessonId", "StudentId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Lessons",
                newName: "Lesson");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_SchoolId",
                table: "Lesson",
                newName: "IX_Lesson_SchoolId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Schools",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LessonStudent",
                columns: table => new
                {
                    LessonsId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonStudent", x => new { x.LessonsId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_LessonStudent_Lesson_LessonsId",
                        column: x => x.LessonsId,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 2, 20, 21, 179, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 2, 20, 21, 179, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 2, 20, 21, 179, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 2, 20, 21, 179, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 2, 20, 21, 179, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 1, 8, 2, 20, 21, 179, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.CreateIndex(
                name: "IX_LessonStudent_StudentsId",
                table: "LessonStudent",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Schools_SchoolId",
                table: "Lesson",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLesson_Lesson_LessonId",
                table: "StudentLesson",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentLesson_Students_StudentId",
                table: "StudentLesson",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
