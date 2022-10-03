using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masood40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrdProdDetailId",
                table: "OrderItemDetails",
                newName: "OrderItemDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderItemDetailId",
                table: "OrderItemDetails",
                newName: "OrdProdDetailId");
        }
    }
}
