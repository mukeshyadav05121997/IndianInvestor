using Microsoft.EntityFrameworkCore.Migrations;

namespace IndianInvestor.Data.Migrations
{
    public partial class admindatbaselatest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "SecurityCode",
                table: "Admins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "Admins",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "AdminMV",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    SecurityCode = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    MarketCap = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminMV", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminMV");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "SecurityCode",
                table: "Admins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "SecurityCode");
        }
    }
}
