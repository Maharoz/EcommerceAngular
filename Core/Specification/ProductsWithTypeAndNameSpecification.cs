using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specification
{
    public class ProductsWithTypeAndNameSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypeAndNameSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}
