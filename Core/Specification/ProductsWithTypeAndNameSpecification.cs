using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Core.Specification
{
    public class ProductsWithTypeAndNameSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypeAndNameSpecification(ProductSpecParams productParams)
            :base(x=>
            (!productParams.BrandId.HasValue|| x.ProductBrandId == productParams.BrandId) && 
            (!productParams.TypeId.HasValue||x.ProductTypeId== productParams.TypeId))
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1),productParams.PageSize);
            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDesc(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }

        public ProductsWithTypeAndNameSpecification(int id):base(x=>x.Id==id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}
