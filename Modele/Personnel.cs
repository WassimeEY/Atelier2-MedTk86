using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTk86.Modele
{
    /// <summary>
    /// Classe métier correspondant à la table Personnel
    /// </summary>
    internal class Personnel
    {
        public static List<Personnel> listeInstance = new List<Personnel>();
        public int idpersonnel { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public int idservice { get; set; }

        /// <summary>
        /// Constructeur qui permet de définir les propriétés de l'instance
        /// </summary>
        /// <param name="idpersonnel">valeur de idpersonnel utilisé dans cette instance</param>
        /// <param name="nom">valeur de nom utilisé dans cette instance</param>
        /// <param name="prenom">valeur de prenom utilisé dans cette instance</param>
        /// <param name="tel">valeur de tel utilisé dans cette instance</param>
        /// <param name="mail">valeur de mail utilisé dans cette instance</param>
        /// <param name="idservice">valeur de idservice utilisé dans cette instance</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
        }
    }
}
