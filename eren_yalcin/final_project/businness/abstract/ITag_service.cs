using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businness.Abstract
{
    public interface ITag_service
{
    List<tags> GetTags();
    tags GetTagsById(int id);
    tags CreateTags(tags _tag);
    tags UpdateTags(tags _tag);
    void DeleteTags(int id);
}
}
