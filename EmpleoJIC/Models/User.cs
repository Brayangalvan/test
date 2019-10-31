using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmpleoJIC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        [ForeignKey("IdUser")]
        public ICollection<Company> Company { get; set; }
    }
}