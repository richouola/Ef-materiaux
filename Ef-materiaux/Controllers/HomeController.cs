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
                produit.Categorie = "Maconnerie";
                produit.NomImage = "ferbarre.jpg";
                produitViewModelsCharger.Add(produit);

            }

            for (int i = 0; i <= 3; i++)
            {
                ProduitViewModel produit = new ProduitViewModel();
                produit.NomProduit = "test" + i;
                produit.NumeroProduit = "" + i;
                produit.Prix = 1000.5;
                produit.Categorie = "Robinerie";
                produit.NomImage = "robinerie.jpg";
                produitViewModelsCharger.Add(produit);

            }

            for (int i = 0; i <= 3; i++)
            {
                ProduitViewModel produit = new ProduitViewModel();
                produit.NomProduit = "test" + i;
                produit.NumeroProduit = "" + i;
                produit.Prix = 1000.5;
                produit.Categorie = "Maconnerie";
                produit.NomImage = "maconnerie.jpg";
                produitViewModelsCharger.Add(produit);

            }

            for (int i = 0; i <= 3; i++)
            {
                ProduitViewModel produit = new ProduitViewModel();
                produit.NomProduit = "test" + i;
                produit.NumeroProduit = "" + i;
                produit.Prix = 1000.5;
                produit.Categorie = "Plomberie";
                produit.NomImage = "plomberie2.jpg";
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
            ViewData["Message"] = "";
            produitViewModels = ChargerMockProduit();
            List<ProduitViewModel> produitTrouve = new List<ProduitViewModel>();
            if( produitViewModels != null)
            {
                foreach(ProduitViewModel produitModel in produitViewModels) {
                    if (produitModel.NomProduit.Equals(produit))
                        produitTrouve.Add(produitModel);
                }

                if (!produitTrouve.Any())
                {
                    ViewData["Message"] = "Aucun produit ne correspond à votre recherche. Voici les produits disponible";
                    produitTrouve.AddRange(produitViewModels);
                }
                else
                {
                    ViewData["Message"] = "Voici les produits correspondant à votre recherche";

                }
            }

            return View("Produits", produitTrouve);
        }

        public IActionResult ConsulterCategorie(String id)
        {
            produitViewModels = ChargerMockProduit();
            List<ProduitViewModel> produitTrouve = new List<ProduitViewModel>();
            if (id == null)
            {
                produitTrouve = produitViewModels;
            }
            else
            {
                if (produitViewModels != null)
                {
                    foreach (ProduitViewModel produitModel in produitViewModels)
                    {
                        if (produitModel.Categorie.Equals(id))
                            produitTrouve.Add(produitModel);
                    }
                }
            }

            return View("Produits", produitTrouve);
        }


        public IActionResult ConsulterProduits()
        {
            produitViewModels = ChargerMockProduit();

            return View("Produits", produitViewModels);
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
