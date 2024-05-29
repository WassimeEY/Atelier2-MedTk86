using Habilitations.bddmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedTk86.dal
{
    /// <summary>
    /// Agit comme un pont entre les controlleurs et la classe BddManager
    /// </summary>
    internal class ConnectionBdd
    {
        static private BddManager connectionBddManager = null;

        /// <summary>
        /// Crée la référence avec bddmanager qui va lui même créer la connexion avec la bdd
        /// </summary>
        static public void ConnecterAvecBdd()
        {
            string chaineConnexion = "server=127.0.0.1;uid=gerant;pwd=gerantDeLaBDD;database=mediatek86;port=3306";
            connectionBddManager = BddManager.GetInstance(chaineConnexion);
        }

        /// <summary>
        /// Permet de récuper l'instance de BddManager
        /// </summary>
        /// <returns>Réf à l'instance du singleton BddManager</returns>
        static public BddManager GetConnectionBdd()
        {
            return connectionBddManager;
        }
    }
 
}
