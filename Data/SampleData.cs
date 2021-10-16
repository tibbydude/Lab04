
using System.Collections.Generic;
using lab04.Models;

namespace lab04.Data{
    public class SampleData{
        public static List<Province> GetProvinces(){
            List<Province> provinces = new List<Province>(){
                new Province() {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia"
                },
                new Province() {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"
                },
                new Province() {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario"
                }
            };

            return provinces;
        }   

        public static List<City> GetCities(){
            List<City> cities = new List<City>(){
                new City(){
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 675218,
                    ProvinceCode = "BC"
                },
                new City(){
                    CityId = 2,
                    CityName = "Burnaby",
                    Population = 249197,
                    ProvinceCode = "BC"
                },
                new City(){
                    CityId = 3,
                    CityName = "Kelowna",
                    Population = 132084,
                    ProvinceCode = "BC"
                },
                new City(){
                    CityId = 4,
                    CityName = "Edmonton",
                    Population = 981280,
                    ProvinceCode = "AB"
                },
                new City(){
                    CityId = 5,
                    CityName = "Calgary",
                    Population = 133600,
                    ProvinceCode = "AB"
                },
                new City(){
                    CityId = 6,
                    CityName = "Canmmore",
                    Population = 13992,
                    ProvinceCode = "AB"
                },
                new City(){
                    CityId = 7,
                    CityName = "Toronto",
                    Population = 2930000,
                    ProvinceCode = "ON"
                },
                new City(){
                    CityId = 8,
                    CityName = "Missasauga",
                    Population = 828854,
                    ProvinceCode = "ON"
                },
                new City(){
                    CityId = 9,
                    CityName = "Brampton",
                    Population = 603346,
                    ProvinceCode = "ON"
                },
            };

            return cities;   
        }
    }
}