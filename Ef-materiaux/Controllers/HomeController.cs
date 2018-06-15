using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ef_materiaux.Models;

namespace Ef_materiaux.Controllers
{
    public class HomeController : Controller
    {
        private List<ProduitViewModel> produitViewModels;

        public IActionResult Index()
        {
            produitViewModels = ChargerMockProduit();
            return View();
        }

        private List<ProduitViewModel> ChargerMockProduit()
        {
          List< ProduitViewModel>  produitViewModelsCharger = new List<ProduitViewModel>();


            for(int i= 0; i<=3; i++)
            {
                ProduitViewModel produit = new ProduitViewModel();
                produit.NomProduit = "test" +i;
                produit.NumeroProduit = ""+i;
                produit.Prix = 1000.5;
                produit.Categorie = "FER";
                produit.NomImage = "FER" + i;
                produitViewModelsCharger.Add(produit);

            }

            for (int i = 0; i <= 3; i++)
            {
                ProduitViewModel produit = new ProduitViewModel();
                produit.NomProduit = "test" + i;
                produit.NumeroProduit = "" + i;
                produit.Prix = 1000.5;
                produit.Categorie = "Robinerie";
                produit.NomImage = "Robinerie" + i;
                produitViewModelsCharger.Add(produit);

            }

            for (int i = 0; i <= 3; i++)
            {
                ProduitViewModel produit = new ProduitViewModel();
                produit.NomProduit = "test" + i;
                produit.NumeroProduit = "" + i;
                produit.Prix = 1000.5;
                produit.Categorie = "Maconnnerie";
                produit.NomImage = "Maconnnerie" + i;
                produitViewModelsCharger.Add(produit);

            }
            return produitViewModelsCharger;

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Connect()
        {
           // ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Rechercher(String produit)
        {
            List<ProduitViewModel> produitTrouve = new List<ProduitViewModel>();
            if( produitViewModels != null)
            {
                foreach(ProduitViewModel produitModel in produitViewModels) {
                    if (produitModel.NomProduit.Equals(produit))
                        produitTrouve.Add(produitModel);
                }

                if (!produitTrouve.Any())
                {
                    produitTrouve.AddRange(produitViewModels);
                }
            }

            return View("Resultat");
        }

        public IActionResult ConsulterCommande()
        {
            List<CommandeViewModel> commandeViewModels = new List<CommandeViewModel>();
            CommandeViewModel commande = new CommandeViewModel();
            commande.DateCommande = new DateTime();
            commande.NumeroCommande = "11111111111";
            ProduitViewModel produit = new ProduitViewModel();
            produit.NomProduit = "test1";
            produit.NumeroProduit = "1111";
            produit.Quantite = 4;
            produit.Prix = 1000.5;
            commande.Produit = produit;
            commandeViewModels.Add(commande);
            return View(commandeViewModels);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
