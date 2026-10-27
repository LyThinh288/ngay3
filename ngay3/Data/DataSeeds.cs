namespace ngay3.Data
{
    public class DataSeeds
    {
        public static List<Models.Product> products = new List<Models.Product>()
        {
            new Models.Product(){Id=1, Name="Laptop Dell", Price=1000, CategoryId=1},
            new Models.Product(){Id=2, Name="Laptop HP", Price=1200, CategoryId=1},
            new Models.Product(){Id=3, Name="Phone Samsung", Price=800, CategoryId=2},
            new Models.Product(){Id=4, Name="Phone Iphone", Price=1500, CategoryId=2},
            new Models.Product(){Id=5, Name="Tablet Samsung", Price=600, CategoryId=3},
            new Models.Product(){Id=6, Name="Tablet Apple", Price=900, CategoryId=3},
        };
        public static List<Models.Category> categories = new List<Models.Category>()
        {
            new Models.Category(){Id=1, Name="Laptop"},
            new Models.Category(){Id=2, Name="Phone"},
            new Models.Category(){Id=3, Name="Tablet"},
        };
    }
}
