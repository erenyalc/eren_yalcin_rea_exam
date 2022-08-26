using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class tags
    {
        [Key]
        public int Tag_id { get; set; }
        public int Tag_name { get; set; }
        public IEnumerable<tags_products> tagsProducts { get; set; }
    }
}
