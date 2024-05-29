using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTk86.Modele
{
    /// <summary>
    /// Classe métier correspondant à la table Motif
    /// </summary>
    internal class Motif
    {
        public static List<Motif> listeInstance = new List<Motif>();
        public int idmotif { get; set; }
        public string libelle { get; set; }

        /// <summary>
        /// Constructeur qui permet de définir les propriétés de l'instance
        /// </summary>
        /// <param name="idmotif">valeur de idmotif utilisé dans cette instance</param>
        /// <param name="libelle">valeur de libelle utilisé dans cette instance</param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }
    }
}
