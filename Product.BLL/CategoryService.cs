using Product.Contracts;
using Product.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.BLL
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(ProductsContext context) : base(context)
        {
        }
    }
}
