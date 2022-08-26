using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Abstract
{
    public interface ITag_repo
    {
        List<tags> GetAllTags();
        tags GetTagId(int id);
        tags CreateCTag(tags tag);
        tags UpdateCTag(tags tag);
        void DeleteTag(int id);
        void CreateTags(tags tag);
        void DeleteTags(int id);
        void UpdateTags(tags tags);
    }
}
