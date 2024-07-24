using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace quiz_app.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "QuizAttemptId", "Text" },
                values: new object[,]
                {
                    { 4, null, "What is the smallest country in the world?" },
                    { 5, null, "What is the chemical symbol for water?" },
                    { 6, null, "What year did the Titanic sink?" },
                    { 7, null, "What is the hardest natural substance on Earth?" },
                    { 8, null, "What is the longest river in the world?" },
                    { 9, null, "Who painted the Mona Lisa?" },
                    { 10, null, "What is the tallest mountain in the world?" },
                    { 11, null, "Who discovered penicillin?" },
                    { 12, null, "What is the capital of Japan?" },
                    { 13, null, "What is the main ingredient in guacamole?" },
                    { 14, null, "What is the square root of 64?" },
                    { 15, null, "Who is the author of 'Harry Potter' series?" },
                    { 16, null, "What is the capital of Canada?" },
                    { 17, null, "What is the largest ocean on Earth?" },
                    { 18, null, "What is the freezing point of water?" },
                    { 19, null, "What is the largest mammal in the world?" },
                    { 20, null, "What is the capital of Australia?" }
                });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 4,
                columns: new[] { "IsCorrect", "QuestionId", "Text" },
                values: new object[] { true, 2, "Jupiter" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 5,
                columns: new[] { "IsCorrect", "Text" },
                values: new object[] { false, "Saturn" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 6,
                column: "Text",
                value: "Mars");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 7,
                columns: new[] { "IsCorrect", "QuestionId", "Text" },
                values: new object[] { true, 3, "Harper Lee" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 8,
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 3, "Jane Austen" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 9,
                columns: new[] { "IsCorrect", "Text" },
                values: new object[] { false, "Mark Twain" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 10,
                columns: new[] { "IsCorrect", "QuestionId", "Text" },
                values: new object[] { true, 4, "Vatican City" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 11,
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 4, "Monaco" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 12,
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 4, "San Marino" });

            migrationBuilder.UpdateData(
                table: "QuizAttempts",
                keyColumn: "QuizAttemptId",
                keyValue: 1,
                column: "AttemptDate",
                value: new DateTime(2024, 7, 23, 17, 3, 52, 640, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 13, true, 5, "H2O" },
                    { 14, false, 5, "O2" },
                    { 15, false, 5, "CO2" },
                    { 16, true, 6, "1912" },
                    { 17, false, 6, "1905" },
                    { 18, false, 6, "1898" },
                    { 19, true, 7, "Diamond" },
                    { 20, false, 7, "Gold" },
                    { 21, false, 7, "Iron" },
                    { 22, true, 8, "Nile" },
                    { 23, false, 8, "Amazon" },
                    { 24, false, 8, "Yangtze" },
                    { 25, true, 9, "Leonardo da Vinci" },
                    { 26, false, 9, "Vincent van Gogh" },
                    { 27, false, 9, "Pablo Picasso" },
                    { 28, true, 10, "Mount Everest" },
                    { 29, false, 10, "K2" },
                    { 30, false, 10, "Kangchenjunga" },
                    { 31, true, 11, "Alexander Fleming" },
                    { 32, false, 11, "Louis Pasteur" },
                    { 33, false, 11, "Marie Curie" },
                    { 34, true, 12, "Tokyo" },
                    { 35, false, 12, "Osaka" },
                    { 36, false, 12, "Kyoto" },
                    { 37, true, 13, "Avocado" },
                    { 38, false, 13, "Tomato" },
                    { 39, false, 13, "Pepper" },
                    { 40, true, 14, "8" },
                    { 41, false, 14, "6" },
                    { 42, false, 14, "10" },
                    { 43, true, 15, "J.K. Rowling" },
                    { 44, false, 15, "J.R.R. Tolkien" },
                    { 45, false, 15, "George R.R. Martin" },
                    { 46, true, 16, "Ottawa" },
                    { 47, false, 16, "Toronto" },
                    { 48, false, 16, "Vancouver" },
                    { 49, true, 17, "Pacific Ocean" },
                    { 50, false, 17, "Atlantic Ocean" },
                    { 51, false, 17, "Indian Ocean" },
                    { 52, true, 18, "0°C" },
                    { 53, false, 18, "32°C" },
                    { 54, false, 18, "-1°C" },
                    { 55, true, 19, "Blue Whale" },
                    { 56, false, 19, "Elephant" },
                    { 57, false, 19, "Giraffe" },
                    { 58, true, 20, "Canberra" },
                    { 59, false, 20, "Sydney" },
                    { 60, false, 20, "Melbourne" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 4,
                columns: new[] { "IsCorrect", "QuestionId", "Text" },
                values: new object[] { false, 1, "Madrid" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 5,
                columns: new[] { "IsCorrect", "Text" },
                values: new object[] { true, "Jupiter" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 6,
                column: "Text",
                value: "Saturn");

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 7,
                columns: new[] { "IsCorrect", "QuestionId", "Text" },
                values: new object[] { false, 2, "Mars" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 8,
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 2, "Earth" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 9,
                columns: new[] { "IsCorrect", "Text" },
                values: new object[] { true, "Harper Lee" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 10,
                columns: new[] { "IsCorrect", "QuestionId", "Text" },
                values: new object[] { false, 3, "Jane Austen" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 11,
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 3, "Mark Twain" });

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "AnswerId",
                keyValue: 12,
                columns: new[] { "QuestionId", "Text" },
                values: new object[] { 3, "Ernest Hemingway" });

            migrationBuilder.UpdateData(
                table: "QuizAttempts",
                keyColumn: "QuizAttemptId",
                keyValue: 1,
                column: "AttemptDate",
                value: new DateTime(2024, 7, 23, 15, 54, 7, 216, DateTimeKind.Local).AddTicks(813));
        }
    }
}
