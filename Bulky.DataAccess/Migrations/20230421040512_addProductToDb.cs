using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Parker", "Prasent vitae sodales libero ", "SORJ111101", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Ron Parker", "Prasent vitae sodales libero ", "SORJ111101", 72.0, 70.0, 60.0, 65.0, "Rock in the Ocean" },
                    { 3, "Ron Parker", "Prasent vitae sodales libero ", "SORJ111101", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { 4, "Ron Parker", "Prasent vitae sodales libero ", "SORJ111101", 37.0, 35.0, 20.0, 30.0, "Rock in the Ocean" },
                    { 5, "Ron Parker", "Prasent vitae sodales libero ", "SORJ111101", 60.0, 57.0, 50.0, 55.0, "Rock in the Ocean" },
                    { 6, "Ron Parker", "Prasent vitae sodales libero ", "SORJ111101", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
