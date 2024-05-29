using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Habilitations.bddmanager;

namespace MedTk86.Modele
{
    /// <summary>
    /// Classe métier correspondant à la table Absence
    /// </summary>
    internal class Absence
    {
        public static List<Absence> listeInstance = new List<Absence>();
        public int idpersonnel { get; set; }
        public DateTime datedebut { get; set; }
        public DateTime datefin { get; set; }
        public int idmotif { get; set; }

        /// <summary>
        /// Constructeur qui permet de définir les propriétés de l'instance
        /// </summary>
        /// <param name="idpersonnel">valeur de idpersonnel utilisé dans cette instance</param>
        /// <param name="datedebut">valeur de datedebut utilisé dans cette instance</param>
        /// <param name="datefin">valeur de datefin utilisé dans cette instance</param>
        /// <param name="idmotif">valeur de idmotif utilisé dans cette instance</param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;
        }
    }
}
