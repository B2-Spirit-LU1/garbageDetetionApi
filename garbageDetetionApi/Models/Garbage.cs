namespace garbageDetetionApi.Models
{
    public class Garbage
    {
        public Guid Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string DetectedObject { get; set; }
        public string PhotoName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public decimal ConfidenceScore { get; set; }
         
        public string? Weather { get; set; }
        public decimal? Temp { get; set; }
        public decimal? Humidity { get; set; }
        public decimal? WindSpeed { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
