using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lab04.Models{
    public class Province{
        [Key]
        public string ProvinceCode { get; set; }
        
        [Display (Name = "Province")]
        public string ProvinceName { get; set; }

        public List<City> Cities { get; set; }
    }
}
