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
    public class tag_MAN : ITag_service
    {
        private ITag_repo _tagDAL;
        public tag_MAN()
        {
            _tagDAL = new Tag_repo();
        }
        public tags CreateTags(tags _tag)
        {
            return _tagDAL.CreateTags(_tag);
        }

        public void DeleteTags(int id)
        {
            _tagDAL.DeleteTags(id);
        }

        public List<tags> GetTags()
        {
            return _tagDAL.GetTags();
        }

        public tags GetTagsById(int id)
        {
            if (id > 0)
            {
                return _tagDAL.GetTagsById(id);
            }
            throw new Exception("ID CANNOT BE BELOW 1");
        }

        public tags UpdateTags(tags _tag)
        {
            return _tagDAL.UpdateTags(_tag);
        }
    }
}
