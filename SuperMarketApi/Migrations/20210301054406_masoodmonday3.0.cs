using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masoodmonday30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BarcodeId",
                table: "OrderItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_BarcodeId",
                table: "OrderItems",
                column: "BarcodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Barcodes_BarcodeId",
                table: "OrderItems",
                column: "BarcodeId",
                principalTable: "Barcodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Barcodes_BarcodeId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_BarcodeId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "BarcodeId",
                table: "OrderItems");
        }
    }
}
