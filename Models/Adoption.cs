namespace RedSocialDeGatos.Models
{
    public class Adoption
    {
        public int Id { get; set; }
        public int CatId { get; set; }
        public Cat Cat { get; set; } // Relación con el modelo Cat
        public DateTime DatePosted { get; set; }
        public string ContactInfo { get; set; }
        public string AdoptionStatus { get; set; } // Ej: "Available", "Adopted"
    }
}
