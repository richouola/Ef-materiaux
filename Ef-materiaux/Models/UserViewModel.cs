using System;

namespace Ef_materiaux.Models
{
    public class UserViewModel
    {
        public String Identifant { get; set; }

        public String MotDePasse { get; set; }

        public String Nom { get; set; }

        public String Prenom { get; set; }

        public String Adresse { get; set; }
    }
}