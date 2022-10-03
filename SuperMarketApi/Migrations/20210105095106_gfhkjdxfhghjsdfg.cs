using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class gfhkjdxfhghjsdfg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Stocks_Products_ProductId",
            //    table: "Stocks");

            //migrationBuilder.RenameColumn(
            //    name: "ProductId",
            //    table: "Stocks",
            //    newName: "BarcodeId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Stocks_ProductId",
            //    table: "Stocks",
            //    newName: "IX_Stocks_BarcodeId");

            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    BatchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BatchNo = table.Column<string>(maxLength: 50, nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    BarcodeId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchId);
                    table.ForeignKey(
                        name: "FK_Batches_Barcodes_BarcodeId",
                        column: x => x.BarcodeId,
                        principalTable: "Barcodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Batches_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Batches_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batches_BarcodeId",
                table: "Batches",
                column: "BarcodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Batches_CompanyId",
                table: "Batches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Batches_StoreId",
                table: "Batches",
                column: "StoreId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Stocks_Barcodes_BarcodeId",
            //    table: "Stocks",
            //    column: "Id",
            //    principalTable: "Barcodes",
            //    principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Stocks_Barcodes_BarcodeId",
            //    table: "Stocks");

            //migrationBuilder.DropTable(
            //    name: "Batches");

            //migrationBuilder.RenameColumn(
            //    name: "Id",
            //    table: "Stocks",
            //    newName: "ProductId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Stocks_BarcodeId",
            //    table: "Stocks",
            //    newName: "IX_Stocks_ProductId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Stocks_Products_ProductId",
            //    table: "Stocks",
            //    column: "ProductId",
            //    principalTable: "Products",
            //    principalColumn: "Id");
        }
    }
}
