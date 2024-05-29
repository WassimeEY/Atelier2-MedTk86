using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTk86.Modele
{
    /// <summary>
    /// Classe métier correspondant à la table Service
    /// </summary>
    internal class Service
    {
        public static List<Service> listeInstance = new List<Service>();
        public int idservice { get; set; }
        public string nom { get; set; }

        /// <summary>
        /// Constructeur qui permet de définir les propriétés de l'instance
        /// </summary>
        /// <param name="idservice">valeur de idservice utilisé dans cette instance</param>
        /// <param name="nom">valeur de nom utilisé dans cette instance</param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }
    }
}
