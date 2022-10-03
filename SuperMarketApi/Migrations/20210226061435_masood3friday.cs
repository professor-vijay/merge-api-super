using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masood3friday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Order_OrderId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_KOTs_Companies_CompanyId",
                table: "KOTs");

            migrationBuilder.DropForeignKey(
                name: "FK_KOTs_KOTGroups_KOTGroupId",
                table: "KOTs");

            migrationBuilder.DropForeignKey(
                name: "FK_KOTs_Order_OrderId",
                table: "KOTs");

            migrationBuilder.DropForeignKey(
                name: "FK_KOTs_Stores_StoreId",
                table: "KOTs");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_KOTs_KOTId",
                table: "OrderItem");

            migrationBuilder.DropTable(
                name: "OrdItemOptions");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KOTs",
                table: "KOTs");

            migrationBuilder.RenameTable(
                name: "KOTs",
                newName: "KOT");

            migrationBuilder.RenameIndex(
                name: "IX_KOTs_StoreId",
                table: "KOT",
                newName: "IX_KOT_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_KOTs_OrderId",
                table: "KOT",
                newName: "IX_KOT_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_KOTs_KOTGroupId",
                table: "KOT",
                newName: "IX_KOT_KOTGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_KOTs_CompanyId",
                table: "KOT",
                newName: "IX_KOT_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KOT",
                table: "KOT",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KOT_Companies_CompanyId",
                table: "KOT",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KOT_KOTGroups_KOTGroupId",
                table: "KOT",
                column: "KOTGroupId",
                principalTable: "KOTGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KOT_Order_OrderId",
                table: "KOT",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KOT_Stores_StoreId",
                table: "KOT",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_KOT_KOTId",
                table: "OrderItem",
                column: "KOTId",
                principalTable: "KOT",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KOT_Companies_CompanyId",
                table: "KOT");

            migrationBuilder.DropForeignKey(
                name: "FK_KOT_KOTGroups_KOTGroupId",
                table: "KOT");

            migrationBuilder.DropForeignKey(
                name: "FK_KOT_Order_OrderId",
                table: "KOT");

            migrationBuilder.DropForeignKey(
                name: "FK_KOT_Stores_StoreId",
                table: "KOT");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_KOT_KOTId",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KOT",
                table: "KOT");

            migrationBuilder.RenameTable(
                name: "KOT",
                newName: "KOTs");

            migrationBuilder.RenameIndex(
                name: "IX_KOT_StoreId",
                table: "KOTs",
                newName: "IX_KOTs_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_KOT_OrderId",
                table: "KOTs",
                newName: "IX_KOTs_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_KOT_KOTGroupId",
                table: "KOTs",
                newName: "IX_KOTs_KOTGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_KOT_CompanyId",
                table: "KOTs",
                newName: "IX_KOTs_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KOTs",
                table: "KOTs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrdItemOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OptionId = table.Column<int>(nullable: false),
                    OrderItemId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Updated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdItemOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdItemOptions_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdItemOptions_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemOptions_OptionId",
                table: "OrdItemOptions",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemOptions_OrderItemId",
                table: "OrdItemOptions",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Order_OrderId",
                table: "Deliveries",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KOTs_Companies_CompanyId",
                table: "KOTs",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KOTs_KOTGroups_KOTGroupId",
                table: "KOTs",
                column: "KOTGroupId",
                principalTable: "KOTGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KOTs_Order_OrderId",
                table: "KOTs",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KOTs_Stores_StoreId",
                table: "KOTs",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_KOTs_KOTId",
                table: "OrderItem",
                column: "KOTId",
                principalTable: "KOTs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
