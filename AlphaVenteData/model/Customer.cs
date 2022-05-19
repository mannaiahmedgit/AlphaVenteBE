using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVenteData.model
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(6,MinimumLength =6)]
        public string? codeClient { get; set; }
        [Required]
        public string? FullName { get; set; }
        public string? adress { get; set; }
        [Required]
        [EmailAddress]
        public string? email { get; set; }
        [Required]
        public string? userName { get; set; }
        [Required]
        public string? password { get; set; }
        
    }
}
