using Microsoft.EntityFrameworkCore.Migrations;

namespace EarthlyRemedies.Migrations
{
    public partial class RatingsDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Remedies");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Ratings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Ratings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 1,
                columns: new[] { "Comments", "UserId" },
                values: new object[] { "Almost killed me!", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 2,
                columns: new[] { "Comments", "UserId" },
                values: new object[] { "Not sure it did anything.", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 3,
                columns: new[] { "Comments", "UserId" },
                values: new object[] { "Best ever!!!", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ratings");

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Remedies",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
