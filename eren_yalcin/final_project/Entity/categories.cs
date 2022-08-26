using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class categories
    {

        [Key]
        public int Category_id { get; set; }
        [StringLength(50)]
        public string Category_name { get; set; }

        public ICollection<products> product { get; set; }


    }
}
