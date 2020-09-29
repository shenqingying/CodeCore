using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDemo.Data.Migrations
{
    public partial class AddSonluk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CRM_BARCODE_COMMODITY");

            migrationBuilder.CreateTable(
                name: "Sonluks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BARCODE = table.Column<string>(maxLength: 50, nullable: false),
                    DESCRIPTION = table.Column<string>(maxLength: 200, nullable: true),
                    PP = table.Column<int>(nullable: false),
                    CPZL = table.Column<int>(nullable: false),
                    XH = table.Column<int>(nullable: false),
                    QUANTITY = table.Column<int>(nullable: false),
                    BZXS = table.Column<int>(nullable: false),
                    BZSL = table.Column<string>(nullable: true),
                    SERIES = table.Column<int>(nullable: false),
                    VERSION = table.Column<string>(nullable: true),
                    YWY = table.Column<string>(nullable: true),
                    SQR = table.Column<string>(nullable: true),
                    BEGINNING = table.Column<int>(nullable: false),
                    PIPECODE = table.Column<string>(nullable: true),
                    BEIZ = table.Column<string>(nullable: true),
                    ISACTIVE = table.Column<int>(nullable: false),
                    CJR = table.Column<int>(nullable: false),
                    CJSJ = table.Column<DateTime>(nullable: true),
                    XGR = table.Column<int>(nullable: false),
                    XGSJ = table.Column<DateTime>(nullable: true),
                    ISEDIT = table.Column<int>(nullable: false),
                    CLONEBARCODE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sonluks", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sonluks");

            migrationBuilder.CreateTable(
                name: "CRM_BARCODE_COMMODITY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BARCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BEGINNING = table.Column<int>(type: "int", nullable: false),
                    BEIZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BZSL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BZXS = table.Column<int>(type: "int", nullable: false),
                    CJR = table.Column<int>(type: "int", nullable: false),
                    CJSJ = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CLONEBARCODE = table.Column<int>(type: "int", nullable: false),
                    CPZL = table.Column<int>(type: "int", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ISACTIVE = table.Column<int>(type: "int", nullable: false),
                    ISEDIT = table.Column<int>(type: "int", nullable: false),
                    PIPECODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PP = table.Column<int>(type: "int", nullable: false),
                    QUANTITY = table.Column<int>(type: "int", nullable: false),
                    SERIES = table.Column<int>(type: "int", nullable: false),
                    SQR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERSION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGR = table.Column<int>(type: "int", nullable: false),
                    XGSJ = table.Column<DateTime>(type: "datetime2", nullable: true),
                    XH = table.Column<int>(type: "int", nullable: false),
                    YWY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRM_BARCODE_COMMODITY", x => x.ID);
                });
        }
    }
}
