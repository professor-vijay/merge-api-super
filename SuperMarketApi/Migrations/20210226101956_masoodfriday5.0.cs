using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masoodfriday50 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoOrder",
                columns: table => new
                {
                    AutoOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SupplierId = table.Column<int>(nullable: true),
                    OrderStoreId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    IsIgnorePendOrd = table.Column<bool>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoOrder", x => x.AutoOrderId);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Contacts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Stores_OrderStoreId",
                        column: x => x.OrderStoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AutoOrder_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Contacts_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KOTStatusId = table.Column<int>(nullable: false),
                    Instruction = table.Column<string>(nullable: true),
                    KOTNo = table.Column<string>(nullable: true),
                    Updated = table.Column<bool>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: true),
                    KOTGroupId = table.Column<int>(nullable: true)
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
                        name: "FK_KOT_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KOT_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockContainer",
                columns: table => new
                {
                    StockContainerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoreId = table.Column<int>(nullable: true),
                    StockContainerName = table.Column<string>(nullable: true),
                    ContainerWight = table.Column<double>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    IsCompanyLevel = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockContainer", x => x.StockContainerId);
                    table.ForeignKey(
                        name: "FK_StockContainer_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockContainer_Contacts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockContainer_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockUpdate",
                columns: table => new
                {
                    StockUpdateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockBatchId = table.Column<int>(nullable: false),
                    UpdatedQty = table.Column<double>(nullable: false),
                    OldQty = table.Column<double>(nullable: false),
                    OldQtyAct = table.Column<double>(nullable: false),
                    StockUpdDate = table.Column<DateTime>(type: "Date", nullable: true),
                    StockUpdDateTime = table.Column<DateTime>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    StockContainerId = table.Column<int>(nullable: true),
                    GrossQty = table.Column<double>(nullable: true),
                    ContainerWight = table.Column<double>(nullable: true),
                    ContainerCount = table.Column<double>(nullable: true),
                    IsManual = table.Column<bool>(nullable: true),
                    GrossQtyText = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    Actions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockUpdate", x => x.StockUpdateId);
                    table.ForeignKey(
                        name: "FK_StockUpdate_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockUpdate_StockBatches_StockBatchId",
                        column: x => x.StockBatchId,
                        principalTable: "StockBatches",
                        principalColumn: "StockBatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockUpdate_StockContainer_StockContainerId",
                        column: x => x.StockContainerId,
                        principalTable: "StockContainer",
                        principalColumn: "StockContainerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Updated = table.Column<bool>(nullable: false),
                    DiscPercent = table.Column<double>(nullable: false),
                    DiscAmount = table.Column<double>(nullable: false),
                    ItemDiscount = table.Column<double>(nullable: true),
                    TaxItemDiscount = table.Column<double>(nullable: true),
                    OrderDiscount = table.Column<double>(nullable: true),
                    TaxOrderDiscount = table.Column<double>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    KitchenUserId = table.Column<int>(nullable: true),
                    KOTId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: true),
                    Extra = table.Column<double>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    OptionJson = table.Column<string>(nullable: true),
                    ComplementryQty = table.Column<float>(nullable: true),
                    OrderItemId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    OrderQuantity = table.Column<double>(nullable: true),
                    DispatchedQuantity = table.Column<double>(nullable: true),
                    ReceivedQuantity = table.Column<double>(nullable: true),
                    ReturnedQuantity = table.Column<double>(nullable: true),
                    CancelledQuantity = table.Column<double>(nullable: true),
                    ReceiveLaterQuantity = table.Column<double>(nullable: true),
                    DispatchLaterQuantity = table.Column<double>(nullable: true),
                    Price = table.Column<double>(nullable: true),
                    TaxAmount = table.Column<double>(nullable: true),
                    Tax1 = table.Column<double>(nullable: true),
                    Tax2 = table.Column<double>(nullable: true),
                    Tax3 = table.Column<double>(nullable: true),
                    Tax4 = table.Column<double>(nullable: true),
                    Amount = table.Column<double>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    PendingQty = table.Column<double>(nullable: true),
                    CurrentStock = table.Column<double>(nullable: true),
                    AutoOrderId = table.Column<int>(nullable: true),
                    OrderLevel = table.Column<double>(nullable: true),
                    StockUpdateId = table.Column<int>(nullable: true),
                    OldStock = table.Column<double>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    VarianceReasonStr = table.Column<string>(nullable: true),
                    VarianceReasonDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_AutoOrder_AutoOrderId",
                        column: x => x.AutoOrderId,
                        principalTable: "AutoOrder",
                        principalColumn: "AutoOrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Contacts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_KOT_KOTId",
                        column: x => x.KOTId,
                        principalTable: "KOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Users_KitchenUserId",
                        column: x => x.KitchenUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_StockUpdate_StockUpdateId",
                        column: x => x.StockUpdateId,
                        principalTable: "StockUpdate",
                        principalColumn: "StockUpdateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_EnumVal_VarianceReasonStr",
                        column: x => x.VarianceReasonStr,
                        principalTable: "EnumVal",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_CategoryId",
                table: "AutoOrder",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_CompanyId",
                table: "AutoOrder",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_CreatedBy",
                table: "AutoOrder",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_OrderStoreId",
                table: "AutoOrder",
                column: "OrderStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_ProductId",
                table: "AutoOrder",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_SupplierId",
                table: "AutoOrder",
                column: "SupplierId");

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
                name: "IX_OrderItems_AutoOrderId",
                table: "OrderItems",
                column: "AutoOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CategoryId",
                table: "OrderItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CompanyId",
                table: "OrderItems",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CreatedBy",
                table: "OrderItems",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_KOTId",
                table: "OrderItems",
                column: "KOTId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_KitchenUserId",
                table: "OrderItems",
                column: "KitchenUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_StockUpdateId",
                table: "OrderItems",
                column: "StockUpdateId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_VarianceReasonStr",
                table: "OrderItems",
                column: "VarianceReasonStr");

            migrationBuilder.CreateIndex(
                name: "IX_StockContainer_CompanyId",
                table: "StockContainer",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockContainer_CreatedBy",
                table: "StockContainer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockContainer_StoreId",
                table: "StockContainer",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StockUpdate_CompanyId",
                table: "StockUpdate",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockUpdate_StockBatchId",
                table: "StockUpdate",
                column: "StockBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_StockUpdate_StockContainerId",
                table: "StockUpdate",
                column: "StockContainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "AutoOrder");

            migrationBuilder.DropTable(
                name: "KOT");

            migrationBuilder.DropTable(
                name: "StockUpdate");

            migrationBuilder.DropTable(
                name: "StockContainer");
        }
    }
}
