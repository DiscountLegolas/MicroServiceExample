using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductCode = table.Column<string>(type: "TEXT", nullable: false),
                    ProductImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 1, "A1", "https://dummyjson.com/image/i/products/1/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 2, "A2", "https://dummyjson.com/image/i/products/2/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 3, "A3", "https://dummyjson.com/image/i/products/3/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 4, "A4", "https://dummyjson.com/image/i/products/4/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 5, "A5", "https://dummyjson.com/image/i/products/5/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 6, "A6", "https://dummyjson.com/image/i/products/6/thumbnail.png" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 7, "A7", "https://dummyjson.com/image/i/products/7/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 8, "A8", "https://dummyjson.com/image/i/products/8/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 9, "A9", "https://dummyjson.com/image/i/products/9/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 10, "A10", "https://dummyjson.com/image/i/products/10/thumbnail.jpeg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 11, "A11", "https://dummyjson.com/image/i/products/11/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 12, "A12", "https://dummyjson.com/image/i/products/12/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 13, "A13", "https://dummyjson.com/image/i/products/13/thumbnail.webp" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 14, "A14", "https://dummyjson.com/image/i/products/14/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 15, "A15", "https://dummyjson.com/image/i/products/15/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 16, "A16", "https://dummyjson.com/image/i/products/16/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 17, "A17", "https://dummyjson.com/image/i/products/17/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 18, "A18", "https://dummyjson.com/image/i/products/18/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 19, "A19", "https://dummyjson.com/image/i/products/19/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 20, "A20", "https://dummyjson.com/image/i/products/20/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 21, "A21", "https://dummyjson.com/image/i/products/21/thumbnail.png" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 22, "A22", "https://dummyjson.com/image/i/products/22/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 23, "A23", "https://dummyjson.com/image/i/products/23/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 24, "A24", "https://dummyjson.com/image/i/products/24/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 25, "A25", "https://dummyjson.com/image/i/products/25/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 26, "A26", "https://dummyjson.com/image/i/products/26/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 27, "A27", "https://dummyjson.com/image/i/products/27/thumbnail.webp" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 28, "A28", "https://dummyjson.com/image/i/products/28/thumbnail.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 29, "A29", "https://dummyjson.com/image/i/products/29/thumbnail.webp" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductImageUrl" },
                values: new object[] { 30, "A30", "https://dummyjson.com/image/i/products/30/thumbnail.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
