using Microsoft.EntityFrameworkCore.Migrations;

namespace EarthlyRemedies.Migrations
{
    public partial class CategoryProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Remedies",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Remedies",
                columns: new[] { "RemedyId", "Ailment", "Category", "Details", "Name" },
                values: new object[,]
                {
                    { 10, "chest congestion", "respiratory", "L-Acetyl Cysteine, taken daily, will shorten duration of respiratory ailments.", "Mucus Melter" },
                    { 11, "dandruff", "skin", "Castor oil rubbed into the scalp, every night before bed, for one week.", "Dandruff Buster" },
                    { 3, "dry eyes", "eyes", "Mega doses of Omega 3s for LIFE!!!!", "Dry Eye Relief" },
                    { 4, "foot fungus", "skin", "Soak the affected area in apple cider vinegar twice a day until cured", "Fungus Foiler" },
                    { 5, "digestive illness", "GI", "One shot of vodka, followed by one shot of fresh ginger juice, daily until symptoms resolve.", "Polish Tummy Cure" },
                    { 6, "sunburn", "skin", "apply earl grey tea to the affected area 5 times a day until burn goes away", "Sunburn salve" },
                    { 7, "heartburn", "GI", "Heat 4 oz water to body temperature.  Add 1 oz fresh lemon juice. Drink slowly.", "Heartburn Helper" },
                    { 8, "cough", "respiratory", "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on throat, chest and upper back before sleep.", "Nighttime Salve" },
                    { 9, "eye obstruction", "eyes", "If something is in your eye, pull your upper eyelid over your lower one, in an attempt to scrape out the obstruction", "Eye obsruction removal" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Remedies");
        }
    }
}
