using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab04.Models{
    public class City{
        public int CityId { get; set; }
        
        [Display (Name = "City Name")]
        public string CityName { get; set; }
        public int Population { get; set; }

        [Display (Name = "Province")]
        public string ProvinceCode { get; set; }
        
        [ForeignKey("ProvinceCode")]
        public Province Province { get; set; }
    }    
}
