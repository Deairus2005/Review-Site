using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Personal Hygiene", "handSoap.png", "Hand Soap" },
                    { 2, "Personal Hygiene", "deodorant.png", "Deodorant" },
                    { 3, "Health Beauty", "shampoo.png", "Shampoo" },
                    { 4, "Health Beauty", "facialCleanser.png", "Facial Cleanser" },
                    { 5, "Personal Hygiene", "cottonSwabs.png", "Cotton Swabs" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Name", "ProductId", "Rating", "ReviewContent" },
                values: new object[,]
                {
                    { 1, "Hand Soap", 1, 3, "Gentle on the hands and smells pretty!" },
                    { 2, "Deodorant", 2, 3, "Left me stanky and moist!  Terrible." },
                    { 3, "Shampoo", 3, 3, "Gentle on the hands and smells pretty!" },
                    { 4, "Facial Cleanser", 4, 3, "Left me stanky and moist!  Terrible." },
                    { 5, "Cotton Swabs", 5, 3, "Gentle on the hands and smells pretty!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
