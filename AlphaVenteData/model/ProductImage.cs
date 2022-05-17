using System.ComponentModel.DataAnnotations.Schema;

namespace AlphaVenteData.model
{
    public class ProductImage { 
        public Guid Id { get; set; }
        public string? Url { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }


    }
}