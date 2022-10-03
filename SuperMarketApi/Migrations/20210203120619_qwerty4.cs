using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class qwerty4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "WebhookResponses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Variants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "VariantGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "VariableTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "UserStores",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "UserRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "UrbanPiperStores",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "UrbanPiperKeys",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "UPProducts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "UPOptions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "UPOptionGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "UPLogs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Units",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "TransTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Transactions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "TaxGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Stores",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "StoreProductVariants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "StoreProducts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "StoreProductOptions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "StoreProductAddons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "StorePreferences",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "StoreOptions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "ShiftSummaries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "ScreenRules",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Roles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Results",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Registrations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "ProductVariants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "ProductVariantGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "ProductTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "ProductOptions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "ProductOptionGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "ProductAddOns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "ProductAddonGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Printers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Preferences",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "PaymentTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OrdItemVariants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OrdItemOptions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OrdItemAddons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OrderTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OrderLogs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OrderItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OrderCharges",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Options",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OptionGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Operators",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OfferTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Offers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "OfferRules",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "KOTs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "KOTGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "KOTGroupPrinters",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "DropDowns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "DropDownGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "DiscountRules",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "DiningTables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "DiningAreas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Deliveries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "CustomerOffers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "CustomerAddress",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Companies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Cnditions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "CategoryVariants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "CategoryVariantGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "CategoryOptions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "CategoryOptionGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "CategoryAddons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Brands",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "BarcodeVariants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "AddonGroups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "AdditionalCharges",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Updated",
                table: "Accounts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Updated",
                table: "WebhookResponses");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Variants");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "VariantGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "VariableTypes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "UserStores");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "UrbanPiperStores");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "UrbanPiperKeys");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "UPProducts");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "UPOptions");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "UPOptionGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "UPLogs");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "TransTypes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "TaxGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "StoreProductVariants");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "StoreProducts");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "StoreProductOptions");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "StoreProductAddons");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "StorePreferences");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "StoreOptions");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ShiftSummaries");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ScreenRules");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ProductVariantGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ProductOptions");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ProductOptionGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ProductAddOns");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "ProductAddonGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Preferences");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "PaymentTypes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OrdItemVariants");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OrdItemOptions");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OrdItemAddons");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OrderTypes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OrderLogs");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OrderCharges");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OptionGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Operators");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OfferTypes");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Offers");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "OfferRules");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "KOTs");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "KOTGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "KOTGroupPrinters");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "DropDowns");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "DropDownGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "DiscountRules");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "DiningTables");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "DiningAreas");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "CustomerOffers");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "CustomerAddress");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Cnditions");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "CategoryVariants");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "CategoryVariantGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "CategoryOptions");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "CategoryOptionGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "CategoryAddons");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "BarcodeVariants");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "AddonGroups");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "AdditionalCharges");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Accounts");
        }
    }
}
