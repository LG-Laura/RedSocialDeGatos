namespace RedSocialDeGatos.Models
{
    public class LostCat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateReported { get; set; }
        public string LastSeenLocation { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ContactInfo { get; set; }
    }
}
