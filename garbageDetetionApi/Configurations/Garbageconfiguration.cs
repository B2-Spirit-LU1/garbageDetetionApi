using garbageDetetionApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LitterLinq.Configurations
{
    public class LitterConfiguration : IEntityTypeConfiguration<Garbage>
    {
        public void Configure(EntityTypeBuilder<Garbage> builder)
        {
            builder.ToTable("Garbages");
            builder.HasData(
                new Garbage
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    DetectedObject = "Plastic Bottle",
                    PhotoName = "Image 1",
                    ConfidenceScore = 0.95m,
                    Weather = "Sunny",
                    Temp = 22.5m,
                    Humidity = 45.0m,
                    WindSpeed = 5.2m,
                    TimeStamp = new DateTime(2025, 5, 15, 10, 0, 0)
                },
                new Garbage
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    DetectedObject = "Can",
                    PhotoName = "Image 2",
                    ConfidenceScore = 0.89m,
                    Weather = "Cloudy",
                    Temp = 18.3m,
                    Humidity = 55.0m,
                    WindSpeed = 3.8m,
                    TimeStamp = new DateTime(2025, 5, 15, 11, 0, 0)
                },
                new Garbage
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    DetectedObject = "Paper",
                    PhotoName = "Image 3",
                    ConfidenceScore = 0.92m,
                    Weather = "Rainy",
                    Temp = 16.0m,
                    Humidity = 80.0m,
                    WindSpeed = 7.1m,
                    TimeStamp = new DateTime(2025, 5, 15, 12, 0, 0)
                },
                new Garbage
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    DetectedObject = "Glass",
                    PhotoName = "Image 4",
                    ConfidenceScore = 0.88m,
                    Weather = "Windy",
                    Temp = 20.0m,
                    Humidity = 50.0m,
                    WindSpeed = 12.0m,
                    TimeStamp = new DateTime(2025, 5, 15, 13, 0, 0)
                },
                new Garbage
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    DetectedObject = "Food Wrapper",
                    PhotoName = "Image 5",
                    ConfidenceScore = 0.90m,
                    Weather = "Sunny",
                    Temp = 24.0m,
                    Humidity = 40.0m,
                    WindSpeed = 4.5m,
                    TimeStamp = new DateTime(2025, 5, 15, 14, 0, 0)
                }
            );
        }
    }
}
