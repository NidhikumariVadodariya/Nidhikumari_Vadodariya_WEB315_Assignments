using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EnvironmentalChanges.Data;
using System;
using System.Linq;

namespace EnvironmentalChanges.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EnvironmentalChangesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EnvironmentalChangesContext>>()))
            {
                // Look for any types of weath.
                if (context.EChange.Any())
                {
                    return;   // DB has been seeded
                }

                context.EChange.AddRange(
                    new EChange
                    {
                        TypesOfWeather = "Summer",
                        WeatherTiming = DateTime.Parse("2021-6-20"),
                        FoodInWeather = "Watermalon",
                        WeatherGarments = "Light Weight"
                    },
                    
                    new EChange
                    {
                        TypesOfWeather = "Spring",
                        WeatherTiming = DateTime.Parse("2021-3-20"),
                        FoodInWeather = "Mango",
                        WeatherGarments = "Colorful Western"
                    },

                    new EChange
                    {
                        TypesOfWeather = "Rainy ",
                        WeatherTiming = DateTime.Parse("2021-12-22"),
                        FoodInWeather = "Strawberry",
                        WeatherGarments = "RainCoat"
                    },

                    new EChange
                    {
                        TypesOfWeather = "Winter",
                        WeatherTiming = DateTime.Parse("2021-8-15"),
                        FoodInWeather = "Kiwi",
                        WeatherGarments = "Warm Clothes"
                    },

                    new EChange
                    {
                        TypesOfWeather = "Snowy",
                        WeatherTiming = DateTime.Parse("2021-10-17"),
                        FoodInWeather = "Western",
                        WeatherGarments = "Pomgranate"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}