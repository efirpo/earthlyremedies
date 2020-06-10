using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EarthlyRemedies.Migrations
{
    public partial class AddJoinCategoryRemedy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Remedies");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryRemedy",
                columns: table => new
                {
                    CategoryRemedyId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    RemedyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryRemedy", x => x.CategoryRemedyId);
                    table.ForeignKey(
                        name: "FK_CategoryRemedy_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryRemedy_Remedies_RemedyId",
                        column: x => x.RemedyId,
                        principalTable: "Remedies",
                        principalColumn: "RemedyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "GI" },
                    { 13, "Nerve" },
                    { 12, "Digestive" },
                    { 11, "Cardiovascular" },
                    { 10, "Lymphatic" },
                    { 9, "Pineal" },
                    { 8, "Chakra" },
                    { 14, "Reproductive" },
                    { 6, "Musculoskeletal" },
                    { 5, "Hair" },
                    { 4, "Eyes" },
                    { 3, "Skin" },
                    { 2, "Respiratory" },
                    { 7, "Endocrine" }
                });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 1,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 3,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 2,
                columns: new[] { "Ailment", "Details", "Ingredients", "Name" },
                values: new object[] { "dandruff", "Castor oil rubbed into the scalp, every night before bed, for one week.", "castor oil", "Dandruff Buster" });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 3,
                columns: new[] { "Ailment", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "muscle soreness", "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on sore muscles before sleep.", "tea tree oil, peppermint, eucalyptus", "Sore Muscle Balm", 2 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 4,
                columns: new[] { "Ailment", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "dry eyes", "Mega doses of Omega 3s for LIFE!!!!", "Omega 3", "Dry Eye Relief", 1 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 5,
                columns: new[] { "Ailment", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "foot fungus", "Soak the affected area in apple cider vinegar twice a day until cured", "apple cider vinegar", "Fungus Foiler", 2 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 6,
                columns: new[] { "Ailment", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "digestive illness", "One shot of vodka, followed by one shot of fresh ginger juice, daily until symptoms resolve.", "ginger, vodka", "Polish Tummy Cure", 1 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 7,
                columns: new[] { "Ailment", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "sunburn", "apply earl grey tea to the affected area 5 times a day until burn goes away", "tea", "Sunburn salve", 2 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 8,
                columns: new[] { "Ailment", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "heartburn", "Heat 4 oz water to body temperature.  Add 1 oz fresh lemon juice. Drink slowly.", "lemon", "Heartburn Helper", 1 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 9,
                columns: new[] { "Ailment", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "cough", "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on throat, chest and upper back before sleep.", "tea tree oil, peppermint, eucalyptus", "Nighttime Salve", 2 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 10,
                columns: new[] { "Ailment", "Details", "Ingredients", "Name" },
                values: new object[] { "eye obstruction", "If something is in your eye, pull your upper eyelid over your lower one, in an attempt to scrape out the obstruction", "", "Eye obsruction removal" });

            migrationBuilder.InsertData(
                table: "Remedies",
                columns: new[] { "RemedyId", "Ailment", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { 1, "chest congestion", "L-Acetyl Cysteine, taken daily, will shorten duration of respiratory ailments.", "L-Acetyl Cysteine", "Mucus Melter", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Password", "Username" },
                values: new object[] { "Ethan", "Firpo", "epicodusRocks", "efirpo" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "Password", "Username" },
                values: new object[] { "Tyler", "Bates", "x", "tyty" });

            migrationBuilder.InsertData(
                table: "CategoryRemedy",
                columns: new[] { "CategoryRemedyId", "CategoryId", "RemedyId" },
                values: new object[,]
                {
                    { 9, 2, 9 },
                    { 5, 3, 5 },
                    { 7, 3, 7 },
                    { 4, 4, 4 },
                    { 10, 4, 10 },
                    { 2, 5, 2 },
                    { 3, 6, 3 },
                    { 6, 12, 6 },
                    { 8, 12, 8 },
                    { 1, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryRemedy_CategoryId",
                table: "CategoryRemedy",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryRemedy_RemedyId",
                table: "CategoryRemedy",
                column: "RemedyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryRemedy");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Remedies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 1,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 3,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 2,
                columns: new[] { "Ailment", "Category", "Details", "Ingredients", "Name" },
                values: new object[] { "muscle soreness", "musculoskeletal", "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on sore muscles before sleep.", "tea tree oil, peppermint, eucalyptus", "Sore Muscle Balm" });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 3,
                columns: new[] { "Ailment", "Category", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "dry eyes", "eyes", "Mega doses of Omega 3s for LIFE!!!!", "Omega 3", "Dry Eye Relief", 1 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 4,
                columns: new[] { "Ailment", "Category", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "foot fungus", "skin", "Soak the affected area in apple cider vinegar twice a day until cured", "apple cider vinegar", "Fungus Foiler", 2 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 5,
                columns: new[] { "Ailment", "Category", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "digestive illness", "GI", "One shot of vodka, followed by one shot of fresh ginger juice, daily until symptoms resolve.", "ginger, vodka", "Polish Tummy Cure", 1 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 6,
                columns: new[] { "Ailment", "Category", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "sunburn", "skin", "apply earl grey tea to the affected area 5 times a day until burn goes away", "tea", "Sunburn salve", 2 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 7,
                columns: new[] { "Ailment", "Category", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "heartburn", "GI", "Heat 4 oz water to body temperature.  Add 1 oz fresh lemon juice. Drink slowly.", "lemon", "Heartburn Helper", 1 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 8,
                columns: new[] { "Ailment", "Category", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "cough", "respiratory", "Mix 2 drops eucalyptus oil, 1 drop peppermint oil, and 1 drop tea tree oil into 1 oz neutral oil or balm.  Rub on throat, chest and upper back before sleep.", "tea tree oil, peppermint, eucalyptus", "Nighttime Salve", 2 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 9,
                columns: new[] { "Ailment", "Category", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { "eye obstruction", "eyes", "If something is in your eye, pull your upper eyelid over your lower one, in an attempt to scrape out the obstruction", "", "Eye obsruction removal", 1 });

            migrationBuilder.UpdateData(
                table: "Remedies",
                keyColumn: "RemedyId",
                keyValue: 10,
                columns: new[] { "Ailment", "Category", "Details", "Ingredients", "Name" },
                values: new object[] { "chest congestion", "respiratory", "L-Acetyl Cysteine, taken daily, will shorten duration of respiratory ailments.", "L-Acetyl Cysteine", "Mucus Melter" });

            migrationBuilder.InsertData(
                table: "Remedies",
                columns: new[] { "RemedyId", "Ailment", "Category", "Details", "Ingredients", "Name", "UserId" },
                values: new object[] { 11, "dandruff", "skin", "Castor oil rubbed into the scalp, every night before bed, for one week.", "castor oil", "Dandruff Buster", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "Password", "Username" },
                values: new object[] { "Julia", "Test", "test", "JuliaTest" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "Password", "Username" },
                values: new object[] { "Jason", "Test", "test", "JasonTest" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "Token", "Username" },
                values: new object[] { 3, "DJ", "Test", "test", null, "DJTest" });
        }
    }
}
