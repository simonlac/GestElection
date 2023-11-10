using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/// 2129107
/// Simon Lacaille
namespace GestElection
{
    /// <summary>
    /// Classe Individu
    /// </summary>
    public class Individu
    {
        //Attributs privés 
        private string nom;
        private string prenom;
        private string courriel;
        // Propriétés
        public string Nom
        {
            get { return this.nom; }
            set { if (verifier_regex(value) == true) this.nom = value; }
        }
        public string Prenom
        {
            get { return this.prenom; }
            set { if (verifier_regex(value) == true) this.prenom = value; }
        }

        public string Courriel
        {
            get { return this.courriel; }
            set { if (verifier_regex_courriel(value) == true) this.prenom = value;
        }
            //Le constructeur 
            /// <summary>
            /// Instancie un objet de la classe Individu
            /// </summary>
            /// <param name="p_nom">Nom de la personne</param>
            /// <param name="p_prenom">Prénom de la personne</param>
            /// <param name="p_courriel">Date de naissance de la personne</param>
        public Personne(string p_nom = "!", string p_prenom = "!", string p_courriel = "!")
        {
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.courriel = p_courriel;
        }

        /// Vérifie qu'une chaîne est conforme à une expression régulìère
        /// </summary>
        /// <param name="chaine">La chaine à vérifier</param>
        /// <returns>true si la chaîne est conforme et false sinon</returns>
        public bool verifier_regex(string chaine)
        {
            Regex Reg = new Regex("^[A-Z]{1}[A-Za-z]{5,20}$");
            return Reg.IsMatch(chaine);
        }
        /// Vérifie qu'une chaîne est conforme à une expression régulìère
        /// </summary>
        /// <param name="chaine">La chaine à vérifier</param>
        /// <returns>true si la chaîne est conforme et false sinon</returns>
        public bool verifier_regex_courriel(string chaine)
        {
            Regex Reg = new Regex("^[A-Za-z]{1}[A-Za-z]{4,25}[@][A-Za-z]{1,10}[.ca]}$");
            return Reg.IsMatch(chaine);
        }
        //Méthode to string 
        public override string ToString()
        {
            return " Nom: " + this.nom + " Prenom: "
             + this.prenom + " courriel: " + this.courriel;
        }
    }

}