using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "barcode",
                table: "DCandidates",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "barcode",
                table: "DCandidates",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);
        }
    }
}
