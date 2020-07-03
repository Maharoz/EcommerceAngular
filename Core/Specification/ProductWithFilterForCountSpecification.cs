using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specification
{
    public class ProductWithFilterForCountSpecification:BaseSpecification<Product>
    {
        public ProductWithFilterForCountSpecification(ProductSpecParams
            productParams) : base(x =>
             (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
             (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId))
        { 
        }
    }
}
