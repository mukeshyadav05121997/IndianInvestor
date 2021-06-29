using Microsoft.EntityFrameworkCore.Migrations;

namespace IndianInvestor.Data.Migrations
{
    public partial class admindatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    SecurityCode = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: false),
                    Price = table.Column<string>(nullable: true),
                    MarketCap = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.SecurityCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
