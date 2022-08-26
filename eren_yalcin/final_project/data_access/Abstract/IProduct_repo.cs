using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Abstract
{
    public interface IProduct_repo
    {
        List<products> GetAllProducts();
        products GetProductId(int id);
        products CreateCProduct(products product);
        products UpdateCProduct(products product);
        void DeleteProduct(int id);
        void UpdateProduct(products products);
        void CreateProduct(products product);
    }
}
