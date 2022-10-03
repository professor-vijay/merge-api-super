using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class qwerty1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryVariantGroupId",
                table: "Variants",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Variants_CategoryVariantGroupId",
                table: "Variants",
                column: "CategoryVariantGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_CategoryVariantGroups_CategoryVariantGroupId",
                table: "Variants",
                column: "CategoryVariantGroupId",
                principalTable: "CategoryVariantGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variants_CategoryVariantGroups_CategoryVariantGroupId",
                table: "Variants");

            migrationBuilder.DropIndex(
                name: "IX_Variants_CategoryVariantGroupId",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "CategoryVariantGroupId",
                table: "Variants");
        }
    }
}
