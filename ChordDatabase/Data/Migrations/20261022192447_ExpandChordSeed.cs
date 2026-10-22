using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChordDatabase.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExpandChordSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 1,
                column: "Feeling",
                value: "Floating, unresolved");

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 2,
                column: "Feeling",
                value: "Bright, stable");

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 3,
                column: "Feeling",
                value: "Sad, serious");

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 4,
                column: "Feeling",
                value: "Warm, resolved");

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 5,
                column: "Feeling",
                value: "Dreamy, bright");

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Feeling", "Functions", "Scale" },
                values: new object[] { "Smooth, mellow", "Subdominant, tonic", "Dorian" });

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 7,
                column: "Feeling",
                value: "Mysterious, cinematic");

            migrationBuilder.InsertData(
                table: "Chord",
                columns: new[] { "Id", "Alterations", "Extension", "Feeling", "Functions", "Inversion", "Quality", "Scale" },
                values: new object[,]
                {
                    { 8, null, null, "Tense, unstable", "Dominant, passing", null, "Diminished", "Locrian" },
                    { 9, null, null, "Dreamy, unresolved", "Tension", null, "Augmented", "Whole Tone" },
                    { 10, "sus4", null, "Open, suspended", "Dominant, tension", null, "Suspended", "Mixolydian" },
                    { 11, null, "add9", "Shimmering, open", "Tonic", null, "Major", "Ionian" },
                    { 12, null, "6", "Warm, vintage", "Tonic", null, "Major", "Ionian" },
                    { 13, null, "6/9", "Lush, resolved", "Tonic", null, "Major", "Ionian" },
                    { 14, null, "6", "Bittersweet, noir", "Tonic, subdominant", null, "Minor", "Dorian" },
                    { 15, null, "6/9", "Smoky, sophisticated", "Tonic, subdominant", null, "Minor", "Dorian" },
                    { 16, null, "9", "Rich, open", "Tonic, subdominant", null, "Major", "Ionian" },
                    { 17, null, "13", "Lush, full", "Tonic", null, "Major", "Ionian" },
                    { 18, "#11", "9", "Dreamy, floating", "Tonic, subdominant, nonfunctional", null, "Major", "Lydian" },
                    { 19, "#11", "13", "Expansive, shimmering", "Tonic, subdominant, nonfunctional", null, "Major", "Lydian" },
                    { 20, null, "9", "Smooth, mellow", "Subdominant, tonic", null, "Minor", "Dorian" },
                    { 21, null, "11", "Spacious, modern", "Subdominant, tonic", null, "Minor", "Dorian" },
                    { 22, null, "9", "Mysterious, elegant", "Tonic, tension", null, "Minor-Major", "Melodic Minor" },
                    { 23, null, "7", "Dark, yearning", "Subdominant", null, "Half-Diminished", "Locrian" },
                    { 24, null, "9", "Dark, softened", "Subdominant", null, "Half-Diminished", "Locrian #2" },
                    { 25, null, "7", "Symmetrical, tense", "Dominant, passing", null, "Diminished", "Diminished (Whole-Half)" },
                    { 26, null, "7", "Bluesy, driving", "Dominant", null, "Dominant", "Mixolydian" },
                    { 27, null, "9", "Funky, full", "Dominant", null, "Dominant", "Mixolydian" },
                    { 28, null, "13", "Lush, bluesy", "Dominant", null, "Dominant", "Mixolydian" },
                    { 29, "sus4", "7", "Open, suspended", "Dominant, tension", null, "Dominant", "Mixolydian" },
                    { 30, "sus4", "9", "Floating, modern", "Dominant, tension", null, "Dominant", "Mixolydian" },
                    { 31, "sus4", "13", "Airy, unresolved", "Dominant, tension", null, "Dominant", "Mixolydian" },
                    { 32, "b9", "7", "Dark, urgent", "Dominant, tension", null, "Dominant", "Diminished (Half-Whole)" },
                    { 33, "b9", "13", "Dark, colorful", "Dominant, tension", null, "Dominant", "Diminished (Half-Whole)" },
                    { 34, "#9", "7", "Gritty, edgy", "Dominant, tension", null, "Dominant", "Altered" },
                    { 35, "#11", "7", "Bright, quirky", "Dominant, tritone substitution", null, "Dominant", "Lydian Dominant" },
                    { 36, "#11", "9", "Bright, floating", "Dominant, tritone substitution", null, "Dominant", "Lydian Dominant" },
                    { 37, "#11", "13", "Bright, expansive", "Dominant, tritone substitution", null, "Dominant", "Lydian Dominant" },
                    { 38, "#5", "7", "Floating, unsettled", "Dominant, tension", null, "Dominant", "Whole Tone" },
                    { 39, "#5", "9", "Dreamy, unsettled", "Dominant, tension", null, "Dominant", "Whole Tone" },
                    { 40, "b13", "7", "Dark, bittersweet", "Dominant", null, "Dominant", "Mixolydian b6" },
                    { 41, "b13", "9", "Dark, rich", "Dominant", null, "Dominant", "Mixolydian b6" },
                    { 42, "b9, b13", "7", "Spanish, dramatic", "Dominant, tension", null, "Dominant", "Phrygian Dominant" },
                    { 43, "alt", "7", "Maximum tension", "Dominant, tension", null, "Dominant", "Altered" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 1,
                column: "Feeling",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 2,
                column: "Feeling",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 3,
                column: "Feeling",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 4,
                column: "Feeling",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 5,
                column: "Feeling",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Feeling", "Functions", "Scale" },
                values: new object[] { null, null, "Aeolian" });

            migrationBuilder.UpdateData(
                table: "Chord",
                keyColumn: "Id",
                keyValue: 7,
                column: "Feeling",
                value: null);
        }
    }
}
