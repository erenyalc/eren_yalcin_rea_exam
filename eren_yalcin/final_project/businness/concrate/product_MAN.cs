using businness.Abstract;
using data_access.Abstract;
using data_access.concrate;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businness.concrate
{
    public class product_MAN : IProduct_service
    {
        private IProduct_repo _proDAL;

        public product_MAN()
        {
            _proDAL = new Product_repo();
        }
        public products CreateProducts(products _product)
        {
            return _proDAL.CreateCProduct(_product);
        }

        public void DeleteProducts(int id)
        {
            _proDAL.DeleteProduct(id);
        }

        public List<products> GetProducts()
        {
            return _proDAL.GetAllProducts();
        }

        public products GetProductsById(int id)
        {
            if (id > 0)
            {
                return _proDAL.GetProductId(id);
            }
            throw new Exception("ID CANNOT BE BELOW 1");
        }

        public products UpdateProducts(products _product)
        {
            return _proDAL.UpdateProduct(_product);
        }
    }
}
