using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AvarIT.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "MiscellaneousItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedUser = table.Column<string>(nullable: true),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    ItemType = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Retired = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscellaneousItems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedUser = table.Column<string>(nullable: true),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    DVI = table.Column<string>(nullable: true),
                    HDMI = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Retired = table.Column<string>(nullable: true),
                    ScreenSize = table.Column<string>(nullable: true),
                    ScreenType = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    VGA = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NetWorks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessPoint = table.Column<string>(nullable: true),
                    AssignedUser = table.Column<string>(nullable: true),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Cabel = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    DeviceType = table.Column<string>(nullable: true),
                    Firewall = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    LANPorts = table.Column<string>(nullable: true),
                    LANSpeed = table.Column<string>(nullable: true),
                    Managed = table.Column<string>(nullable: true),
                    MemorySize = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Modem = table.Column<string>(nullable: true),
                    NameOrSSID = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Retired = table.Column<string>(nullable: true),
                    Router = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Switch = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true),
                    WirelessType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetWorks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OperationSystems",
                columns: table => new
                {
                    OSId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OSName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationSystems", x => x.OSId);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedUser = table.Column<string>(nullable: true),
                    AvarTagNumber = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    CopyScan = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    Dublix = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    LAN = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PrinterType = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Retired = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    USB = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true),
                    Wireless = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ControlName = table.Column<string>(nullable: true),
                    ControlType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ElementName = table.Column<string>(nullable: true),
                    ElementType = table.Column<string>(nullable: true),
                    IssueType = table.Column<string>(nullable: true),
                    IssueTypeID = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComputerCases",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandId = table.Column<int>(nullable: false),
                    CPUFrequency = table.Column<string>(nullable: true),
                    CPUType = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    HDDSize = table.Column<string>(nullable: true),
                    LANMAC = table.Column<string>(nullable: true),
                    LaptopScreenSize = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    MemorySize = table.Column<string>(nullable: true),
                    ModelNo = table.Column<string>(nullable: true),
                    ModelSeries = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OEMLicense = table.Column<string>(nullable: true),
                    OEMOperatingSystem = table.Column<string>(nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    OperationSystemOSId = table.Column<int>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Retired = table.Column<bool>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    UpgradeLicense = table.Column<string>(nullable: true),
                    UpgradedTo = table.Column<string>(nullable: true),
                    WLANMAC = table.Column<string>(nullable: true),
                    Warranty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerCases", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComputerCases_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerCases_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerCases_OperationSystems_OperationSystemOSId",
                        column: x => x.OperationSystemOSId,
                        principalTable: "OperationSystems",
                        principalColumn: "OSId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerCases_BrandId",
                table: "ComputerCases",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerCases_EmployeeId",
                table: "ComputerCases",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerCases_OperationSystemOSId",
                table: "ComputerCases",
                column: "OperationSystemOSId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComputerCases");

            migrationBuilder.DropTable(
                name: "MiscellaneousItems");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "NetWorks");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OperationSystems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
