using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class hfdjhfksfkxchvfjhxhkjhgopi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barcodes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barcodes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryVariantGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    VariantGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVariantGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryVariantGroups_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryVariantGroups_VariantGroups_VariantGroupId",
                        column: x => x.VariantGroupId,
                        principalTable: "VariantGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BarcodeVariants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BarcodeId = table.Column<int>(nullable: false),
                    VariantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarcodeVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarcodeVariants_Barcodes_BarcodeId",
                        column: x => x.BarcodeId,
                        principalTable: "Barcodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BarcodeVariants_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barcodes_ProductId",
                table: "Barcodes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeVariants_BarcodeId",
                table: "BarcodeVariants",
                column: "BarcodeId");

            migrationBuilder.CreateIndex(
                name: "IX_BarcodeVariants_VariantId",
                table: "BarcodeVariants",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVariantGroups_CategoryId",
                table: "CategoryVariantGroups",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVariantGroups_VariantGroupId",
                table: "CategoryVariantGroups",
                column: "VariantGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarcodeVariants");

            migrationBuilder.DropTable(
                name: "CategoryVariantGroups");

            migrationBuilder.DropTable(
                name: "Barcodes");
        }
    }
}
