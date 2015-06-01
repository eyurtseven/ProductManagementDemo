using System.Collections.ObjectModel;
using ProductManagement.Data;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var entities = new ProductDemoDBEntities();

            var category = new Category {Name = "Telefon"};

            var product1 = new Product
            {
                Name = "IPhone 6",
                Price = 2000,
                ProductFeature =
                    new Collection<ProductFeature>
                    {
                        new ProductFeature() {FeatureName = "Ağırlık", FeatureValue = "150 gr"},
                        new ProductFeature() {FeatureName = "Pil", FeatureValue = "2000 mA"}
                    }
            };

            var product2 = new Product
            {
                Name = "Galaxy Edge",
                Price = 1800,
                ProductFeature =
                    new Collection<ProductFeature>
                    {
                        new ProductFeature() {FeatureName = "Ağırlık", FeatureValue = "120 gr"},
                        new ProductFeature() {FeatureName = "Pil", FeatureValue = "2200 mA"}
                    }
            };

            category.Product = new Collection<Product>();
            category.Product.Add(product1);
            category.Product.Add(product2);

            entities.Category.Add(category);


            entities.SaveChanges();

        }
    }
}
