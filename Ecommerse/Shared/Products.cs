using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerse.Shared
{
    public class Products
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        [Column(TypeName= "decimal(18,2)")]
        public decimal Price { get; set; }

    }
}
