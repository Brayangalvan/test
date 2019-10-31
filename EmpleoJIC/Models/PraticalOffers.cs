namespace EmpleoJIC.Models
{
    public class PraticalOffers
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int IdCompany { get; set; }
        public Company Company { get; set; }

        public int IdProfile { get; set; }
        public Profile Profile { get; set; }
    }
}