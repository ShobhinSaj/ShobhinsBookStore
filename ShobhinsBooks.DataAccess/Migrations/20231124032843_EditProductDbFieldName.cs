using Microsoft.EntityFrameworkCore.Migrations;

namespace ShobhinsBooks.DataAccess.Migrations
{
    public partial class EditProductDbFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUr1",
                table: "Products",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "ImageUr1");
        }
    }
}
