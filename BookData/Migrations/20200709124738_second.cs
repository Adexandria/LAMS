using Microsoft.EntityFrameworkCore.Migrations;

namespace BookData.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password1",
                table: "Details");

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Password1",
                table: "Details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
