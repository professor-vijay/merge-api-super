using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class tuesday001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "StockBatches");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Stocks");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiaryDate",
                table: "Batches",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Batches",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiaryDate",
                table: "Batches");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Batches");

            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "Stocks",
                nullable: false,
                defaultValue: 0.0);

            //migrationBuilder.CreateTable(
            //    name: "StockBatches",
            //    columns: table => new
            //    {
            //        StockBatchId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CompanyId = table.Column<int>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: true),
            //        CreatedDate = table.Column<DateTime>(nullable: true),
            //        ExpiaryDate = table.Column<DateTime>(nullable: true),
            //        Price = table.Column<double>(nullable: false),
            //        StockId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_StockBatches", x => x.StockBatchId);
            //        table.ForeignKey(
            //            name: "FK_StockBatches_Companies_CompanyId",
            //            column: x => x.CompanyId,
            //            principalTable: "Companies",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_StockBatches_Users_CreatedBy",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_StockBatches_Stocks_StockId",
            //            column: x => x.StockId,
            //            principalTable: "Stocks",
            //            principalColumn: "StockId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_StockBatches_CompanyId",
            //    table: "StockBatches",
            //    column: "CompanyId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StockBatches_CreatedBy",
            //    table: "StockBatches",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StockBatches_StockId",
            //    table: "StockBatches",
            //    column: "StockId");
        }
    }
}
