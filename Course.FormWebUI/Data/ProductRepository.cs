using Course.FormWebUI.Models;

namespace Course.FormWebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product() {Id=1, Name="Macera",Description="",Price=140,IsApproved=true},
                new Product() {Id=2, Name="Romantik",Description="",Price=130,IsApproved=true},
                new Product() {Id=3, Name="Bilim Kurgu",Description="",Price=200},
                new Product() {Id=4, Name="Savaş",Description="",Price=100,IsApproved=true},
                new Product() {Id=5, Name="Komedi",Description="",Price=160}
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void RemoveProduct(Product entity)
        {
            _products.Remove(entity);
        }

        public static Product GetById(int id)
        {
            return _products.FirstOrDefault(i => i.Id == id);
        }


    }
}