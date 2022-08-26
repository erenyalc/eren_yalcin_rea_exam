using data_access.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.concrate
{
    public class Product_repo : IProduct_repo
    {
        public products CreateCProduct(products _product)
        {
            using (var productContextDb = new Context())
            {
                productContextDb.products.Add(_product);
                productContextDb.SaveChanges();
                return _product;
            }
        }

        public void CreateProduct(products product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            using (var productContextDb = new Context())
            {
                var delete_prod = GetProductId(id);
                productContextDb.products.Remove(delete_prod);
                productContextDb.SaveChanges();
            }
        }

        public List<products> GetAllProducts()
        {
            using (var prodDbContext = new Context())
            {
                return prodDbContext.products.ToList();
            }
        }

        public products GetProductId(int id)
        {
            using (var prodDbContext = new Context())
            {
                return prodDbContext.products.Find(id);
            }
        }

        public products UpdateCProduct(products product)
        {
            using (var prodDbContext = new Context())
            {
                prodDbContext.products.Update(product);
                prodDbContext.SaveChanges();
                return product;
            }
        }

        public void UpdateProduct(products products)
        {
            throw new NotImplementedException();
        }
    }
}
