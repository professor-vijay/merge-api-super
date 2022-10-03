using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class wednesday002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BarcodeVariantId",
                table: "Batches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Batches_BarcodeVariantId",
                table: "Batches",
                column: "BarcodeVariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_BarcodeVariants_BarcodeVariantId",
                table: "Batches",
                column: "BarcodeVariantId",
                principalTable: "BarcodeVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batches_BarcodeVariants_BarcodeVariantId",
                table: "Batches");

            migrationBuilder.DropIndex(
                name: "IX_Batches_BarcodeVariantId",
                table: "Batches");

            migrationBuilder.DropColumn(
                name: "BarcodeVariantId",
                table: "Batches");
        }
    }
}
