using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masood50 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Vendors",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "BusinessName",
                table: "Vendors",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Vendors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreditPeriod",
                table: "Vendors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DelivPeriod",
                table: "Vendors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DelivTimeHrs",
                table: "Vendors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsPlanned",
                table: "Vendors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PaymentStoreId",
                table: "Vendors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_CreatedBy",
                table: "Vendors",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_PaymentStoreId",
                table: "Vendors",
                column: "PaymentStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_Contacts_CreatedBy",
                table: "Vendors",
                column: "CreatedBy",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_Stores_PaymentStoreId",
                table: "Vendors",
                column: "PaymentStoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_Contacts_CreatedBy",
                table: "Vendors");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_Stores_PaymentStoreId",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_CreatedBy",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_PaymentStoreId",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "BusinessName",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "CreditPeriod",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "DelivPeriod",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "DelivTimeHrs",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "IsPlanned",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "PaymentStoreId",
                table: "Vendors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Vendors",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
