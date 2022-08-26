using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class tags_products
    {
        [Key]
        public int Tag_product_id { get; set; }
        //Tags
        public tags Tags { get; set; }
        public int Tag_id { get; set; }
        //Products
        public products Product { get; set; }
        public int Product_id { get; set; }
    }
}
