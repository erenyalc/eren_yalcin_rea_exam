using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Abstract
{
    public interface ICategory_repo
    {
        List<categories> GetAllCategories();
        categories GetCategoryId(int id);
        categories CreateCategory(categories category);
        categories UpdateCategory(categories category);
        void DeleteCategory(int id);
        void DeleteCategories(int id);
        void UpdateCategories(categories categories);
    }
}
