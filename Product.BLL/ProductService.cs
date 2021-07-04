using Product.Contracts;
using Product.Data;


namespace ProductApp.BLL
{
    public class ProductService : GenericService<Productt>, IProductService
    {
        public ProductService(ProductsContext context) : base(context)
        {
        }
    }
}
