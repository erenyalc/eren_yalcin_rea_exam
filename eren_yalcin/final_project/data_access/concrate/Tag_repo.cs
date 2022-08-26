using data_access.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.concrate
{
    public class Tag_repo : ITag_repo
    {
        public tags CreateCTag(tags _tag)
        {
            using (var tagContextDb = new Context())
            {
                tagContextDb.tags.Add(_tag);
                tagContextDb.SaveChanges();
                return _tag;
            }
        }

        public void CreateTags(tags tag)
        {
            throw new NotImplementedException();
        }

        public void DeleteTag(int id)
        {
            using (var tagContextDb = new Context())
            {
                var delete_tag = GetTagId(id);
                tagContextDb.tags.Remove(delete_tag);
                tagContextDb.SaveChanges();
            }
        }

        public void DeleteTags(int id)
        {
            throw new NotImplementedException();
        }

        public List<tags> GetAllTags()
        {
            using (var tagDbContext = new Context())
            {
                return tagDbContext.tags.ToList();
            }
        }

        public tags GetTagId(int id)
        {
            using (var tagDbContext = new Context())
            {
                return tagDbContext.tags.Find(id);
            }
        }

        public tags UpdateCTag(tags tag)
        {
            using (var tagDbContext = new Context())
            {
                tagDbContext.tags.Update(tag);
                tagDbContext.SaveChanges();
                return tag;
            }
        }

        public void UpdateTags(tags tags)
        {
            throw new NotImplementedException();
        }
    }
}
