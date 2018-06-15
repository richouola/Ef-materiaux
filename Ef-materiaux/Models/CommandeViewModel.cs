using Ef_materiaux.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ef_materiaux.Models
{
    public class CommandeViewModel
    {
        public String NumeroCommande { get; set; }

        public DateTime DateCommande { get; set; }

        public ProduitViewModel Produit { get; set; }
    }
}
