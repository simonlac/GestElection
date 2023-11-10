using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// 2129107
/// Simon Lacaille
namespace GestEtudiants
{
    /// <summary>
    /// Classe Etudiant. Hérite de la classe Personne 
    /// </summary>
    public class Electeur : Individu
    {
        //Attributs privés
        private string numero_electeur;
        private string circonscription;

        // Propriétés
        public string Numero_electeur
        {
            get { return this.numero_electeur; }
            set { if (verifier_regex_nombre(value) == true) this.numero_electeur = value; }

        public string Circonscription
        {
            get { return this.circonscription; }
            // Pour s'assurer que l'utilisateur a fait un choix dans le comboBox
            set { if (value != "") this.annee = value; }
        }
        // Constructeur avec paramètres et valeurs par défaut
        /// <summary>
        /// Intancie un objet de la classe Etudiant.
        /// </summary>
        /// <param name="p_nom">Nom de l'individu</param>
        /// <param name="p_prenom">Prénom de l'individu</param>
        /// <param name="p_courriel">Courriel de l'individu</param>
        /// <param name="p_numero_electeur">Numéro de l'électeur</param>
        /// <param name="p_circonscription">circoncription de l'électeur</param>
        public Electeur(string p_nom = "!", string p_prenom = "!", string p_courriel = "!", string p_numero_electeur= "!", string p_circonscription = "!") : base(p_nom, p_prenom, p_courriel)
        {
            this.numero_electeur = p_numero_electeur;
            this.circonscription = p_circonscription;
        }

        /// Vérifie qu'une chaîne est conforme à une expression régulìère
        /// </summary>
        /// <param name="chaine">La chaine à vérifier</param>
        /// <returns>true si la chaîne est conforme et false sinon</returns>
        public bool verifier_regex_nombre(string chaine)
        {
            Regex Reg = new Regex("^[0-9]{6}$");
            return Reg.IsMatch(chaine);
        }
        //Méthode to string 
        public override string ToString()
        {
            return " Nom: " + this.nom + " Prenom: "
             + this.prenom + " courriel: " + this.courriel
             + " numéro d'électeur: " + this.numero_electeur + " circonscription: " + this.circonscription;
        }
    }

}