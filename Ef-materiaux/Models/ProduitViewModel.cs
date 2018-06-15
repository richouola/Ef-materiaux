using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ef_materiaux.Models
{

    public class ProduitViewModel
    {
        public String NumeroProduit { get; set; }

        public String NomProduit { get; set; }

        public int Quantite { get; set; }

        public double Prix { get; set; }

        public String Categorie { get; set; }

        public String NomImage { get; set; }
    }
}
