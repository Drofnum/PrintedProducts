using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintedProducts.Data.Migrations
{
    public partial class DBrework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuantityAvailable",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageThumbnailUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QuantityAvailable",
                table: "Products");
        }
    }
}
