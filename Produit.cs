using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utilitaires.Util;
using static System.Console;

namespace tp2
{
    class Produit
    {
        public static int Nombres(string[] tableau)
        {
            int cpt = 0;
            for (int i = 0; i < tableau.Length; ++i)
            {
                if (tableau[i] != null)
                {
                    cpt++;
                }

            }

            return cpt;
        }
        /// <summary>
        /// Cette méthode est pour afficher une liste des produits
        /// </summary>
        /// <param name="listeCode"></param>
        /// <param name="listeNom"></param>
        /// <param name="listeCatégorie"></param>
        /// <param name="listePrix"></param>

        public static void AfficherListeDesProduit(string[] listeNom, int cpt, string[] listeCode)
        {

            bool afficherB = false;
            for (int j = 0; j < listeNom.Length; j += 2)
            {
                if (!(listeNom[j] == null))
                {
                    afficherB = false;

                    if ((j + 1) < listeNom.Length)
                    {
                        if (!(listeNom[j + 1] == null))
                        {
                            afficherB = true;
                        }

                    }

                    if (listeNom[j] != null)
                    {
                        if (afficherB)
                        {
                            WriteLine("|{0,10} : {1,-2}|{2,10} : {3,-2}|", listeNom[j], listeCode[j], listeNom[j + 1], listeCode[j + 1]);
                        }
                        else
                        {
                            WriteLine("|{0,10} : {1,-2}|{2,10} : {3,-2}|", listeNom[j], listeCode[j], "", "");
                        }


                    }

                }

            }

        }
        public static void AfficherOptionProduit()
        {
            AfficherListeProduits();
        }
        public static void AfficherListeProduits()
        {

        }

        /// <summary>
        /// Cette méthode permet de modifier, avoir les infos ou ajouter un code de produit à la liste des codes de produit.
        /// </summary>
        /// <param name="listeCode"></param>
        /// <param name="listeNom"></param>
        /// <returns></returns>
        public static string[] ObtenirListeCode(string[] listeCode, string[] listeNom, string[] listeCatégorie, double[] listePrix)
        {
            int cpt = Nombres(listeNom);

            WriteLine("        NOM : CODE      NOM : CODE");
            AfficherListeDesProduit(listeNom, cpt, listeCode);




            WriteLine("\n");


            string code = LireStringNonVide("Veuillez indiquer le code du produit, ou sinon écrire un nouveau code pour un nouveau produit : ");
            bool codeExiste = false;


            for (int c = 0; c < cpt; c++)
            {



                if (code == listeCode[c])
                {
                    codeExiste = true;
                    break;


                }
                else
                {
                    codeExiste = false;

                }

            }
            Clear();

            if (codeExiste == false)
            {

                listeCode[cpt] = code;
                ObtenirListeNom(listeNom, cpt);
                ObtenirListeCatégorie(listeCatégorie, cpt);
                ObtenirListePrix(listePrix, cpt);
            }

            else
            {
                int l = 0;
                for (; ; )
                {

                    if (code == listeCode[l])
                    {
                        code = listeCode[l];
                        break;
                    }

                    l++;

                }




                WriteLine("Les informations sur le produit : {0}", code);
                WriteLine("Nom                             : {0}", listeNom[l]);
                WriteLine("Catégorie                       : {0}", listeCatégorie[l]);
                WriteLine("Prix                            : {0:C1}", listePrix[l]);
                WriteLine();
                int choix = DemanderModificationOuAnnulation();

                switch (choix)
                {
                    case 0:
                        break;
                    case 1:
                        listePrix[l] = ModifierPrix(listePrix);
                        break;
                    case 2:
                        listeNom[l] = ModifierNom(listeNom);
                        break;
                    case 3:
                        listeCode[l] = "";
                        listeNom[l] = "";
                        listePrix[l] = 0;
                        break;
                }

                Clear();
            }
            return listeCode;
        }

        /// <summary>
        /// Cette méthode permet dans la méthode précédente (ObtenirListeCode) de choisir si la personne veut modifier/retirer un produit ou annuler
        /// l'opération.
        /// </summary>
        /// <returns></returns>
        public static int DemanderModificationOuAnnulation()
        {
            WriteLine("1.Modifier le prix");
            WriteLine("2.Modifier le nom");
            WriteLine("3.Retirer le produit");
            WriteLine("0.Annuler l'opération");
            int choix = LireInt32DansIntervalle("Votre choix : ", 0, 3);
            return choix;
        }
        /// <summary>
        /// Cette méthode permet de modifier le prix d'un produit.
        /// </summary>
        /// <param name="listePrix"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static double ModifierPrix(double[] listePrix)
        {
            double prix = LireDoublePositif("Veuillez indiquer le nouveau prix que vous voulez attribuer à ce produit : ");
            Clear();
            return prix;
        }

        public static string ModifierNom(string[] listeNom)
        {
            string nom = LireStringNonVide("Veuillez indiquer le nouveau nom que vous voulez attribuer à ce produit : ");
            Clear();
            return nom;
        }

        /// <summary>
        /// Cette méthode permet de s'occuper de la liste des noms, demande un nouveau nom si le nom existe déjà.
        /// </summary>
        /// <param name="listeNom"></param>
        /// <returns></returns>
        public static string[] ObtenirListeNom(string[] listeNom, int cpt)
        {
            string nom = LireStringNonVide("Veuillez indiquer le nom du produit : ");

            listeNom[cpt] = nom;

            Clear();

            return listeNom;
        }
        /// <summary>
        /// Cette méthode permet de s'occuper de la liste des catégorie, ajoute une catégorie si elle n'existe pas.
        /// </summary>
        /// <param name="listeCatégorie"></param>
        /// <returns></returns>
        public static string[] ObtenirListeCatégorie(string[] listeCatégorie, int cpt)
        {
            string catégorie = LireStringNonVide("Veuillez indiquer la catégorie du produit : ");
            listeCatégorie[cpt] = catégorie;
            Clear();
            return listeCatégorie;
        }
        /// <summary>
        /// Cette méthode permet de s'occuper de la liste des prix.
        /// </summary>
        /// <param name="listePrix"></param>
        /// <returns></returns>
        public static double[] ObtenirListePrix(double[] listePrix, int cpt)
        {
            double prix = LireDoublePositif("Veuillez indiquer le prix du produit : ");

            listePrix[cpt] = prix;

            Clear();
            return listePrix;
        }
    }
}
