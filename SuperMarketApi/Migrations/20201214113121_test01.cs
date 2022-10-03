using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class test01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiningArea_Companies_CompanyId",
                table: "DiningArea");

            migrationBuilder.DropForeignKey(
                name: "FK_DiningArea_Stores_StoreId",
                table: "DiningArea");

            migrationBuilder.DropForeignKey(
                name: "FK_DiningTable_Companies_CompanyId",
                table: "DiningTable");

            migrationBuilder.DropForeignKey(
                name: "FK_DiningTable_DiningArea_DiningAreaId",
                table: "DiningTable");

            migrationBuilder.DropForeignKey(
                name: "FK_DiningTable_Stores_StoreId",
                table: "DiningTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DiningTable_DiningTableId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderType_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Unit_UnitId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unit",
                table: "Unit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderType",
                table: "OrderType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiningTable",
                table: "DiningTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiningArea",
                table: "DiningArea");

            migrationBuilder.RenameTable(
                name: "Unit",
                newName: "Units");

            migrationBuilder.RenameTable(
                name: "OrderType",
                newName: "OrderTypes");

            migrationBuilder.RenameTable(
                name: "DiningTable",
                newName: "DiningTables");

            migrationBuilder.RenameTable(
                name: "DiningArea",
                newName: "DiningAreas");

            migrationBuilder.RenameIndex(
                name: "IX_DiningTable_StoreId",
                table: "DiningTables",
                newName: "IX_DiningTables_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_DiningTable_DiningAreaId",
                table: "DiningTables",
                newName: "IX_DiningTables_DiningAreaId");

            migrationBuilder.RenameIndex(
                name: "IX_DiningTable_CompanyId",
                table: "DiningTables",
                newName: "IX_DiningTables_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_DiningArea_StoreId",
                table: "DiningAreas",
                newName: "IX_DiningAreas_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_DiningArea_CompanyId",
                table: "DiningAreas",
                newName: "IX_DiningAreas_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTypes",
                table: "OrderTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiningTables",
                table: "DiningTables",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiningAreas",
                table: "DiningAreas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AdditionalCharges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ChargeType = table.Column<int>(nullable: false),
                    ChargeValue = table.Column<double>(nullable: false),
                    TaxGroupId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCharges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalCharges_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdditionalCharges_TaxGroups_TaxGroupId",
                        column: x => x.TaxGroupId,
                        principalTable: "TaxGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryAddons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    AddonId = table.Column<int>(nullable: false),
                    AddonGroupId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TakeawayPrice = table.Column<double>(nullable: true),
                    DeliveryPrice = table.Column<double>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAddons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryAddons_AddonGroups_AddonGroupId",
                        column: x => x.AddonGroupId,
                        principalTable: "AddonGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryAddons_Addons_AddonId",
                        column: x => x.AddonId,
                        principalTable: "Addons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAddons_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAddons_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryOptionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    OptionGroupId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TakeawayPrice = table.Column<double>(nullable: true),
                    DeliveryPrice = table.Column<double>(nullable: true),
                    UPPrice = table.Column<double>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryOptionGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryOptionGroups_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryOptionGroups_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryOptionGroups_OptionGroups_OptionGroupId",
                        column: x => x.OptionGroupId,
                        principalTable: "OptionGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    OptionId = table.Column<int>(nullable: false),
                    OptionGroupId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TakeawayPrice = table.Column<double>(nullable: true),
                    DeliveryPrice = table.Column<double>(nullable: true),
                    UPPrice = table.Column<double>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryOptions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryOptions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryOptions_OptionGroups_OptionGroupId",
                        column: x => x.OptionGroupId,
                        principalTable: "OptionGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryOptions_Variants_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Variants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryVariants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    VariantId = table.Column<int>(nullable: false),
                    VariantGroupId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TakeawayPrice = table.Column<double>(nullable: true),
                    DeliveryPrice = table.Column<double>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryVariants_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryVariants_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryVariants_VariantGroups_VariantGroupId",
                        column: x => x.VariantGroupId,
                        principalTable: "VariantGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryVariants_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cnditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VariableTypeId = table.Column<int>(nullable: false),
                    ParentCnditionId = table.Column<int>(nullable: false),
                    ValueId = table.Column<int>(nullable: false),
                    OperatorId = table.Column<int>(nullable: false),
                    JoinOperatorId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cnditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cnditions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cnditions_Operators_JoinOperatorId",
                        column: x => x.JoinOperatorId,
                        principalTable: "Operators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cnditions_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cnditions_Cnditions_ParentCnditionId",
                        column: x => x.ParentCnditionId,
                        principalTable: "Cnditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cnditions_VariableTypes_VariableTypeId",
                        column: x => x.VariableTypeId,
                        principalTable: "VariableTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    OfferId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOffers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerOffers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerOffers_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliveryBoyId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Users_DeliveryBoyId",
                        column: x => x.DeliveryBoyId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deliveries_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DiscountRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CouponCode = table.Column<string>(nullable: true),
                    DiscountType = table.Column<int>(nullable: false),
                    DiscountValue = table.Column<double>(nullable: false),
                    MiniOrderValue = table.Column<double>(nullable: false),
                    MaxDiscountAmount = table.Column<double>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountRules_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DropDownGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropDownGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KOTGroupPrinters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Printer = table.Column<string>(nullable: true),
                    KOTGroupId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KOTGroupPrinters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KOTGroupPrinters_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KOTGroupPrinters_KOTGroups_KOTGroupId",
                        column: x => x.KOTGroupId,
                        principalTable: "KOTGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KOTGroupPrinters_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KOTs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KOTStatusId = table.Column<int>(nullable: false),
                    Instruction = table.Column<string>(nullable: true),
                    KOTNo = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: true),
                    KOTGroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KOTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KOTs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KOTs_KOTGroups_KOTGroupId",
                        column: x => x.KOTGroupId,
                        principalTable: "KOTGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KOTs_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KOTs_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfferRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfferId = table.Column<int>(nullable: false),
                    RuleId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferRules_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfferRules_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OfferTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Payload = table.Column<string>(nullable: true),
                    Error = table.Column<string>(nullable: true),
                    LoggedDateTime = table.Column<DateTime>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLogs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderLogs_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Preferences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KOTGenerate = table.Column<bool>(nullable: false),
                    EnforceCustomerNo = table.Column<bool>(nullable: false),
                    QuickOrder = table.Column<bool>(nullable: false),
                    FreeQuantity = table.Column<bool>(nullable: false),
                    ShowUpcategory = table.Column<bool>(nullable: false),
                    ShowTaxonBill = table.Column<bool>(nullable: false),
                    AdminOnlyCancel = table.Column<bool>(nullable: false),
                    DineIn = table.Column<bool>(nullable: false),
                    TakeAway = table.Column<bool>(nullable: false),
                    AdvanceOrder = table.Column<bool>(nullable: false),
                    OnlineOrder = table.Column<bool>(nullable: false),
                    Delivery = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preferences_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    PortNumber = table.Column<int>(nullable: false),
                    NoOfCharacters = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAddonGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    AddonGroupId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAddonGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAddonGroups_AddonGroups_AddonGroupId",
                        column: x => x.AddonGroupId,
                        principalTable: "AddonGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductAddonGroups_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductAddonGroups_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductAddOns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    AddOnId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TakeawayPrice = table.Column<double>(nullable: false),
                    DeliveryPrice = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAddOns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAddOns_Addons_AddOnId",
                        column: x => x.AddOnId,
                        principalTable: "Addons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAddOns_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductAddOns_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductOptionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    OptionGroupId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptionGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOptionGroups_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductOptionGroups_OptionGroups_OptionGroupId",
                        column: x => x.OptionGroupId,
                        principalTable: "OptionGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductOptionGroups_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariantGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    VariantGroupId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariantGroups_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductVariantGroups_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductVariantGroups_VariantGroups_VariantGroupId",
                        column: x => x.VariantGroupId,
                        principalTable: "VariantGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    VariantId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TakeawayPrice = table.Column<double>(nullable: true),
                    DeliveryPrice = table.Column<double>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductVariants_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RestaurentName = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ConfirmPassword = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    Provider = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScreenRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: true),
                    Rules = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScreenRules_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScreenRules_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScreenRules_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShiftSummaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OpeningBalance = table.Column<double>(nullable: false),
                    ClosingBalance = table.Column<double>(nullable: false),
                    ShiftStartTime = table.Column<DateTime>(nullable: false),
                    ShiftEndTime = table.Column<DateTime>(nullable: false),
                    SalesDate = table.Column<DateTime>(type: "Date", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftSummaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShiftSummaries_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShiftSummaries_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShiftSummaries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoreOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoreId = table.Column<int>(nullable: false),
                    OptionId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: true),
                    TakeawayPrice = table.Column<double>(nullable: true),
                    DeliveryPrice = table.Column<double>(nullable: true),
                    UPPrice = table.Column<double>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreOptions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreOptions_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreOptions_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StorePreferences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KOTGenerate = table.Column<bool>(nullable: false),
                    EnforceCustomerNo = table.Column<bool>(nullable: false),
                    QuickOrder = table.Column<bool>(nullable: false),
                    FreeQuantity = table.Column<bool>(nullable: false),
                    ShowUpcategory = table.Column<bool>(nullable: false),
                    ShowTaxonBill = table.Column<bool>(nullable: false),
                    AdminOnlyCancel = table.Column<bool>(nullable: false),
                    DineIn = table.Column<bool>(nullable: false),
                    TakeAway = table.Column<bool>(nullable: false),
                    AdvanceOrder = table.Column<bool>(nullable: false),
                    OnlineOrder = table.Column<bool>(nullable: false),
                    Delivery = table.Column<bool>(nullable: false),
                    customeraddressinbill = table.Column<bool>(nullable: false),
                    showchildcategory = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorePreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorePreferences_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StorePreferences_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoreProductAddons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    AddOnId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TakeawayPrice = table.Column<double>(nullable: false),
                    DeliveryPrice = table.Column<double>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    ProductAddonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProductAddons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreProductAddons_Addons_AddOnId",
                        column: x => x.AddOnId,
                        principalTable: "Addons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreProductAddons_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProductAddons_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProductAddons_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoreProductOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoreId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    OptionId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: true),
                    TakeawayPrice = table.Column<double>(nullable: true),
                    DeliveryPrice = table.Column<double>(nullable: true),
                    UPPrice = table.Column<double>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    ProductOptionId = table.Column<int>(nullable: false),
                    MappedProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProductOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreProductOptions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProductOptions_Products_MappedProductId",
                        column: x => x.MappedProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProductOptions_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProductOptions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProductOptions_ProductOptions_ProductOptionId",
                        column: x => x.ProductOptionId,
                        principalTable: "ProductOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProductOptions_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoreProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoreId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    UPPrice = table.Column<double>(nullable: false),
                    TakeawayPrice = table.Column<double>(nullable: false),
                    DeliveryPrice = table.Column<double>(nullable: false),
                    IsDineInService = table.Column<bool>(nullable: false),
                    IsTakeAwayService = table.Column<bool>(nullable: false),
                    IsDeliveryService = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UPenabled = table.Column<bool>(nullable: false),
                    Available = table.Column<bool>(nullable: false),
                    IsSynced = table.Column<bool>(nullable: false),
                    UPAction = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: true),
                    Recommended = table.Column<bool>(nullable: false),
                    SyncedAt = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreProducts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProducts_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StoreProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StoreId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    VariantId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: true),
                    TakeawayPrice = table.Column<double>(nullable: true),
                    DeliveryPrice = table.Column<double>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    ProductVariantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProductVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreProductVariants_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProductVariants_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StoreProductVariants_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TransTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UPLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(nullable: true),
                    Json = table.Column<string>(nullable: true),
                    ReferenceId = table.Column<string>(nullable: true),
                    LogDateTime = table.Column<DateTime>(nullable: false),
                    BrandId = table.Column<int>(nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UPLogs_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UPLogs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UPLogs_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UPOptionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ref_id = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    min_selectable = table.Column<int>(nullable: false),
                    max_selectable = table.Column<int>(nullable: false),
                    active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPOptionGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UPOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ref_id = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    food_type = table.Column<int>(nullable: false),
                    sold_at_store = table.Column<bool>(nullable: false),
                    available = table.Column<bool>(nullable: false),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UPProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<double>(nullable: false),
                    Available = table.Column<bool>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UPProducts_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UPProducts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UPProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UPProducts_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UrbanPiperKeys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    ApiKey = table.Column<string>(nullable: true),
                    Zomato = table.Column<bool>(nullable: false),
                    Swiggy = table.Column<bool>(nullable: false),
                    FoodPanda = table.Column<bool>(nullable: false),
                    UberEats = table.Column<bool>(nullable: false),
                    UrbanPiper = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrbanPiperKeys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UrbanPiperKeys_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UrbanPiperKeys_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UrbanPiperStores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationName = table.Column<string>(nullable: true),
                    UPId = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    Zomato = table.Column<bool>(nullable: false),
                    IsZomato = table.Column<bool>(nullable: false),
                    Swiggy = table.Column<bool>(nullable: false),
                    IsSwiggy = table.Column<bool>(nullable: false),
                    UberEats = table.Column<bool>(nullable: false),
                    FoodPanda = table.Column<bool>(nullable: false),
                    IsUrbanPiper = table.Column<bool>(nullable: false),
                    UrbanPiper = table.Column<bool>(nullable: false),
                    Dunzo = table.Column<bool>(nullable: false),
                    IsDunzo = table.Column<bool>(nullable: false),
                    Amazon = table.Column<bool>(nullable: false),
                    IsAmazon = table.Column<bool>(nullable: false),
                    BrandId = table.Column<int>(nullable: true),
                    FoodPrepTime = table.Column<TimeSpan>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrbanPiperStores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UrbanPiperStores_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UrbanPiperStores_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UrbanPiperStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Isdefault = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserStores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserStores_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WebhookResponses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefId = table.Column<string>(nullable: true),
                    StatusCode = table.Column<int>(nullable: false),
                    message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebhookResponses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderCharges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(nullable: false),
                    AdditionalChargeId = table.Column<int>(nullable: false),
                    ChargePercentage = table.Column<double>(nullable: false),
                    ChargeAmount = table.Column<double>(nullable: false),
                    Tax1 = table.Column<double>(nullable: false),
                    Tax2 = table.Column<double>(nullable: false),
                    Tax3 = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCharges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderCharges_AdditionalCharges_AdditionalChargeId",
                        column: x => x.AdditionalChargeId,
                        principalTable: "AdditionalCharges",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderCharges_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderCharges_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderCharges_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DropDowns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    DropDownGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropDowns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DropDowns_DropDownGroups_DropDownGroupId",
                        column: x => x.DropDownGroupId,
                        principalTable: "DropDownGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<float>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Tax1 = table.Column<double>(nullable: false),
                    Tax2 = table.Column<double>(nullable: false),
                    Tax3 = table.Column<double>(nullable: false),
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
                    ComplementryQty = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_KOTs_KOTId",
                        column: x => x.KOTId,
                        principalTable: "KOTs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Users_KitchenUserId",
                        column: x => x.KitchenUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VariableTypeId = table.Column<int>(nullable: false),
                    OfferTypeId = table.Column<int>(nullable: false),
                    value = table.Column<double>(nullable: false),
                    OperatorId = table.Column<int>(nullable: false),
                    OperatorValue = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Results_OfferTypes_OfferTypeId",
                        column: x => x.OfferTypeId,
                        principalTable: "OfferTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Results_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Results_VariableTypes_VariableTypeId",
                        column: x => x.VariableTypeId,
                        principalTable: "VariableTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<double>(nullable: false),
                    OrderId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    PaymentTypeId = table.Column<int>(nullable: false),
                    TranstypeId = table.Column<int>(nullable: false),
                    PaymentStatusId = table.Column<int>(nullable: true),
                    TransDateTime = table.Column<DateTime>(nullable: false),
                    TransDate = table.Column<DateTime>(type: "Date", nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrdItemAddons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderItemId = table.Column<int>(nullable: false),
                    AddonId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdItemAddons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdItemAddons_Addons_AddonId",
                        column: x => x.AddonId,
                        principalTable: "Addons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdItemAddons_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdItemAddons_DropDowns_StatusId",
                        column: x => x.StatusId,
                        principalTable: "DropDowns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrdItemOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderItemId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    OptionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdItemOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdItemOptions_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdItemOptions_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrdItemVariants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VariantId = table.Column<int>(nullable: false),
                    OrderItemId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdItemVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdItemVariants_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdItemVariants_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCharges_CompanyId",
                table: "AdditionalCharges",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCharges_TaxGroupId",
                table: "AdditionalCharges",
                column: "TaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAddons_AddonGroupId",
                table: "CategoryAddons",
                column: "AddonGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAddons_AddonId",
                table: "CategoryAddons",
                column: "AddonId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAddons_CategoryId",
                table: "CategoryAddons",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAddons_CompanyId",
                table: "CategoryAddons",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOptionGroups_CategoryId",
                table: "CategoryOptionGroups",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOptionGroups_CompanyId",
                table: "CategoryOptionGroups",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOptionGroups_OptionGroupId",
                table: "CategoryOptionGroups",
                column: "OptionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOptions_CategoryId",
                table: "CategoryOptions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOptions_CompanyId",
                table: "CategoryOptions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOptions_OptionGroupId",
                table: "CategoryOptions",
                column: "OptionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryOptions_OptionId",
                table: "CategoryOptions",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVariants_CategoryId",
                table: "CategoryVariants",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVariants_CompanyId",
                table: "CategoryVariants",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVariants_VariantGroupId",
                table: "CategoryVariants",
                column: "VariantGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVariants_VariantId",
                table: "CategoryVariants",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Cnditions_CompanyId",
                table: "Cnditions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cnditions_JoinOperatorId",
                table: "Cnditions",
                column: "JoinOperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cnditions_OperatorId",
                table: "Cnditions",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cnditions_ParentCnditionId",
                table: "Cnditions",
                column: "ParentCnditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cnditions_VariableTypeId",
                table: "Cnditions",
                column: "VariableTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOffers_CompanyId",
                table: "CustomerOffers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOffers_CustomerId",
                table: "CustomerOffers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOffers_OfferId",
                table: "CustomerOffers",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_DeliveryBoyId",
                table: "Deliveries",
                column: "DeliveryBoyId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountRules_CompanyId",
                table: "DiscountRules",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DropDowns_DropDownGroupId",
                table: "DropDowns",
                column: "DropDownGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_KOTGroupPrinters_CompanyId",
                table: "KOTGroupPrinters",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_KOTGroupPrinters_KOTGroupId",
                table: "KOTGroupPrinters",
                column: "KOTGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_KOTGroupPrinters_StoreId",
                table: "KOTGroupPrinters",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_KOTs_CompanyId",
                table: "KOTs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_KOTs_KOTGroupId",
                table: "KOTs",
                column: "KOTGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_KOTs_OrderId",
                table: "KOTs",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_KOTs_StoreId",
                table: "KOTs",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferRules_CompanyId",
                table: "OfferRules",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferRules_OfferId",
                table: "OfferRules",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCharges_AdditionalChargeId",
                table: "OrderCharges",
                column: "AdditionalChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCharges_CompanyId",
                table: "OrderCharges",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCharges_OrderId",
                table: "OrderCharges",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCharges_StoreId",
                table: "OrderCharges",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CategoryId",
                table: "OrderItems",
                column: "CategoryId");

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
                name: "IX_OrderLogs_CompanyId",
                table: "OrderLogs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLogs_StoreId",
                table: "OrderLogs",
                column: "StoreId");

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
                name: "IX_OrdItemOptions_OptionId",
                table: "OrdItemOptions",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemOptions_OrderItemId",
                table: "OrdItemOptions",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemVariants_OrderItemId",
                table: "OrdItemVariants",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdItemVariants_VariantId",
                table: "OrdItemVariants",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_CompanyId",
                table: "Preferences",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAddonGroups_AddonGroupId",
                table: "ProductAddonGroups",
                column: "AddonGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAddonGroups_CompanyId",
                table: "ProductAddonGroups",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAddonGroups_ProductId",
                table: "ProductAddonGroups",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAddOns_AddOnId",
                table: "ProductAddOns",
                column: "AddOnId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAddOns_CompanyId",
                table: "ProductAddOns",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAddOns_ProductId",
                table: "ProductAddOns",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionGroups_CompanyId",
                table: "ProductOptionGroups",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionGroups_OptionGroupId",
                table: "ProductOptionGroups",
                column: "OptionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionGroups_ProductId",
                table: "ProductOptionGroups",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantGroups_CompanyId",
                table: "ProductVariantGroups",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantGroups_ProductId",
                table: "ProductVariantGroups",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantGroups_VariantGroupId",
                table: "ProductVariantGroups",
                column: "VariantGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_CompanyId",
                table: "ProductVariants",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariants",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_VariantId",
                table: "ProductVariants",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_CompanyId",
                table: "Results",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_OfferTypeId",
                table: "Results",
                column: "OfferTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_OperatorId",
                table: "Results",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_VariableTypeId",
                table: "Results",
                column: "VariableTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreenRules_CompanyId",
                table: "ScreenRules",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreenRules_RoleId",
                table: "ScreenRules",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ScreenRules_UserId",
                table: "ScreenRules",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftSummaries_CompanyId",
                table: "ShiftSummaries",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftSummaries_StoreId",
                table: "ShiftSummaries",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftSummaries_UserId",
                table: "ShiftSummaries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreOptions_CompanyId",
                table: "StoreOptions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreOptions_OptionId",
                table: "StoreOptions",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreOptions_StoreId",
                table: "StoreOptions",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StorePreferences_CompanyId",
                table: "StorePreferences",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StorePreferences_StoreId",
                table: "StorePreferences",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductAddons_AddOnId",
                table: "StoreProductAddons",
                column: "AddOnId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductAddons_CompanyId",
                table: "StoreProductAddons",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductAddons_ProductId",
                table: "StoreProductAddons",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductAddons_StoreId",
                table: "StoreProductAddons",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductOptions_CompanyId",
                table: "StoreProductOptions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductOptions_MappedProductId",
                table: "StoreProductOptions",
                column: "MappedProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductOptions_OptionId",
                table: "StoreProductOptions",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductOptions_ProductId",
                table: "StoreProductOptions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductOptions_ProductOptionId",
                table: "StoreProductOptions",
                column: "ProductOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductOptions_StoreId",
                table: "StoreProductOptions",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProducts_CompanyId",
                table: "StoreProducts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProducts_ProductId",
                table: "StoreProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProducts_StoreId",
                table: "StoreProducts",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductVariants_CompanyId",
                table: "StoreProductVariants",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductVariants_ProductId",
                table: "StoreProductVariants",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductVariants_StoreId",
                table: "StoreProductVariants",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreProductVariants_VariantId",
                table: "StoreProductVariants",
                column: "VariantId");

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

            migrationBuilder.CreateIndex(
                name: "IX_UPLogs_BrandId",
                table: "UPLogs",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_UPLogs_CompanyId",
                table: "UPLogs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UPLogs_StoreId",
                table: "UPLogs",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_UPProducts_BrandId",
                table: "UPProducts",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_UPProducts_CompanyId",
                table: "UPProducts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UPProducts_ProductId",
                table: "UPProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UPProducts_StoreId",
                table: "UPProducts",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_UrbanPiperKeys_AccountId",
                table: "UrbanPiperKeys",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_UrbanPiperKeys_CompanyId",
                table: "UrbanPiperKeys",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UrbanPiperStores_BrandId",
                table: "UrbanPiperStores",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_UrbanPiperStores_CompanyId",
                table: "UrbanPiperStores",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UrbanPiperStores_StoreId",
                table: "UrbanPiperStores",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_CompanyId",
                table: "UserRoles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserStores_StoreId",
                table: "UserStores",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_UserStores_UserId",
                table: "UserStores",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningAreas_Companies_CompanyId",
                table: "DiningAreas",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiningAreas_Stores_StoreId",
                table: "DiningAreas",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningTables_Companies_CompanyId",
                table: "DiningTables",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningTables_DiningAreas_DiningAreaId",
                table: "DiningTables",
                column: "DiningAreaId",
                principalTable: "DiningAreas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningTables_Stores_StoreId",
                table: "DiningTables",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DiningTables_DiningTableId",
                table: "Orders",
                column: "DiningTableId",
                principalTable: "DiningTables",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Units_UnitId",
                table: "Products",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiningAreas_Companies_CompanyId",
                table: "DiningAreas");

            migrationBuilder.DropForeignKey(
                name: "FK_DiningAreas_Stores_StoreId",
                table: "DiningAreas");

            migrationBuilder.DropForeignKey(
                name: "FK_DiningTables_Companies_CompanyId",
                table: "DiningTables");

            migrationBuilder.DropForeignKey(
                name: "FK_DiningTables_DiningAreas_DiningAreaId",
                table: "DiningTables");

            migrationBuilder.DropForeignKey(
                name: "FK_DiningTables_Stores_StoreId",
                table: "DiningTables");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DiningTables_DiningTableId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Units_UnitId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CategoryAddons");

            migrationBuilder.DropTable(
                name: "CategoryOptionGroups");

            migrationBuilder.DropTable(
                name: "CategoryOptions");

            migrationBuilder.DropTable(
                name: "CategoryVariants");

            migrationBuilder.DropTable(
                name: "Cnditions");

            migrationBuilder.DropTable(
                name: "CustomerOffers");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "DiscountRules");

            migrationBuilder.DropTable(
                name: "KOTGroupPrinters");

            migrationBuilder.DropTable(
                name: "OfferRules");

            migrationBuilder.DropTable(
                name: "OrderCharges");

            migrationBuilder.DropTable(
                name: "OrderLogs");

            migrationBuilder.DropTable(
                name: "OrdItemAddons");

            migrationBuilder.DropTable(
                name: "OrdItemOptions");

            migrationBuilder.DropTable(
                name: "OrdItemVariants");

            migrationBuilder.DropTable(
                name: "Preferences");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "ProductAddonGroups");

            migrationBuilder.DropTable(
                name: "ProductAddOns");

            migrationBuilder.DropTable(
                name: "ProductOptionGroups");

            migrationBuilder.DropTable(
                name: "ProductVariantGroups");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "ScreenRules");

            migrationBuilder.DropTable(
                name: "ShiftSummaries");

            migrationBuilder.DropTable(
                name: "StoreOptions");

            migrationBuilder.DropTable(
                name: "StorePreferences");

            migrationBuilder.DropTable(
                name: "StoreProductAddons");

            migrationBuilder.DropTable(
                name: "StoreProductOptions");

            migrationBuilder.DropTable(
                name: "StoreProducts");

            migrationBuilder.DropTable(
                name: "StoreProductVariants");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "TransTypes");

            migrationBuilder.DropTable(
                name: "UPLogs");

            migrationBuilder.DropTable(
                name: "UPOptionGroups");

            migrationBuilder.DropTable(
                name: "UPOptions");

            migrationBuilder.DropTable(
                name: "UPProducts");

            migrationBuilder.DropTable(
                name: "UrbanPiperKeys");

            migrationBuilder.DropTable(
                name: "UrbanPiperStores");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserStores");

            migrationBuilder.DropTable(
                name: "WebhookResponses");

            migrationBuilder.DropTable(
                name: "AdditionalCharges");

            migrationBuilder.DropTable(
                name: "DropDowns");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "OfferTypes");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "DropDownGroups");

            migrationBuilder.DropTable(
                name: "KOTs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTypes",
                table: "OrderTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiningTables",
                table: "DiningTables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiningAreas",
                table: "DiningAreas");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Unit");

            migrationBuilder.RenameTable(
                name: "OrderTypes",
                newName: "OrderType");

            migrationBuilder.RenameTable(
                name: "DiningTables",
                newName: "DiningTable");

            migrationBuilder.RenameTable(
                name: "DiningAreas",
                newName: "DiningArea");

            migrationBuilder.RenameIndex(
                name: "IX_DiningTables_StoreId",
                table: "DiningTable",
                newName: "IX_DiningTable_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_DiningTables_DiningAreaId",
                table: "DiningTable",
                newName: "IX_DiningTable_DiningAreaId");

            migrationBuilder.RenameIndex(
                name: "IX_DiningTables_CompanyId",
                table: "DiningTable",
                newName: "IX_DiningTable_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_DiningAreas_StoreId",
                table: "DiningArea",
                newName: "IX_DiningArea_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_DiningAreas_CompanyId",
                table: "DiningArea",
                newName: "IX_DiningArea_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unit",
                table: "Unit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderType",
                table: "OrderType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiningTable",
                table: "DiningTable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiningArea",
                table: "DiningArea",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningArea_Companies_CompanyId",
                table: "DiningArea",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningArea_Stores_StoreId",
                table: "DiningArea",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningTable_Companies_CompanyId",
                table: "DiningTable",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningTable_DiningArea_DiningAreaId",
                table: "DiningTable",
                column: "DiningAreaId",
                principalTable: "DiningArea",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningTable_Stores_StoreId",
                table: "DiningTable",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DiningTable_DiningTableId",
                table: "Orders",
                column: "DiningTableId",
                principalTable: "DiningTable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderType_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Unit_UnitId",
                table: "Products",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id");
        }
    }
}
