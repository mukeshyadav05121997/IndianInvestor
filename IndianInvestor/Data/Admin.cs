using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndianInvestor.Data
{
    public class Admin
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string SecurityCode { get; set; }
        [Required]
        public string CompanyName { get; set;}
        public string Price { get; set; }
        public string MarketCap { get; set; }
    }
}
