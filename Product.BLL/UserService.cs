

using Product.Contracts;
using Product.Data;

namespace ProductApp.BLL
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(ProductsContext context) : base(context)
        {
        }
    }
}
