using Microsoft.EntityFrameworkCore.Migrations;

namespace FloralShop.Migrations
{
    public partial class alldata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDType",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeProductID",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillID",
                table: "BillDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IDBill",
                table: "BillDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDProduct",
                table: "BillDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "BillDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeProductID",
                table: "Products",
                column: "TypeProductID");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_BillID",
                table: "BillDetails",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_ProductID",
                table: "BillDetails",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Bills_BillID",
                table: "BillDetails",
                column: "BillID",
                principalTable: "Bills",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Products_ProductID",
                table: "BillDetails",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypeProducts_TypeProductID",
                table: "Products",
                column: "TypeProductID",
                principalTable: "TypeProducts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Bills_BillID",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Products_ProductID",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypeProducts_TypeProductID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TypeProductID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_BillDetails_BillID",
                table: "BillDetails");

            migrationBuilder.DropIndex(
                name: "IX_BillDetails_ProductID",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "IDType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TypeProductID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BillID",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "IDBill",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "IDProduct",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "BillDetails");
        }
    }
}
