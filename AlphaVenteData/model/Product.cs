using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVenteData.model
{
    public class Product
    {
        public int Id { get; set; }
        public string? Designation { get; set; }
        public String? RefAlphaProduit { get; set; }
        public Double Price { get; set; }
        [ForeignKey("SubCategoryId")]
        public int SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
        public List<ProductImage>? ProductImages { get; set; }

    }
}
