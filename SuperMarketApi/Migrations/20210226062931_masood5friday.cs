using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masood5friday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "OrdItemAddons");

            migrationBuilder.DropTable(
                name: "OrdItemVariants");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "KOT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Instruction = table.Column<string>(nullable: true),
                    KOTGroupId = table.Column<int>(nullable: true),
                    KOTNo = table.Column<string>(nullable: true),
                    KOTStatusId = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: true),
                    Updated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KOT_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KOT_KOTGroups_KOTGroupId",
                        column: x => x.KOTGroupId,
                        principalTable: "KOTGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KOT_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KOT_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: true),
                    ComplementryQty = table.Column<float>(nullable: true),
                    DiscAmount = table.Column<double>(nullable: false),
                    DiscPercent = table.Column<double>(nullable: false),
                    Extra = table.Column<double>(nullable: true),
                    ItemDiscount = table.Column<double>(nullable: true),
                    KOTId = table.Column<int>(nullable: true),
                    KitchenUserId = table.Column<int>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OptionJson = table.Column<string>(nullable: true),
                    OrderDiscount = table.Column<double>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Tax1 = table.Column<double>(nullable: false),
                    Tax2 = table.Column<double>(nullable: false),
                    Tax3 = table.Column<double>(nullable: false),
                    TaxItemDiscount = table.Column<double>(nullable: true),
                    TaxOrderDiscount = table.Column<double>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: true),
                    Updated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_KOT_KOTId",
                        column: x => x.KOTId,
                        principalTable: "KOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Users_KitchenUserId",
                        column: x => x.KitchenUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdItemAddons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddonId = table.Column<int>(nullable: false),
                    OrderItemId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    StatusId = table.Column<int>(nullable: true),
                    Updated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdItemAddons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdItemAddons_Addons_AddonId",
                        column: x => x.AddonId,
                        principalTable: "Addons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdItemAddons_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdItemAddons_DropDowns_StatusId",
                        column: x => x.StatusId,
                        principalTable: "DropDowns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdItemVariants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderItemId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Updated = table.Column<bool>(nullable: false),
                    VariantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdItemVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdItemVariants_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdItemVariants_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KOT_CompanyId",
                table: "KOT",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_KOT_KOTGroupId",
                table: "KOT",
                column: "KOTGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_KOT_OrderId",
                table: "KOT",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_KOT_StoreId",
                table: "KOT",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_CategoryId",
                table: "OrderItem",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_KOTId",
                table: "OrderItem",
                column: "KOTId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_KitchenUserId",
                table: "OrderItem",
                column: "KitchenUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemAddons_AddonId",
                table: "OrdItemAddons",
                column: "AddonId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemAddons_OrderItemId",
                table: "OrdItemAddons",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemAddons_StatusId",
                table: "OrdItemAddons",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemVariants_OrderItemId",
                table: "OrdItemVariants",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemVariants_VariantId",
                table: "OrdItemVariants",
                column: "VariantId");
        }
    }
}
