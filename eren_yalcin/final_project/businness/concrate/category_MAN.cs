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
    public class category_MAN : ICategory_service
    {
        private ICategory_repo _catDAL;

        public category_MAN()
        {
            _catDAL = new Category_repo();
        }
        public categories CreateCategory(categories _category)
        {
            return _catDAL.CreateCategory(_category);
        }

        public void DeleteCategory(int id)
        {
            _catDAL.DeleteCategory(id);
        }

        public List<categories> GetCategories()
        {
            return _catDAL.GetAllCategories();
        }

        public categories GetCategoriesById(int id)
        {
            if (id > 0)
            {
                return _catDAL.GetCategoryId(id);
            }
            throw new Exception("ID CANNOT BE BELOW 1");
        }

        public categories UpdateCategory(categories _category)
        {
            return _catDAL.UpdateCategory(_category);
        }
    }
}
