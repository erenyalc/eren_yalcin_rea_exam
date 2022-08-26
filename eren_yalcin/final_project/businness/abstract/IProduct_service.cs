using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businness.Abstract
{
    public interface IProduct_service
    {
        List<products> GetProducts();
        products GetProductsById(int id);
        products CreateProducts(products _product);
        products UpdateProducts(products _product);
        void DeleteProducts(int id);
    }
}
