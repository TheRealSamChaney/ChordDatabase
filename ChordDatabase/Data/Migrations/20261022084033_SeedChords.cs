using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChordDatabase.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedChords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Chord",
                columns: new[] { "Id", "Alterations", "Extension", "Feeling", "Functions", "Inversion", "Quality", "Scale" },
                values: new object[,]
                {
                    { 1, "#5", "7", null, "Tension", "Root", "Major", "Lydian #5" },
                    { 2, null, null, null, "Tonic, subdominant, dominant", null, "Major", "Ionian" },
                    { 3, null, null, null, "Tonic", null, "Minor", "Aeolian" },
                    { 4, null, "7", null, "Tonic", null, "Major", "Ionian" },
                    { 5, "#11", "7", null, "Tonic, subdominant, nonfunctional", null, "Major", "Lydian" },
                    { 6, null, "7", null, null, null, "Minor", "Aeolian" },
                    { 7, null, "7", null, "Tonic, tension", null, "Minor-Major", "Melodic Minor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
