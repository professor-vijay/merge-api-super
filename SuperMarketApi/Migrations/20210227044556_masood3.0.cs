using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masood30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    BillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InVoiceNum = table.Column<string>(nullable: true),
                    BillType = table.Column<int>(nullable: false),
                    DispatchType = table.Column<int>(nullable: true),
                    BillAmount = table.Column<double>(nullable: false),
                    BillAmountNoTax = table.Column<double>(nullable: false),
                    TaxAmount = table.Column<double>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: true),
                    PaidAmount = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: true),
                    ProviderId = table.Column<int>(nullable: false),
                    ReceiverId = table.Column<int>(nullable: false),
                    DispatchById = table.Column<int>(nullable: true),
                    ReceivedById = table.Column<int>(nullable: true),
                    PaymentStoreId = table.Column<int>(nullable: true),
                    RecurDate = table.Column<DateTime>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    BillDate = table.Column<DateTime>(type: "Date", nullable: true),
                    DispatchedDate = table.Column<DateTime>(nullable: true),
                    ReceivedDate = table.Column<DateTime>(nullable: true),
                    ReturnedDate = table.Column<DateTime>(nullable: true),
                    ReceiveStatus = table.Column<int>(nullable: true),
                    ReceiveLater = table.Column<bool>(nullable: false),
                    DispatchLater = table.Column<bool>(nullable: false),
                    SoftCopy = table.Column<byte[]>(nullable: true),
                    IsReturn = table.Column<bool>(nullable: false),
                    DiscPercent = table.Column<int>(nullable: false),
                    DiscAmount = table.Column<int>(nullable: false),
                    TotalDiscount = table.Column<double>(nullable: false),
                    IsPaid = table.Column<bool>(nullable: true),
                    CreditTypeStr = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    ShowAllProd = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bill_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bill_Contacts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_EnumVal_CreditTypeStr",
                        column: x => x.CreditTypeStr,
                        principalTable: "EnumVal",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_Contacts_DispatchById",
                        column: x => x.DispatchById,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_Contacts_PaymentStoreId",
                        column: x => x.PaymentStoreId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_Contacts_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId");
                    table.ForeignKey(
                        name: "FK_Bill_Contacts_ReceivedById",
                        column: x => x.ReceivedById,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_Contacts_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId");
                });

            migrationBuilder.CreateTable(
                name: "OrderItemDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OrdProdDetailId = table.Column<int>(nullable: false),
                    ActualProdId = table.Column<int>(nullable: true),
                    BatchId = table.Column<int>(nullable: true),
                    BillId = table.Column<int>(nullable: true),
                    OrdProdType = table.Column<int>(nullable: false),
                    StorageStoreId = table.Column<int>(nullable: true),
                    ContatinerId = table.Column<int>(nullable: true),
                    ContainerCount = table.Column<int>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: true),
                    Tax1 = table.Column<double>(nullable: true),
                    Tax2 = table.Column<double>(nullable: true),
                    Amount = table.Column<double>(nullable: true),
                    TaxAmount = table.Column<double>(nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true),
                    RelatedOrderId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    DiscAmount = table.Column<double>(nullable: false),
                    DiscPercent = table.Column<double>(nullable: false),
                    DiscPerQty = table.Column<double>(nullable: false),
                    AutoOrderId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    VarianceReasonStr = table.Column<string>(nullable: true),
                    VarianceReasonDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_Products_ActualProdId",
                        column: x => x.ActualProdId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_AutoOrder_AutoOrderId",
                        column: x => x.AutoOrderId,
                        principalTable: "AutoOrder",
                        principalColumn: "AutoOrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_Bill_BillId",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_StockContainer_ContatinerId",
                        column: x => x.ContatinerId,
                        principalTable: "StockContainer",
                        principalColumn: "StockContainerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_Contacts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_OrderItems_Id",
                        column: x => x.Id,
                        principalTable: "OrderItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_Stores_StorageStoreId",
                        column: x => x.StorageStoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_EnumVal_VarianceReasonStr",
                        column: x => x.VarianceReasonStr,
                        principalTable: "EnumVal",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CompanyId",
                table: "Bill",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CreatedBy",
                table: "Bill",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CreditTypeStr",
                table: "Bill",
                column: "CreditTypeStr");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_DispatchById",
                table: "Bill",
                column: "DispatchById");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentStoreId",
                table: "Bill",
                column: "PaymentStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ProviderId",
                table: "Bill",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ReceivedById",
                table: "Bill",
                column: "ReceivedById");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ReceiverId",
                table: "Bill",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_ActualProdId",
                table: "OrderItemDetails",
                column: "ActualProdId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_AutoOrderId",
                table: "OrderItemDetails",
                column: "AutoOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_BatchId",
                table: "OrderItemDetails",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_BillId",
                table: "OrderItemDetails",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_CompanyId",
                table: "OrderItemDetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_ContatinerId",
                table: "OrderItemDetails",
                column: "ContatinerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_CreatedBy",
                table: "OrderItemDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_StorageStoreId",
                table: "OrderItemDetails",
                column: "StorageStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_VarianceReasonStr",
                table: "OrderItemDetails",
                column: "VarianceReasonStr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItemDetails");

            migrationBuilder.DropTable(
                name: "Bill");
        }
    }
}
