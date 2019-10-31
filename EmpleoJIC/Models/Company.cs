namespace EmpleoJIC.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }

        public int IdUser { get; set; }
        public User User { get; set; }

        [ForeignKey("IdCompany")]
        public ICollection<PraticalOffers> PraticalOffers { get; set; }
    }
}