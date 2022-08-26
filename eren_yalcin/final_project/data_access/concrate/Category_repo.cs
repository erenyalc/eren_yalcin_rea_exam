using data_access.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.concrate
{
    public class Category_repo : ICategory_repo
    {
        public categories CreateCategory(categories _category)
        {
            using (var categoryContextDb = new Context())
            {
                categoryContextDb.categories.Add(_category);
                categoryContextDb.SaveChanges();
                return _category;
            }
        }

        public void DeleteCategories(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            using (var categoryContextDb = new Context())
            {
                var delete_categ = GetCategoryId(id);
                categoryContextDb.categories.Remove(delete_categ);
                categoryContextDb.SaveChanges();
            }
        }

        public List<categories> GetAllCategories()
        {
            using (var cateDbContext = new Context())
            {
                return cateDbContext.categories.ToList();
            }
        }

        public categories GetCategoryId(int id)
        {
            using (var cateDbContext = new Context())
            {
                return cateDbContext.categories.Find(id);
            }
        }

        public void UpdateCategories(categories categories)
        {
            throw new NotImplementedException();
        }

        public categories UpdateCategory(categories category)
        {
            using (var cateDbContext = new Context())
            {
                cateDbContext.categories.Update(category);
                cateDbContext.SaveChanges();
                return category;
            }
        }
    }
}
