using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businness.Abstract
{
    public interface ICategory_service
    {
    List<categories> GetCategories();
    categories GetCategoriesById(int id);
    categories CreateCategory(categories _category);
    categories UpdateCategory(categories _category);
    void DeleteCategory(int id);
}
}
