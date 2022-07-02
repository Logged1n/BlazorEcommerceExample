namespace BlazorEcommerceExample.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "ADIDAS NITEBALL ECRTIN",
                    Description = "ADIDAS NITEBALL ECRTIN,CBLACK,GREEN GW1625".ToLower(),
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0880/5608/products/ADIDAS-NITEBALL-ECRTIN_CBLACK_GREEN-GW1625-1_2048x2048.jpg?v=1655934391",
                    Price = 119.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "ADIDAS FORUM 84 LOW",
                    Description = "When the adidas Forum debuted in '84, it was the first basketball sneaker of its kind. Innovative for its comfort and legendary for its style, it made waves. In fact, it's still making waves today. These shoes keep all the classic details, like the X-ankle design and padded tongue, and add a smooth leather upper with light and dark tones.",
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0880/5608/products/ADIDAS-FORUM-84-LOW-OWHITE_CONAVY_CWHITE-GZ6427-1_2048x2048.jpg?v=1655933596",
                    Price = 99.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "ADIDAS JS WINGS 4.0",
                    Description = "Let your style soar. It's easy to do in these adidas Forum shoes. The newest iteration of designer Jeremy Scott's iconic winged design, the classic B-ball silhouette shows off forward-facing wings for a touch of the unexpected. The premium full-grain leather upper and recognizable ankle strap keep your look rooted in archival heritage.",
                    ImageUrl = "https://cdn.shopify.com/s/files/1/0880/5608/products/ADIDAS-JS-WINGS-4.0-FTWWHT_CBLACK-GX9445-1_2048x2048.jpg?v=1653402682",
                    Price = 7.99m
                }
            );
        }
        public DbSet<Product> Products { get; set; }
    }
}
