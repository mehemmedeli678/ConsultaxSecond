using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Consultaxsecond.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerReguest",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    WorkArea = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerReguest", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OurProjekts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(600)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(600)", nullable: true),
                    Publishdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurProjekts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Publishdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Section1",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(600)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Section2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(600)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section2", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(600)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WhoWeAre",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(600)", nullable: true),
                    Signature = table.Column<string>(type: "nvarchar(600)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(600)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhoWeAre", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerReguest");

            migrationBuilder.DropTable(
                name: "OurProjekts");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Section1");

            migrationBuilder.DropTable(
                name: "Section2");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WhoWeAre");
        }
    }
}
