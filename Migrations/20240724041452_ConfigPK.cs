using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace quiz_app.Migrations
{
    /// <inheritdoc />
    public partial class ConfigPK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Questions",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "QuizAttempts",
                keyColumn: "QuizAttemptId",
                keyValue: 1,
                column: "AttemptDate",
                value: new DateTime(2024, 7, 24, 14, 14, 50, 726, DateTimeKind.Local).AddTicks(5372));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "QuizAttempts",
                keyColumn: "QuizAttemptId",
                keyValue: 1,
                column: "AttemptDate",
                value: new DateTime(2024, 7, 23, 17, 3, 52, 640, DateTimeKind.Local).AddTicks(8089));
        }
    }
}
