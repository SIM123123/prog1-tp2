using System;
using static System.Console;
using static Utilitaires.Util;
using static tp2.Produit;
using System.Collections.Generic;
using System.Linq;

namespace TP2
{
    class Program
    {


        public static void AfficherMenuPrincipal()
        {
            WriteLine(" Machine distributrice");
            WriteLine("*** MENU PRINCIPAL *** ");
            WriteLine(" 1. Produits");
            WriteLine(" 2. Remplissage");
            WriteLine(" 3. Achat");
            WriteLine(" 4. Rapport des ventes");
            WriteLine(" 0. Quitter le programme.");
            int choix = LireInt32DansIntervalleOuSentinelle(" Votre choix :", 1, 4, 0);

            switch (choix)
            {
                case 1:
                    AfficherOptionProduit();
                    break;
            }
        }



        static void Main(string[] args)
        {
            string[] listeCodes = new string[1000];
            string[] listeNoms = new string[1000];
            string[] listeCatégories = new string[1000];
            double[] listePrix = new double [1000];
           

            AfficherMenuPrincipal();
            Clear();
            while (true)
            {
                
                ObtenirListeCode(listeCodes,  listeNoms,  listeCatégories,  listePrix);


                
            }
        }
    }
}
