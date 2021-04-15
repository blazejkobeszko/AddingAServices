using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoCrafts.WebSite.Migrations
{
    public partial class ChangeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FizzBuzzTable",
                table: "FizzBuzzTable");

            migrationBuilder.RenameTable(
                name: "FizzBuzzTable",
                newName: "ProductTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTable",
                table: "ProductTable",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTable",
                table: "ProductTable");

            migrationBuilder.RenameTable(
                name: "ProductTable",
                newName: "FizzBuzzTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FizzBuzzTable",
                table: "FizzBuzzTable",
                column: "Id");
        }
    }
}
