using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEshop.Migrations
{
    /// <inheritdoc />
    public partial class datbase44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numbers",
                table: "productcs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quentitystock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quentitystock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quentitystock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quentitystock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quentitystock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quentitystock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quentitystock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quentitystock",
                value: 0);

            migrationBuilder.UpdateData(
                table: "productcs",
                keyColumn: "Id",
                keyValue: 1,
                column: "numbers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "productcs",
                keyColumn: "Id",
                keyValue: 2,
                column: "numbers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "productcs",
                keyColumn: "Id",
                keyValue: 3,
                column: "numbers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "productcs",
                keyColumn: "Id",
                keyValue: 4,
                column: "numbers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "productcs",
                keyColumn: "Id",
                keyValue: 5,
                column: "numbers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "productcs",
                keyColumn: "Id",
                keyValue: 6,
                column: "numbers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "productcs",
                keyColumn: "Id",
                keyValue: 7,
                column: "numbers",
                value: 0);

            migrationBuilder.UpdateData(
                table: "productcs",
                keyColumn: "Id",
                keyValue: 8,
                column: "numbers",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numbers",
                table: "productcs");

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Quentitystock",
                value: 5);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quentitystock",
                value: 8);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 3,
                column: "Quentitystock",
                value: 3);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 4,
                column: "Quentitystock",
                value: 35);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 5,
                column: "Quentitystock",
                value: 32);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 6,
                column: "Quentitystock",
                value: 64);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 7,
                column: "Quentitystock",
                value: 40);

            migrationBuilder.UpdateData(
                table: "items",
                keyColumn: "Id",
                keyValue: 8,
                column: "Quentitystock",
                value: 30);
        }
    }
}
