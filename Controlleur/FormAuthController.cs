using Habilitations.bddmanager;
using MedTk86.dal;
using MedTk86.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MedTk86.Controlleur
{
    /// <summary>
    /// Singleton : controlleur de la form Authentification
    /// </summary>
    public class FormAuthController
    {
        private static FormAuthController instance = null;
        private BddManager connection;
        private static FormAuthentification formAuthRef;

        /// <summary>
        /// Constructeur où la référence avec la Form Authentification est définit
        /// </summary>
        public FormAuthController(FormAuthentification form)
        {
            formAuthRef = form;
            connection = ConnectionBdd.GetConnectionBdd();
        }

        /// <summary>
        /// Permet de récupérer ou créer l'instance de ce singleton
        /// </summary>
        public static FormAuthController GetFormAuthInstance(FormAuthentification frmAuthRef)
        {
            if (instance == null)
            {
                instance = new FormAuthController(frmAuthRef);
            }
            return instance;
        }

        /// <summary>
        /// Permet de récupérer le login et mdp stocké dans la table responsable dans la bdd
        /// </summary>
        /// <returns>Liste de liste d'objets, même si responsable contient une seule ligne</returns>
        public List<object[]> GetLoginEtMdp()
        {
            return connection.ReqSelect("SELECT * FROM responsable");
        }

    }
}
