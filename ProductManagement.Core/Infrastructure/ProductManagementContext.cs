using ProductManagement.Data;

namespace ProductManagement.Core.Infrastructure
{
    public class ProductManagementContext
    {
        private ProductDemoDBEntities _entities;
        public ProductDemoDBEntities Entities
        {
            get { return _entities ?? (_entities = new ProductDemoDBEntities()); }
        }
    }
}
