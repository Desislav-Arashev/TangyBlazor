using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tangy_DataAccess.Migrations
{
    public partial class ChangeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopFavorite",
                table: "Products",
                newName: "ShopFavorites");

            migrationBuilder.RenameColumn(
                name: "CustomerFavorite",
                table: "Products",
                newName: "CustomerFavorites");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopFavorites",
                table: "Products",
                newName: "ShopFavorite");

            migrationBuilder.RenameColumn(
                name: "CustomerFavorites",
                table: "Products",
                newName: "CustomerFavorite");
        }
    }
}
