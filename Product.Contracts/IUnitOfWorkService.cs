using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Contracts
{
    public interface IUnitOfWorkService : IDisposable
    {
        ICategoryService Categories { get; }
        IProductService Products { get; }
        IUserService Users { get; }
        int Complete();
    }
}
