using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masood7friday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Transactions");

            //migrationBuilder.DropTable(
            //    name: "Order");

            //migrationBuilder.DropTable(
            //    name: "OrderType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Updated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AggregatorOrderId = table.Column<string>(nullable: true),
                    AllItemDisc = table.Column<double>(nullable: true),
                    AllItemTaxDisc = table.Column<double>(nullable: true),
                    AllItemTotalDisc = table.Column<double>(nullable: true),
                    BillAmount = table.Column<double>(nullable: false),
                    BillDate = table.Column<DateTime>(type: "Date", nullable: false),
                    BillDateTime = table.Column<DateTime>(nullable: false),
                    BillStatusId = table.Column<int>(nullable: false),
                    ChargeJson = table.Column<string>(nullable: true),
                    Charges = table.Column<double>(nullable: true),
                    Closed = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CustomerAddressId = table.Column<int>(nullable: true),
                    CustomerData = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    DeliveryDateTime = table.Column<DateTime>(nullable: true),
                    DiningTableId = table.Column<int>(nullable: true),
                    DiscAmount = table.Column<double>(nullable: false),
                    DiscPercent = table.Column<double>(nullable: false),
                    FoodReady = table.Column<bool>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    IsAdvanceOrder = table.Column<bool>(nullable: false),
                    ItemJson = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    OrderDiscount = table.Column<double>(nullable: true),
                    OrderJson = table.Column<string>(nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    OrderStatusDetails = table.Column<string>(nullable: true),
                    OrderStatusId = table.Column<int>(nullable: false),
                    OrderTaxDisc = table.Column<double>(nullable: true),
                    OrderTotDisc = table.Column<double>(nullable: true),
                    OrderTypeId = table.Column<int>(nullable: false),
                    OrderedDate = table.Column<DateTime>(type: "Date", nullable: false),
                    OrderedDateTime = table.Column<DateTime>(nullable: false),
                    PaidAmount = table.Column<double>(nullable: false),
                    PreviousStatusId = table.Column<int>(nullable: true),
                    RefundAmount = table.Column<double>(nullable: false),
                    RiderStatusDetails = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    SourceId = table.Column<int>(nullable: true),
                    SplitTableId = table.Column<int>(nullable: true),
                    StoreId = table.Column<int>(nullable: true),
                    Tax1 = table.Column<double>(nullable: false),
                    Tax2 = table.Column<double>(nullable: false),
                    Tax3 = table.Column<double>(nullable: false),
                    UPOrderId = table.Column<string>(nullable: true),
                    Updated = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    WaiterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_CustomerAddress_CustomerAddressId",
                        column: x => x.CustomerAddressId,
                        principalTable: "CustomerAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_DiningTables_DiningTableId",
                        column: x => x.DiningTableId,
                        principalTable: "DiningTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_OrderType_OrderTypeId",
                        column: x => x.OrderTypeId,
                        principalTable: "OrderType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Users_WaiterId",
                        column: x => x.WaiterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<double>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: true),
                    PaymentStatusId = table.Column<int>(nullable: true),
                    PaymentTypeId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: true),
                    TransDate = table.Column<DateTime>(type: "Date", nullable: false),
                    TransDateTime = table.Column<DateTime>(nullable: false),
                    TranstypeId = table.Column<int>(nullable: false),
                    Updated = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CompanyId",
                table: "Order",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerAddressId",
                table: "Order",
                column: "CustomerAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_DiningTableId",
                table: "Order",
                column: "DiningTableId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderTypeId",
                table: "Order",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StoreId",
                table: "Order",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_WaiterId",
                table: "Order",
                column: "WaiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CompanyId",
                table: "Transactions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CustomerId",
                table: "Transactions",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_OrderId",
                table: "Transactions",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentTypeId",
                table: "Transactions",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_StoreId",
                table: "Transactions",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");
        }
    }
}
