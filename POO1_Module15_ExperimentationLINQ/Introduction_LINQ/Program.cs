using ExperimentationsLINQ;

namespace Introduction_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ObtenirElement01_SyntaxeRequete_v01();
            //ObtenirELement01_SyntaxeMethode_v01();
            //ObtenirElement01_SyntaxeRequete_v02();
            //ObtenirElement01_SyntaxeRequete_v02Bis();
            //ObtenirElement01_SyntaxeMethode_v02Bis();
            //ObtenirElement01_SyntaxeMethode_v02();
            //ObtenirListeNomsProduits_SyntaxeRequete_v01();
            //ObtenirListeNomsProduits_SyntaxeMethode_v01();
            //ObtenirListeCategories_SyntaxeRequete_v01();
            //ObtenirListeCategories_SyntaxeMethode_v01();
            //ObtenirListeCategories_SyntaxeRequete_v02();
            //ObtenirListeCategories_SyntaxeMethode_v02();
            //ObtenirListeNomsProduitsOrdonnee_SyntaxeRequete_v01();
            //ObtenirListeNomsProduitsOrdonnee_SyntaxeMethode_v01();
            ObtenirListeCategoriesOrdonnee_SyntaxeRequete_v01();
            ObtenirListeCategoriesOrdonnee_SyntaxeMethode_v01();
        }

        /*****************             Filtrer une collection          ***********/
        /********* element unique  ***********/
        /*******  requête   ********/
        private static void ObtenirElement01_SyntaxeRequete_v01()
        {
         var produits = DonneesLINQ.CreateProductList();
         var resultat = from produit in produits
                        where produit.ProductID == 12
                        select produit;
         ObjectDumper.Write(resultat);
        }

        /**********   methode   *******/
        private static void ObtenirELement01_SyntaxeMethode_v01()
        {
         var produits = DonneesLINQ.CreateProductList();
         var resultat = produits.Where(p => p.ProductID == 12);

         ObjectDumper.Write(resultat);
        }

        /*******  requête   ********/
        private static void ObtenirElement01_SyntaxeRequete_v02()
        {
         var produits = DonneesLINQ.CreateProductList();
         var resultat = (from produit in produits
                         where produit.ProductID == 12
                         select produit).Single();

         ObjectDumper.Write(resultat);
        }

        private static void ObtenirElement01_SyntaxeRequete_v02Bis()
        {
            var produits = DonneesLINQ.CreateProductList();
            var resultat = (from produit in produits
                            where produit.ProductID == 12
                            select produit).SingleOrDefault();

            ObjectDumper.Write(resultat);
        }

        /**********   methode   *******/
        private static void ObtenirElement01_SyntaxeMethode_v02()
        {
            var produits = DonneesLINQ.CreateProductList();
            var resultat = produits.Where(p => p.ProductID == 12).SingleOrDefault();

            ObjectDumper.Write(resultat);
        }

        /*******  methode   ********/
        private static void ObtenirElement01_SyntaxeMethode_v02Bis()
        {
         var produits = DonneesLINQ.CreateProductList();
         var resultat = produits.Where(p => p.ProductID == 12).Single();

         ObjectDumper.Write(resultat);
        }

        /**************  afficher produit  **************/
                
        private static void ObtenirListeNomsProduits_SyntaxeRequete_v01()
        {
            var Produits = DonneesLINQ.CreateProductList();
            var categories = from produit in Produits
                             select produit.ProductName;

            ObjectDumper.Write(categories);
        }

        private static void ObtenirListeNomsProduits_SyntaxeMethode_v01()
        {
            var produits = DonneesLINQ.CreateProductList();
            var categories = produits.Select(p => p.ProductName);

            ObjectDumper.Write(categories);
        }

        /*********************  afficher categories   *****************/

        private static void ObtenirListeCategories_SyntaxeRequete_v01()
        {
            var Produits = DonneesLINQ.CreateProductList();
            var categories = from produit in Produits
                             select produit.Category;

            ObjectDumper.Write(categories);
        }

        private static void ObtenirListeCategories_SyntaxeMethode_v01()
        {
            var Produits = DonneesLINQ.CreateProductList();
            var categories = Produits.Select(p  =>  p.Category);

            ObjectDumper.Write(categories);
        }

        //la methode et la requete au dessus retourne des doublons.

        private static void ObtenirListeCategories_SyntaxeRequete_v02()
        {
            var produits = DonneesLINQ.CreateProductList();
            var categories = (from produit in produits
                              select produit.Category).Distinct();

            ObjectDumper.Write(categories);
        }

        private static void ObtenirListeCategories_SyntaxeMethode_v02()
        {
            var produits = DonneesLINQ.CreateProductList();
            var categories = produits.Select(p => p.Category).Distinct();

            ObjectDumper.Write(categories);
        }

        //la methode et la requete du dessus retourne les categories en supprimant les doublons.

        /*****************    TRI     *****************/

        private static void ObtenirListeNomsProduitsOrdonnee_SyntaxeRequete_v01()
        {
            var produits = DonneesLINQ.CreateProductList();
            var names = from produit in produits
                             orderby produit.ProductName
                             select produit.ProductName;

            ObjectDumper.Write(names);
        }

        private static void ObtenirListeNomsProduitsOrdonnee_SyntaxeMethode_v01()
        {
            var produits = DonneesLINQ.CreateProductList();
            //var names = produits.OrderBy(p => p.ProductName).Select(p => p.ProductName);
            var names2 = produits.Select (p => p.ProductName).OrderBy (c => c);

            ObjectDumper.Write(names2);
        }

        private static void ObtenirListeCategoriesOrdonnee_SyntaxeRequete_v01()
        {
            var produits = DonneesLINQ.CreateProductList();
            var categories = from produit in produits
                             orderby produit.Category
                             select produit.Category;
            ObjectDumper.Write(categories);
        }

        private static void ObtenirListeCategoriesOrdonnee_SyntaxeMethode_v01()
        {
            var produits = DonneesLINQ.CreateProductList();
            var categories = produits.OrderBy(p => p.Category).Select(p => p.Category).Distinct(); 

            ObjectDumper.Write(categories);
        }
    }
}