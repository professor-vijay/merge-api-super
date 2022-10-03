using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class tuesday4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "VariantGroups",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "VariantGroups",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "VariantGroups");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "VariantGroups");
        }
    }
}
