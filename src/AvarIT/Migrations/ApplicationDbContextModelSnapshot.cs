using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AvarIT.Data;

namespace AvarIT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AvarIT.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.ComputerCase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrandId");

                    b.Property<string>("CPUFrequency");

                    b.Property<string>("CPUType");

                    b.Property<decimal?>("Cost");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("HDDSize");

                    b.Property<string>("LANMAC");

                    b.Property<string>("LaptopScreenSize");

                    b.Property<string>("MachineName");

                    b.Property<string>("MemorySize");

                    b.Property<string>("ModelNo");

                    b.Property<string>("ModelSeries");

                    b.Property<string>("Note");

                    b.Property<string>("OEMLicense");

                    b.Property<string>("OEMOperatingSystem");

                    b.Property<string>("OfficeLocation");

                    b.Property<int?>("OfficeLocationId");

                    b.Property<int?>("OperationSystemOSId");

                    b.Property<string>("OrderNo");

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<bool>("Retired");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("UpgradeLicense");

                    b.Property<string>("UpgradedTo");

                    b.Property<string>("WLANMAC");

                    b.Property<string>("Warranty");

                    b.HasKey("ID");

                    b.HasIndex("BrandId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("OfficeLocationId");

                    b.HasIndex("OperationSystemOSId");

                    b.ToTable("ComputerCases");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmployeeName");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.Miscellaneous", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssignedUser");

                    b.Property<string>("AvarTagNumber");

                    b.Property<string>("Brand");

                    b.Property<decimal>("Cost");

                    b.Property<string>("ItemType");

                    b.Property<string>("LANMAC");

                    b.Property<string>("License");

                    b.Property<string>("MachineName");

                    b.Property<string>("ModelNo");

                    b.Property<string>("ModelSeries");

                    b.Property<string>("Note");

                    b.Property<string>("OfficeLocation");

                    b.Property<string>("OrderNo");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("Retired");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("WLANMAC");

                    b.Property<string>("Warranty");

                    b.HasKey("ID");

                    b.ToTable("MiscellaneousItems");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.Monitor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssignedUser");

                    b.Property<string>("AvarTagNumber");

                    b.Property<string>("Brand");

                    b.Property<decimal>("Cost");

                    b.Property<string>("DVI");

                    b.Property<string>("HDMI");

                    b.Property<string>("ModelNo");

                    b.Property<string>("ModelSeries");

                    b.Property<string>("Note");

                    b.Property<string>("OfficeLocation");

                    b.Property<string>("OrderNo");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("Retired");

                    b.Property<string>("ScreenSize");

                    b.Property<string>("ScreenType");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("VGA");

                    b.Property<string>("Warranty");

                    b.HasKey("ID");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.NetWork", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessPoint");

                    b.Property<string>("AssignedUser");

                    b.Property<string>("AvarTagNumber");

                    b.Property<string>("Brand");

                    b.Property<string>("Cabel");

                    b.Property<decimal?>("Cost");

                    b.Property<string>("DeviceType");

                    b.Property<string>("Firewall");

                    b.Property<string>("LANMAC");

                    b.Property<string>("LANPorts");

                    b.Property<string>("LANSpeed");

                    b.Property<string>("Managed");

                    b.Property<string>("MemorySize");

                    b.Property<string>("ModelNo");

                    b.Property<string>("ModelSeries");

                    b.Property<string>("Modem");

                    b.Property<string>("NameOrSSID");

                    b.Property<string>("Note");

                    b.Property<string>("OfficeLocation");

                    b.Property<string>("OrderNo");

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<string>("Retired");

                    b.Property<string>("Router");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("Switch");

                    b.Property<string>("WLANMAC");

                    b.Property<string>("Warranty");

                    b.Property<string>("WirelessType");

                    b.HasKey("ID");

                    b.ToTable("NetWorks");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.OfficeLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OfficeLocations");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.OperationSystem", b =>
                {
                    b.Property<int>("OSId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OSName");

                    b.HasKey("OSId");

                    b.ToTable("OperationSystems");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.Printer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssignedUser");

                    b.Property<string>("AvarTagNumber");

                    b.Property<string>("Brand");

                    b.Property<string>("Color");

                    b.Property<string>("CopyScan");

                    b.Property<decimal>("Cost");

                    b.Property<string>("Dublix");

                    b.Property<string>("Fax");

                    b.Property<string>("LAN");

                    b.Property<string>("LANMAC");

                    b.Property<string>("MachineName");

                    b.Property<string>("ModelNo");

                    b.Property<string>("ModelSeries");

                    b.Property<string>("Note");

                    b.Property<string>("OfficeLocation");

                    b.Property<string>("OrderNo");

                    b.Property<string>("PrinterType");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("Retired");

                    b.Property<string>("SerialNumber");

                    b.Property<string>("USB");

                    b.Property<string>("WLANMAC");

                    b.Property<string>("Warranty");

                    b.Property<string>("Wireless");

                    b.HasKey("ID");

                    b.ToTable("Printers");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.WebCompatibilityIssues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ControlName");

                    b.Property<string>("ControlType");

                    b.Property<string>("Description");

                    b.Property<string>("ElementName");

                    b.Property<string>("ElementType");

                    b.Property<string>("IssueType");

                    b.Property<string>("IssueTypeID");

                    b.Property<string>("PropertyName");

                    b.HasKey("ID");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AvarIT.Models.InventoryModels.ComputerCase", b =>
                {
                    b.HasOne("AvarIT.Models.InventoryModels.Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvarIT.Models.InventoryModels.Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvarIT.Models.InventoryModels.OfficeLocation")
                        .WithMany()
                        .HasForeignKey("OfficeLocationId");

                    b.HasOne("AvarIT.Models.InventoryModels.OperationSystem")
                        .WithMany()
                        .HasForeignKey("OperationSystemOSId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AvarIT.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AvarIT.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AvarIT.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
