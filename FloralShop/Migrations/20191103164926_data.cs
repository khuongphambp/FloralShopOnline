using Microsoft.EntityFrameworkCore.Migrations;

namespace FloralShop.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDDepartment",
                table: "TypeProducts");

            migrationBuilder.DropColumn(
                name: "IDType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IDUser",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "IDBill",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "IDProduct",
                table: "BillDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDDepartment",
                table: "TypeProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDType",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDUser",
                table: "Bills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDBill",
                table: "BillDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDProduct",
                table: "BillDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
