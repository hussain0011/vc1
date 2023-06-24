using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vc1.Data.Migrations
{
    public partial class ConvertingCModelToSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArchivingTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbnilPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SigniturePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchivingTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchivingTable");
        }
    }
}
