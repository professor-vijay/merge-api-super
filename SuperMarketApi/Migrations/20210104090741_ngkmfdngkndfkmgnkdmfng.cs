using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class ngkmfdngkndfkmgnkdmfng : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Products_Variants_VarientId",
            //    table: "Products");

            //migrationBuilder.DropIndex(
            //    name: "IX_Products_VarientId",
            //    table: "Products");

            //migrationBuilder.DropColumn(
            //    name: "VarientId",
            //    table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "VarientId",
            //    table: "Products",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Products_VarientId",
            //    table: "Products",
            //    column: "VarientId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Products_Variants_VarientId",
            //    table: "Products",
            //    column: "VarientId",
            //    principalTable: "Variants",
            //    principalColumn: "Id");
        }
    }
}
