using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EarthlyRemedies.Migrations
{
    public partial class Ratings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Remedies",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Stars = table.Column<int>(nullable: false),
                    RemedyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "RemedyId", "Stars" },
                values: new object[,]
                {
                    { 1, 2, 5 },
                    { 2, 2, 3 },
                    { 3, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Remedies",
                columns: new[] { "RemedyId", "Ailment", "Category", "Details", "Ingredients", "Name", "Rating", "UserId" },
                values: new object[] { 2, "muscle soreness", "musculoskeletal", "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on sore muscles before sleep.", "tea tree oil, peppermint, eucalyptus", "Sore Muscle Balm", 0m, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Remedies");
        }
    }
}
