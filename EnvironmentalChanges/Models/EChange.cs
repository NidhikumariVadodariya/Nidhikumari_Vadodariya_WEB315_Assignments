using System;
using System.ComponentModel.DataAnnotations;

namespace EnvironmentalChanges.Models
{
    public class EChange
    {
        public int ID { get; set; }
        public string TypesOfWeather { get; set; }

        [DataType(DataType.Date)]
        public DateTime WeatherTiming { get; set; }
        public string FoodInWeather { get; set; }

        public string WeatherGarments { get; set; }
    }
}