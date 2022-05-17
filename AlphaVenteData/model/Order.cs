using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVenteData.model
{
    public  class Order
    {
        public int Id { get; set; }
        public long OrderNumber { get; set; }
        public DateOnly OrderDate { get; set; }
        public Double TotalHT { get; set; }
        public Double TotalTTC { get; set; }
        public Boolean Confirmed { get; set; }
        public DateOnly ConfirmedDate { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

    }
}
