using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerceExample.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "adidas niteball ecrtin,cblack,green gw1625", "https://cdn.shopify.com/s/files/1/0880/5608/products/ADIDAS-NITEBALL-ECRTIN_CBLACK_GREEN-GW1625-1_2048x2048.jpg?v=1655934391", 119.99m, "ADIDAS NITEBALL ECRTIN" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "When the adidas Forum debuted in '84, it was the first basketball sneaker of its kind. Innovative for its comfort and legendary for its style, it made waves. In fact, it's still making waves today. These shoes keep all the classic details, like the X-ankle design and padded tongue, and add a smooth leather upper with light and dark tones.", "https://cdn.shopify.com/s/files/1/0880/5608/products/ADIDAS-FORUM-84-LOW-OWHITE_CONAVY_CWHITE-GZ6427-1_2048x2048.jpg?v=1655933596", 99.99m, "ADIDAS FORUM 84 LOW" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Let your style soar. It's easy to do in these adidas Forum shoes. The newest iteration of designer Jeremy Scott's iconic winged design, the classic B-ball silhouette shows off forward-facing wings for a touch of the unexpected. The premium full-grain leather upper and recognizable ankle strap keep your look rooted in archival heritage.", "https://cdn.shopify.com/s/files/1/0880/5608/products/ADIDAS-JS-WINGS-4.0-FTWWHT_CBLACK-GX9445-1_2048x2048.jpg?v=1653402682", 7.99m, "ADIDAS JS WINGS 4.0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
