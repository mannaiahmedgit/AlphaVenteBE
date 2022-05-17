using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVenteData.model
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public Double Qte { get; set; }
        public Double PriceHt { get; set; }
        public Double PriceTTC { get; set; }
        public Double TotalRowHT { get; set; }
        public Double TotalRowTTC { get; set; }
        public String Tva { get; set; }
        public Double MountTvaU { get; set; }
        public Double TotalRowTva { get; set; }
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
