using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class products
    {

        [Key]
        public int Product_id { get; set; }
        [StringLength(50)]
        public string Product_name { get; set; }

        public int Quantity { get; set; }
        public string Create_date { get; set; }
        public int Price { get; set; }

        public virtual categories Categories { get; set; }
        public IEnumerable<tags_products> tagsProducts { get; set; }



    }

}
