using Product.Data;
using Product.Contracts;

namespace ProductApp.BLL
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly ProductsContext _context;
        public UnitOfWorkService(ProductsContext context)
        {
            _context = context;
            Categories = new CategoryService(_context);
            Products = new ProductService(_context);
            Users = new UserService(_context);

        }
        public ICategoryService Categories { get; private set; }
        public IProductService Products { get; private set; }
        public IUserService Users { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
