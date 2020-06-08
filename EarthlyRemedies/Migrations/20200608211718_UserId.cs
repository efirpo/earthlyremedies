using Microsoft.EntityFrameworkCore.Migrations;

namespace EarthlyRemedies.Migrations
{
    public partial class UserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Remedies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 3,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 4,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 5,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 6,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 7,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 8,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 9,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 10,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 11,
                column: "UserId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Remedies");
        }
    }
}
