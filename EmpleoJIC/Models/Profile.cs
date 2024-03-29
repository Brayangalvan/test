﻿namespace EmpleoJIC.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("IdProfile")]
        public ICollection<PraticalOffers> PraticalOffers { get; set; }
    }
}