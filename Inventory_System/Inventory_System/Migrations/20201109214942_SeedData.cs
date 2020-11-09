using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory_System.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "Discontinue", "Name", "Quantity" },
                values: new object[,]
                {
                    { -1, true, "IPhone 3G", 0 },
                    { -2, true, "IPhone 3", 0 },
                    { -3, true, "IPhone 4", 0 },
                    { -5, false, "IPhone 4S", 0 },
                    { -6, false, "IPhone 5", 0 },
                    { -7, false, "IPhone 5S", 0 },
                    { -8, false, "IPhone 6", 0 },
                    { -9, false, "IPhone 6S", 0 },
                    { -10, false, "IPhone 7", 0 },
                    { -11, false, "IPhone 7Plus", 0 },
                    { -12, false, "IPhone 8", 0 },
                    { -13, false, "IPhone 8Plus", 0 },
                    { -14, false, "IPhone X", 0 },
                    { -15, false, "IPhone 11", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
