using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVenteData.model
{
    public  class SubCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [ForeignKey("TvaId")]
        public int TvaId { get; set; }
        public Tva? Tva { get; set; }

    }
}
