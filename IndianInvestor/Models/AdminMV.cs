using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndianInvestor.Models
{
    public class AdminMV
    {
        [Key]
        public string ID { get; set; }
        [Required]

        [Display(Name ="Security Code")]
        public string SecurityCode { get; set; }
       
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Share Price")]
        public string Price { get; set; }
        [Display(Name = "Market Cap")]
        public string MarketCap { get; set; }

    }
}
