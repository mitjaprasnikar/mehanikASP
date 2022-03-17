using Microsoft.EntityFrameworkCore.Migrations;

namespace MehanikASP.Data.Migrations
{
    public partial class DodaniServisi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MikroJermen",
                table: "Service",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ZobatiJermen",
                table: "Service",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MikroJermen",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ZobatiJermen",
                table: "Service");
        }
    }
}
