﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperMarketApi.Models;

namespace SuperMarketApi.Migrations
{
    [DbContext(typeof(POSDbContext))]
    [Migration("20201214070357_dfjshdfjsfkiojoj001")]
    partial class dfjshdfjsfkiojoj001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuperMarketApi.Models.Accounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Email");

                    b.Property<string>("FCM_Token");

                    b.Property<bool>("IsConfirmed");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNo");

                    b.Property<string>("SatPass");

                    b.Property<string>("SatUname");

                    b.Property<string>("UPAPIKey");

                    b.Property<string>("UPUsername");

                    b.Property<string>("bizid");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Addon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddonGroupId");

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("AddonGroupId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProductId");

                    b.ToTable("Addons");
                });

            modelBuilder.Entity("SuperMarketApi.Models.AddonGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("AddonGroups");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<int?>("FreeQtyPercentage");

                    b.Property<bool>("IsSynced");

                    b.Property<bool>("IsUPCategory");

                    b.Property<int?>("MinimumQty");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int?>("ParentCategoryId");

                    b.Property<int?>("SortOrder");

                    b.Property<bool>("isactive");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.Property<string>("PostalCode");

                    b.Property<string>("State");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastRedeemDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("OTP");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNo");

                    b.Property<int?>("PostalCode");

                    b.Property<int?>("RemainingPoints");

                    b.Property<int?>("StoreId");

                    b.Property<int?>("TotalPoints");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("StoreId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SuperMarketApi.Models.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Contact");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Name");

                    b.Property<bool>("iscurrentaddress");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerAddress");
                });

            modelBuilder.Entity("SuperMarketApi.Models.DiningArea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("StoreId");

                    b.ToTable("DiningArea");
                });

            modelBuilder.Entity("SuperMarketApi.Models.DiningTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description");

                    b.Property<int>("DiningAreaId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("StoreId");

                    b.Property<int>("TableStatusId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DiningAreaId");

                    b.HasIndex("StoreId");

                    b.ToTable("DiningTable");
                });

            modelBuilder.Entity("SuperMarketApi.Models.KOTGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsEditable");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Printer");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("KOTGroups");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("UpdateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Operator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("OperType");

                    b.HasKey("Id");

                    b.ToTable("Operators");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<double>("DeliveryPrice");

                    b.Property<string>("Description");

                    b.Property<bool>("IsSynced");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("OptionGroupId");

                    b.Property<double>("Price");

                    b.Property<int>("SortOrder");

                    b.Property<double>("TakeawayPrice");

                    b.Property<double>("UPPrice");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("OptionGroupId");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("SuperMarketApi.Models.OptionGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsSynced");

                    b.Property<int>("MaximumSelectable");

                    b.Property<int>("MinimumSelectable");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("OptionGroupType");

                    b.Property<int>("SortOrder");

                    b.Property<bool>("isactive");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("OptionGroups");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AggregatorOrderId");

                    b.Property<double?>("AllItemDisc");

                    b.Property<double?>("AllItemTaxDisc");

                    b.Property<double?>("AllItemTotalDisc");

                    b.Property<double>("BillAmount");

                    b.Property<DateTime>("BillDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("BillDateTime");

                    b.Property<int>("BillStatusId");

                    b.Property<string>("ChargeJson");

                    b.Property<double?>("Charges");

                    b.Property<bool>("Closed");

                    b.Property<int>("CompanyId");

                    b.Property<int?>("CustomerAddressId");

                    b.Property<string>("CustomerData");

                    b.Property<int?>("CustomerId");

                    b.Property<DateTime?>("DeliveryDateTime");

                    b.Property<int?>("DiningTableId");

                    b.Property<double>("DiscAmount");

                    b.Property<double>("DiscPercent");

                    b.Property<bool>("FoodReady");

                    b.Property<string>("InvoiceNo");

                    b.Property<bool>("IsAdvanceOrder");

                    b.Property<string>("ItemJson");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Note");

                    b.Property<double?>("OrderDiscount");

                    b.Property<string>("OrderJson");

                    b.Property<int>("OrderNo");

                    b.Property<string>("OrderStatusDetails");

                    b.Property<int>("OrderStatusId");

                    b.Property<double?>("OrderTaxDisc");

                    b.Property<double?>("OrderTotDisc");

                    b.Property<int>("OrderTypeId");

                    b.Property<DateTime>("OrderedDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("OrderedDateTime");

                    b.Property<double>("PaidAmount");

                    b.Property<int?>("PreviousStatusId");

                    b.Property<double>("RefundAmount");

                    b.Property<string>("RiderStatusDetails");

                    b.Property<string>("Source");

                    b.Property<int?>("SourceId");

                    b.Property<int?>("SplitTableId");

                    b.Property<int?>("StoreId");

                    b.Property<double>("Tax1");

                    b.Property<double>("Tax2");

                    b.Property<double>("Tax3");

                    b.Property<string>("UPOrderId");

                    b.Property<int?>("UserId");

                    b.Property<int?>("WaiterId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerAddressId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DiningTableId");

                    b.HasIndex("OrderTypeId");

                    b.HasIndex("StoreId");

                    b.HasIndex("UserId");

                    b.HasIndex("WaiterId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SuperMarketApi.Models.OrderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("OrderType");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BarCode");

                    b.Property<int>("CategoryId");

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<double>("DeliveryPrice");

                    b.Property<string>("Description");

                    b.Property<byte[]>("Image");

                    b.Property<string>("ImgUrl");

                    b.Property<int?>("KOTGroupId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("ProductCode");

                    b.Property<int>("ProductTypeId");

                    b.Property<bool>("Recomended");

                    b.Property<int?>("SortOrder");

                    b.Property<double>("TakeawayPrice");

                    b.Property<int>("TaxGroupId");

                    b.Property<double>("UPPrice");

                    b.Property<int>("UnitId");

                    b.Property<bool>("isactive");

                    b.Property<int?>("minblock");

                    b.Property<int?>("minquantity");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("KOTGroupId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("TaxGroupId");

                    b.HasIndex("UnitId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SuperMarketApi.Models.ProductOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<double?>("DeliveryPrice");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("OptionId");

                    b.Property<double>("Price");

                    b.Property<int>("ProductId");

                    b.Property<double?>("TakeawayPrice");

                    b.Property<double?>("UPPrice");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("OptionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOptions");
                });

            modelBuilder.Entity("SuperMarketApi.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("AutoAcceptTime");

                    b.Property<string>("City");

                    b.Property<TimeSpan>("ClosingTime");

                    b.Property<int>("CompanyId");

                    b.Property<string>("ContactNo");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<int>("FoodPrepTime");

                    b.Property<string>("GSTno");

                    b.Property<bool>("IsSalesStore");

                    b.Property<string>("Name");

                    b.Property<TimeSpan>("OpeningTime");

                    b.Property<int?>("ParentStoreId");

                    b.Property<string>("PostalCode");

                    b.Property<bool>("isactive");

                    b.Property<string>("kotprinter");

                    b.Property<string>("receiptprinter");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ParentStoreId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("SuperMarketApi.Models.TaxGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description");

                    b.Property<bool>("IsInclusive");

                    b.Property<double>("Tax1");

                    b.Property<double>("Tax2");

                    b.Property<double>("Tax3");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("TaxGroups");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("SuperMarketApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name");

                    b.Property<int>("Pin");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SuperMarketApi.Models.VariableType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("VariableTypes");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int?>("VariantGroupId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("VariantGroupId");

                    b.ToTable("Variants");
                });

            modelBuilder.Entity("SuperMarketApi.Models.VariantGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("VariantGroups");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Accounts", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.Addon", b =>
                {
                    b.HasOne("SuperMarketApi.Models.AddonGroup", "AddonGroup")
                        .WithMany()
                        .HasForeignKey("AddonGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.AddonGroup", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.Brand", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.Category", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Customer", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("SuperMarketApi.Models.CustomerAddress", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.DiningArea", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.DiningTable", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.DiningArea", "DiningArea")
                        .WithMany()
                        .HasForeignKey("DiningAreaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.KOTGroup", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.Offer", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.Option", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.OptionGroup", "OptionGroup")
                        .WithMany()
                        .HasForeignKey("OptionGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.OptionGroup", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.Order", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.CustomerAddress", "CustomerAddress")
                        .WithMany()
                        .HasForeignKey("CustomerAddressId");

                    b.HasOne("SuperMarketApi.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("SuperMarketApi.Models.DiningTable", "DiningTable")
                        .WithMany()
                        .HasForeignKey("DiningTableId");

                    b.HasOne("SuperMarketApi.Models.OrderType", "OrderType")
                        .WithMany()
                        .HasForeignKey("OrderTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId");

                    b.HasOne("SuperMarketApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("SuperMarketApi.Models.User", "POSUser")
                        .WithMany()
                        .HasForeignKey("WaiterId");
                });

            modelBuilder.Entity("SuperMarketApi.Models.Product", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.KOTGroup", "KOTGroup")
                        .WithMany()
                        .HasForeignKey("KOTGroupId");

                    b.HasOne("SuperMarketApi.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.TaxGroup", "TaxGroup")
                        .WithMany()
                        .HasForeignKey("TaxGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.ProductOption", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Option", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.Store", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Store", "ParentStore")
                        .WithMany()
                        .HasForeignKey("ParentStoreId");
                });

            modelBuilder.Entity("SuperMarketApi.Models.TaxGroup", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.User", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Accounts", "Accounts")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperMarketApi.Models.Variant", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperMarketApi.Models.VariantGroup", "VariantGroup")
                        .WithMany()
                        .HasForeignKey("VariantGroupId");
                });

            modelBuilder.Entity("SuperMarketApi.Models.VariantGroup", b =>
                {
                    b.HasOne("SuperMarketApi.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}