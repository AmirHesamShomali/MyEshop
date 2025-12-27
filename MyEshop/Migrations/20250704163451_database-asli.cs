using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyEshop.Migrations
{
    /// <inheritdoc />
    public partial class databaseasli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorycs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorycs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quentitystock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productcs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productcs_items_itemid",
                        column: x => x.itemid,
                        principalTable: "items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "categoritoproducts",
                columns: table => new
                {
                    categoriid = table.Column<int>(type: "int", nullable: false),
                    productid = table.Column<int>(type: "int", nullable: false),
                    categorycsId = table.Column<int>(type: "int", nullable: false),
                    productcsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoritoproducts", x => new { x.productid, x.categoriid });
                    table.ForeignKey(
                        name: "FK_categoritoproducts_categorycs_categorycsId",
                        column: x => x.categorycsId,
                        principalTable: "categorycs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_categoritoproducts_productcs_productcsId",
                        column: x => x.productcsId,
                        principalTable: "productcs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categorycs",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "سبزیجات", "سبزیحات" },
                    { 2, " میوه جات", "میوه جات" },
                    { 3, "لبنیات", "لبنیات" }
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "Id", "Quentitystock", "price" },
                values: new object[,]
                {
                    { 1, 5, 854.0m },
                    { 2, 8, 3302.0m },
                    { 3, 3, 2500m },
                    { 4, 35, 140000m },
                    { 5, 32, 250000m },
                    { 6, 64, 68000m },
                    { 7, 40, 48000m },
                    { 8, 30, 64000m }
                });

            migrationBuilder.InsertData(
                table: "productcs",
                columns: new[] { "Id", "Description", "Name", "itemid" },
                values: new object[,]
                {
                    { 1, "فلفل دلمه ای نیز فلفل شیرین و یا کپسایسیم هستند و در رنگ های مختلف مثل زرد، قرمز، سبز، بنفش و نارنجی موجود هستند. این سبزیجات ، بیش از 900 سال پیش در جنوب و آمریکای مرکزی پرورش داده شدند و نام فلفل را از استعمارگران اروپایی آمریکای شمالی دریافت کردند.\r\n\r\n", "فلفل دلمه ای", 1 },
                    { 2, " توت فرنگی دارای مقدار قابل توجهی آنتی اکسیدان است و حتی دارای مزایای قلبی عروقی می باشد. لوبیا سبز ،منبع غنی از چربی های امگا 3 است. کاروتنوئید و فلاونوئید موجود در لوبیا سبز ،دارای مزایای ضد التهابی هستند.", "توت فرنگی", 2 },
                    { 3, "لوبیا سبز، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند.", " لوبیا سبز", 3 },
                    { 4, "کلم بنفش، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند.", " کلم بنفش ", 4 },
                    { 5, "گوجه فرنگی، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند.", " گوجه  فرنگی", 5 },
                    { 6, "کلم بروکلی، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند.", " کلم بروکلی", 6 },
                    { 7, " هویج، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند.", " هویج", 7 },
                    { 8, "ابمیوه های طبیعی، سرشار از ویتامین C است. این ویتامین هم نوع دیگری از آنتی‌اکسیدان‌ها است. به همین دلیل مصرف کلم می‌تواند نیاز بدن به این ویتامین مهم را تأمین کند.", " ابمیوه های طبیعی", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_categoritoproducts_categorycsId",
                table: "categoritoproducts",
                column: "categorycsId");

            migrationBuilder.CreateIndex(
                name: "IX_categoritoproducts_productcsId",
                table: "categoritoproducts",
                column: "productcsId");

            migrationBuilder.CreateIndex(
                name: "IX_productcs_itemid",
                table: "productcs",
                column: "itemid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categoritoproducts");

            migrationBuilder.DropTable(
                name: "categorycs");

            migrationBuilder.DropTable(
                name: "productcs");

            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
