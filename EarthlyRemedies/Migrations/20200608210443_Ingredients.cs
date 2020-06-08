using Microsoft.EntityFrameworkCore.Migrations;

namespace EarthlyRemedies.Migrations
{
    public partial class Ingredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Remedies",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Remedies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Remedies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ailment",
                table: "Remedies",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Remedies",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 3,
                column: "Ingredients",
                value: "Omega 3");

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 4,
                column: "Ingredients",
                value: "apple cider vinegar");

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 5,
                column: "Ingredients",
                value: "ginger, vodka");

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 6,
                column: "Ingredients",
                value: "tea");

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 7,
                column: "Ingredients",
                value: "lemon");

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 8,
                column: "Ingredients",
                value: "tea tree oil, peppermint, eucalyptus");

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 9,
                column: "Ingredients",
                value: "");

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 10,
                column: "Ingredients",
                value: "L-Acetyl Cysteine");

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 11,
                column: "Ingredients",
                value: "castor oil");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Remedies");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Remedies",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Remedies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Remedies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Ailment",
                table: "Remedies",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
