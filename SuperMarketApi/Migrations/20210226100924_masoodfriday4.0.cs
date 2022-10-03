using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masoodfriday40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnumVal",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnumVal", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Updated = table.Column<bool>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    SourceId = table.Column<int>(nullable: true),
                    AggregatorOrderId = table.Column<string>(nullable: true),
                    UPOrderId = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    CustomerAddressId = table.Column<int>(nullable: true),
                    OrderStatusId = table.Column<int>(nullable: false),
                    PreviousStatusId = table.Column<int>(nullable: true),
                    BillAmount = table.Column<double>(nullable: false),
                    PaidAmount = table.Column<double>(nullable: false),
                    RefundAmount = table.Column<double>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    Tax1 = table.Column<double>(nullable: false),
                    Tax2 = table.Column<double>(nullable: false),
                    Tax3 = table.Column<double>(nullable: false),
                    BillStatusId = table.Column<int>(nullable: false),
                    SplitTableId = table.Column<int>(nullable: true),
                    DiscPercent = table.Column<double>(nullable: false),
                    DiscAmount = table.Column<double>(nullable: false),
                    IsAdvanceOrder = table.Column<bool>(nullable: false),
                    CustomerData = table.Column<string>(nullable: true),
                    DiningTableId = table.Column<int>(nullable: true),
                    WaiterId = table.Column<int>(nullable: true),
                    OrderedDateTime = table.Column<DateTime>(nullable: false),
                    OrderedDate = table.Column<DateTime>(type: "Date", nullable: false),
                    DeliveryDateTime = table.Column<DateTime>(nullable: true),
                    BillDateTime = table.Column<DateTime>(nullable: false),
                    BillDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Note = table.Column<string>(nullable: true),
                    OrderStatusDetails = table.Column<string>(nullable: true),
                    RiderStatusDetails = table.Column<string>(nullable: true),
                    FoodReady = table.Column<bool>(nullable: false),
                    Closed = table.Column<bool>(nullable: false),
                    OrderJson = table.Column<string>(nullable: true),
                    ItemJson = table.Column<string>(nullable: true),
                    ChargeJson = table.Column<string>(nullable: true),
                    Charges = table.Column<double>(nullable: true),
                    OrderDiscount = table.Column<double>(nullable: true),
                    OrderTaxDisc = table.Column<double>(nullable: true),
                    OrderTotDisc = table.Column<double>(nullable: true),
                    AllItemDisc = table.Column<double>(nullable: true),
                    AllItemTaxDisc = table.Column<double>(nullable: true),
                    AllItemTotalDisc = table.Column<double>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    OrderType = table.Column<int>(nullable: false),
                    AutoOrderId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    SuppliedById = table.Column<int>(nullable: false),
                    OrderedById = table.Column<int>(nullable: false),
                    OrderStatus = table.Column<int>(nullable: true),
                    DispatchStatus = table.Column<int>(nullable: true),
                    ReceiveStatus = table.Column<int>(nullable: true),
                    CancelStatus = table.Column<int>(nullable: true),
                    SpecialOrder = table.Column<bool>(nullable: false),
                    WipStatus = table.Column<string>(nullable: true),
                    ProdStatus = table.Column<string>(nullable: true),
                    DifferentPercent = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_CustomerAddress_CustomerAddressId",
                        column: x => x.CustomerAddressId,
                        principalTable: "CustomerAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_DiningTables_DiningTableId",
                        column: x => x.DiningTableId,
                        principalTable: "DiningTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Contacts_OrderedById",
                        column: x => x.OrderedById,
                        principalTable: "Contacts",
                        principalColumn: "ContactId");
                    table.ForeignKey(
                        name: "FK_Orders_EnumVal_ProdStatus",
                        column: x => x.ProdStatus,
                        principalTable: "EnumVal",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Contacts_SuppliedById",
                        column: x => x.SuppliedById,
                        principalTable: "Contacts",
                        principalColumn: "ContactId");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_WaiterId",
                        column: x => x.WaiterId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_EnumVal_WipStatus",
                        column: x => x.WipStatus,
                        principalTable: "EnumVal",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CompanyId",
                table: "Orders",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerAddressId",
                table: "Orders",
                column: "CustomerAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DiningTableId",
                table: "Orders",
                column: "DiningTableId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderedById",
                table: "Orders",
                column: "OrderedById");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProdStatus",
                table: "Orders",
                column: "ProdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreId",
                table: "Orders",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SuppliedById",
                table: "Orders",
                column: "SuppliedById");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WaiterId",
                table: "Orders",
                column: "WaiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WipStatus",
                table: "Orders",
                column: "WipStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "EnumVal");
        }
    }
}
