using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Utilitaires
{
    static class Util
    {
        /// <summary>
        /// Méthode pour lire une string.
        /// </summary>
        /// <param name="p_question"> La string à lire </param>
        /// <returns> Retourne un readline de la string. </returns>
        public static string LireString(string p_question)
        {
            Console.Write(p_question);
            WriteLine("");
            return Console.ReadLine().Trim();
        }

        /// <summary>
        /// Méthode permettant de valider un nombre entier. 
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat</param>
        /// <returns>Retourne un nombre entier. </returns>
        public static int LireInt32(string p_question)
        {
            int nombre;
            for (; ; )
            {
                Write(p_question);
                WriteLine("");
                /***/
                if (Int32.TryParse(ReadLine(), out nombre)) break;
                /***/
                WriteLine("*** Veuillez entrer un simple nombre entier. ");
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant de valider un nombre.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat. </param>
        /// <returns>Retourne un nombre.</returns>
        public static double LireDouble(string p_question)
        {
            double nombre;
            for (; ; )
            {
                Write(p_question);
                WriteLine("");
                /***/
                if (double.TryParse(ReadLine(), out nombre)) break;
                /***/
                WriteLine("*** Veuillez entrer un simple nombre. ");
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant de valider un nombre entier positif.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat. </param>
        /// <returns>Retourne un entier positif.</returns>
        public static int LireInt32Positif(string p_question)
        {
            int nombre;
            for (; ; )
            {
                nombre = LireInt32(p_question);
                /***/
                if (nombre > 0) break;
                /***/
                WriteLine("*** Veuillez entrer un nombre entier positif. ");
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant de valider un nombre positif.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat. </param>
        /// <returns>Retourne un positif.</returns>
        public static double LireDoublePositif(string p_question)
        {
            double nombre;
            for (; ; )
            {
                nombre = LireDouble(p_question);
                /***/
                if (nombre > 0) break;
                /***/
                WriteLine("*** Veuillez entrer un nombre positif. ");
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant de valider un nombre entier supérieur au nombre minimum.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat. </param>
        /// <param name="p_minimum">Le nombre minimum. </param>
        /// <returns>Retourne un nombre supérieur au nombre minimum. </returns>
        public static int LireInt32AvecMinimum(string p_question, int p_minimum)
        {
            int nombre;
            for (; ; )
            {
                nombre = LireInt32(p_question);
                /***/
                if (nombre >= p_minimum) break;
                /***/
                WriteLine("*** Veuillez entrer un nombre entier supérieur ou égal à {0}. ", p_minimum);
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant de valider un nombre supérieur au nombre minimum.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat. </param>
        /// <param name="p_minimum">Le nombre minimum. </param>
        /// <returns>Retourne un nombre supérieur au nombre minimum. </returns>
        public static double LireDoubleMinimum(string p_question, double p_minimum)
        {
            double nombre;
            for (; ; )
            {
                nombre = LireDouble(p_question);
                /***/
                if (nombre >= p_minimum) break;
                /***/
                WriteLine("*** Veuillez entrer un nombre supérieur ou égal à {0}. ", p_minimum);
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant de valider un nombre entier se trouvant dans une intervalle.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat.</param>
        /// <param name="p_minimum">Le nombre minimum de l'intervalle. </param>
        /// <param name="p_maximum">Le nombre maximum de l'intervalle.</param>
        /// <returns>Retourne un nombre entier se trouvant dans une intervalle définie.</returns>
        public static int LireInt32DansIntervalle(string p_question, int p_minimum, int p_maximum)
        {
            int nombre;
            for (; ; )
            {
                nombre = LireInt32(p_question);
                /***/
                if (p_minimum <= nombre && nombre <= p_maximum) break;
                /***/
                WriteLine("*** Veuillez entrer un nombre entier entre {0} et {1}. ", p_minimum, p_maximum);
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant de valider un nombre se trouvant dans une intervalle.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat.</param>
        /// <param name="p_minimum">Le nombre minimum de l'intervalle. </param>
        /// <param name="p_maximum">Le nombre maximum de l'intervalle.</param>
        /// <returns>Retourne un nombre se trouvant dans une intervalle définie.</returns>
        public static double LireDoubleIntervalle(string p_question, double p_minimum, double p_maximum)
        {
            double nombre;
            for (; ; )
            {
                nombre = LireDouble(p_question);
                /***/
                if (p_minimum <= nombre && nombre <= p_maximum) break;
                /***/
                WriteLine("*** Veuillez entrer un nombre entre {0} et {1}. ", p_minimum, p_maximum);
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant de valider un caractère. 
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat. </param>
        /// <returns>Retourne un caractère.</returns>
        public static char LireChar(string p_question)
        {
            char caractère;
            for (; ; )
            {
                Write(p_question);
                WriteLine("");
                /***/
                if (Char.TryParse(ReadLine(), out caractère)
                    &&
                    !Char.IsControl(caractère)) break;
                /***/
                WriteLine("*** Veuillez entrer un, et un seul, caractère (ordinaire). ");
            }
            return caractère;
        }

        /// <summary>
        /// Méthode permettant de valider la taille d'une string.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat. </param>
        /// <param name="p_lgMin">Le nombre de caractère minimum de la string. </param>
        /// <param name="p_lgMax">Le nombre de caractère maximum de la string. </param>
        /// <returns>Retourne un texte se trouvant dans l'intervalle demandée.</returns>
        public static string LireStringTailleContrôlée(string p_question, int p_lgMin, int p_lgMax)
        {
            string texte;
            for (; ; )
            {
                Write(p_question);
                WriteLine("");
                texte = ReadLine().Trim();
                /***/
                if (p_lgMin <= texte.Length && texte.Length <= p_lgMax) break;
                /***/
                WriteLine("*** Veuillez entrer un texte contenant entre {0} et {1} caractères. ", p_lgMin, p_lgMax);
            }
            return texte;
        }

        /// <summary>
        /// Méthode permettant de ne pas avoir une string vide.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat.</param>
        /// <returns>Retourne un texte ayant au moins un caractère.</returns>
        public static string LireStringNonVide(string p_question)
        {
            string texte;
            for (; ; )
            {
                Write(p_question);
                WriteLine("");
                texte = ReadLine().Trim();
                /***/
                if (texte.Length > 0) break;
                /***/
                WriteLine("*** Veuillez entrer un texte non vide.");
            }
            return texte;
        }

        /// <summary>
        /// Méthode permettant de n'avoir que des entier supérieur à un entier minimum demandé.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat</param>
        /// <param name="p_minimum">l'entier minimum</param>
        /// <param name="p_sentinelle">la sentinelle</param>
        /// <returns>Retourne un nombre entier supérieur à un minimum demandé.</returns>
        public static int LireInt32AvecMinimumOuSentinelle(string p_question, int p_minimum, int p_sentinelle)
        {
            int âge;
            for (; ; )
            {
                âge = LireInt32(p_question);
                /***/
                if (âge >= p_minimum || âge == p_sentinelle) break;
                /***/
                WriteLine("*** Veuillez entrer une valeur supérieur ou égale à {0}, ou {1} pour annuler. ", p_minimum, p_sentinelle);
            }
            return âge;
        }

        /// <summary>
        /// Méthode permettant d'avoir un nombre entier dans une intervalle.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat.</param>
        /// <param name="p_minimum">Valeur minimum</param>
        /// <param name="p_maximum">Valeur maximale</param>
        /// <param name="p_sentinelle">Sentinelle</param>
        /// <returns>Retourne un nombre entier appartenant à une intervalle.</returns>
        public static int LireInt32DansIntervalleOuSentinelle(string p_question, int p_minimum, int p_maximum, int p_sentinelle)
        {
            int nombre;
            for (; ; )
            {
                nombre = LireInt32(p_question);
                /***/
                if ((p_minimum <= nombre && nombre <= p_maximum) || nombre == p_sentinelle) break;
                /***/
                WriteLine("*** Veuillez entrer un nombre entier entre {0} et {1}, ou {2} pour annuler. ", p_minimum, p_maximum, p_sentinelle);
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant d'avoir un nombre supérieur au minimum.
        /// </summary>
        /// <param name="p_question">La question pour avoir un résultat</param>
        /// <param name="p_minimum">Valeur minimum</param>
        /// <param name="p_sentinelle">Sentinelle</param>
        /// <returns>Retourne un nombre supérieur au minimum demandé.</returns>
        public static double LireDoubleAvecMinimumOuSentinelle(string p_question, double p_minimum, double p_sentinelle)
        {
            double nombre;
            for (; ; )
            {
                nombre = LireDouble(p_question);
                /***/
                if (nombre >= p_minimum || nombre == p_sentinelle) break;
                /***/
                WriteLine("*** Veuillez entrer un nombre supérieur ou égal à {0}, ou {1} pour annuler. ", p_minimum, p_sentinelle);
            }
            return nombre;
        }

        /// <summary>
        /// Méthode permettant d'avoir un nombre dans une intervalle.
        /// </summary>
        /// <param name="p_question">La question a poser pour avoir un résultat.</param>
        /// <param name="p_minimum">Valeur minimum</param>
        /// <param name="p_maximum">Valeur maximale</param>
        /// <param name="p_sentinelle">Sentinelle</param>
        /// <returns>Retourne un nombre compris dans une intervalle.</returns>
        public static double LireDoubleDansIntervalleOuSentinelle(string p_question, double p_minimum, double p_maximum, double p_sentinelle)
        {
            double nombre;
            for (; ; )
            {
                nombre = LireDouble(p_question);
                /***/
                if ((p_minimum <= nombre && nombre <= p_maximum) || nombre == p_sentinelle) break;
                /***/
                WriteLine("*** Veuillez entrer un nombre entier entre {0} et {1}, ou {2} pour annuler. ", p_minimum, p_maximum, p_sentinelle);
            }
            return nombre;
        }
        /// <summary>
        /// Méthode permettant d'avoir une réponse vraie ou fausse.
        /// </summary>
        /// <param name="p_question">La question à poser.</param>
        /// <returns>Retourne si la question est vraie ou fausse.</returns>
        public static bool ConfirmerOuiNon(string p_question)
        {
            char réponse;
            for (; ; )
            {
                réponse = LireChar(p_question);
                /***/
                if (réponse == 'o' || réponse == 'O')
                {
                    return true;
                }
                if (réponse == 'n' || réponse == 'N')
                {
                    return false;
                }
                /***/
                WriteLine("***Veuillez répondre O (pour oui) ou N (pour non), en majuscule ou minuscule");
            }
        }
        public static List<double> SéquenceRéelle(double p_départ, int p_nbValeurs)
        {
            List<double> réels = new List<double>(p_nbValeurs);

            for (int i = 0; i != p_nbValeurs; ++i)
            {
                réels.Add(p_départ + 1);
            }

            return réels;
        }

        /// <summary>
        /// Savoir si un nombre est pair ou impair.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static bool LireNombrePair(double nombre)
        {
            if (nombre % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
