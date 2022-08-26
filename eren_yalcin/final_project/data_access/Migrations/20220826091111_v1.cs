using Microsoft.EntityFrameworkCore.Migrations;

namespace data_access.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    Tag_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tag_name = table.Column<int>(type: "int", nullable: false),
                    Product_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.Tag_id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Create_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CategoriesCategory_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Product_id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoriesCategory_id",
                        column: x => x.CategoriesCategory_id,
                        principalTable: "categories",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tags_products",
                columns: table => new
                {
                    Tag_product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagsTag_id = table.Column<int>(type: "int", nullable: true),
                    Tag_id = table.Column<int>(type: "int", nullable: false),
                    Product_id1 = table.Column<int>(type: "int", nullable: true),
                    Product_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags_products", x => x.Tag_product_id);
                    table.ForeignKey(
                        name: "FK_tags_products_products_Product_id1",
                        column: x => x.Product_id1,
                        principalTable: "products",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tags_products_tags_TagsTag_id",
                        column: x => x.TagsTag_id,
                        principalTable: "tags",
                        principalColumn: "Tag_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoriesCategory_id",
                table: "products",
                column: "CategoriesCategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_tags_products_Product_id1",
                table: "tags_products",
                column: "Product_id1");

            migrationBuilder.CreateIndex(
                name: "IX_tags_products_TagsTag_id",
                table: "tags_products",
                column: "TagsTag_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tags_products");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
