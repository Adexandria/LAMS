using Microsoft.EntityFrameworkCore.Migrations;

namespace BookData.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Signups",
                columns: new[] { "Id", "Password", "Password1", "UserName" },
                values: new object[] { 1, "nengi", "nengi", "Nengi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Signups",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
