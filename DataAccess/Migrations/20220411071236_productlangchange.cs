using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class productlangchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "ProductRecords");

            migrationBuilder.AddColumn<string>(
                name: "LanguageKey",
                table: "ProductRecords",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageKey",
                table: "ProductRecords");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "ProductRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
