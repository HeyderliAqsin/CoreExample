using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class languagenamechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "CategoryRecords");

            migrationBuilder.AddColumn<string>(
                name: "LanguageKey",
                table: "CategoryRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LanguageKey",
                table: "CategoryRecords");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "CategoryRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
