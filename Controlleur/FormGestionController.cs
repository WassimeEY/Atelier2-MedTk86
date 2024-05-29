using Habilitations.bddmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedTk86.dal;
using MedTk86.Modele;
using MedTk86.Vue;
using System.Net.Http;
using Mysqlx.Crud;

namespace MedTk86.Controlleur
{
    /// <summary>
    /// Singleton : controlleur de la form Gestion
    /// </summary>
    public class FormGestionController
    {
        private static FormGestionController instance = null;
        private BddManager connection = ConnectionBdd.GetConnectionBdd();
        private static FormGestion formGestionRef;

        /// <summary>
        /// Permet de récupérer ou créer l'instance de ce singleton
        /// </summary>
        public static FormGestionController GetInstance(FormGestion frmGestionRef)
        {
            if (instance == null)
            {
                instance = new FormGestionController(frmGestionRef);
            }
            return instance;
        }

        /// <summary>
        /// Retourne l'instance de formGestionRef
        /// </summary>
        /// <returns>L'instance de la Form Gestion créer dans Program.cs</returns>
        public static FormGestion GetFormGestionInstance()
        {
            return formGestionRef;
        }

        /// <summary>
        /// Récupére tout le contenu de toutes les tables (excepté responsable) et alimente les "listeInstance" des classes concernés
        /// </summary>
        public void DefinirTables()
        {
            //Pour absence
            Absence.listeInstance.Clear();
            List<Object[]> absences = connection.ReqSelect("SELECT * FROM absence");
            foreach (Object[] absence in absences)
            {
                Absence ligneAbsence = new Absence((int)(absence[0]), (DateTime)(absence[1]), (DateTime)(absence[2]), (int)(absence[3]));
                Absence.listeInstance.Add(ligneAbsence);
            }
            //Pour personnel
            Personnel.listeInstance.Clear();
            List<Object[]> personnels = connection.ReqSelect("SELECT * FROM personnel");
            foreach (Object[] personnel in personnels)
            {
                Personnel lignePersonnel = new Personnel((int)(personnel[0]), (string)(personnel[1]), (string)(personnel[2]), (string)(personnel[3]), (string)(personnel[4]), (int)(personnel[5]));
                Personnel.listeInstance.Add(lignePersonnel);
            }
            //Pour service (qui n'est, pour le moment, pas modifié depuis le logiciel)
            Service.listeInstance.Clear();
            List<Object[]> services = connection.ReqSelect("SELECT * FROM service");
            foreach (Object[] service in services)
            {
                Service ligneService = new Service((int)(service[0]), (string)(service[1]));
                Service.listeInstance.Add(ligneService);
            }
            //Pour motif (qui n'est, pour le moment, pas modifié depuis le logiciel)
            Motif.listeInstance.Clear();
            List<Object[]> motifs = connection.ReqSelect("SELECT * FROM motif");
            foreach (Object[] motif in motifs)
            {
                Motif ligneMotif = new Motif((int)(motif[0]), (string)(motif[1]));
                Motif.listeInstance.Add(ligneMotif);
            }
        }

        /// <summary>
        /// Constructeur qui définit la référence avec Form Gesion créer dans Program.cs, elle lance aussi la procédure DefinirTables
        /// </summary>
        /// <param name="frmGestionRef">L'instance de Form Gestion, créer dans Program.cs</param>
        public FormGestionController(FormGestion frmGestionRef)
        {
            formGestionRef = frmGestionRef;
            DefinirTables();
           
        }

        /// <summary>
        /// Ajoute une absence à la bdd
        /// </summary>
        /// <param name="idPersonnel">Valeur de l'id du personnel concerné par la nouvelle absence</param>
        /// <param name="dateDebut">Valeur de la date du début de la nouvelle absence</param>
        /// <param name="dateFin">Valeur de la date de la fin de la nouvelle absence</param>
        /// <param name="idMotif">Valeur de l'idmotif de la nouvelle absence</param>
        public void AjouterAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            string strDateDebut = dateDebut.ToString("yyyy-MM-dd HH:mm:ss");
            string strDateFin = dateFin.ToString("yyyy-MM-dd HH:mm:ss");
            string commande = ("INSERT INTO absence VALUES(" + idPersonnel + ", '" + strDateDebut + "' , '" + strDateFin + "' ," + idMotif + ")");
            connection.ReqUpdate(commande);
        }

        /// <summary>
        /// Supprime une absence de la bdd, en utilisant l'idpersonnel et la dateDébut comme clé primaire composé
        /// </summary>
        /// <param name="idPersonnel">Valeur de l'id du personnel concerné par l'absence</param>
        /// <param name="datedebut">Valeur de la date du début de l'absence</param>
        public void SupprimerAbsence(int idPersonnel, DateTime datedebut)
        {
            string strDateDebut = datedebut.ToString("yyyy-MM-dd HH:mm:ss");
            string commande = ("DELETE FROM absence WHERE idpersonnel = " + idPersonnel + " AND datedebut = '" + strDateDebut +"'");
            connection.ReqUpdate(commande);
        }

        /// <summary>
        /// Modifie une absence de la bdd, en utilisant l'idpersonnel et la dateDébut comme clé primaire composé
        /// </summary>
        /// <param name="idPersonnel">Valeur de l'id du personnel concerné par l'absence</param>
        /// <param name="dateDebut">Nouvelle valeur de la date du début de l'absence</param>
        /// <param name="dateFin">Nouvelle valeur de la date de la fin de l'absence</param>
        /// <param name="idMotif">Nouvelle valeur de l'idmotif de l'absence</param>
        public void ModifierAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            string strDateDebut = dateDebut.ToString("yyyy-MM-dd HH:mm:ss");
            string strDateFin = dateFin.ToString("yyyy-MM-dd HH:mm:ss");
            string commande = ("UPDATE absence SET idpersonnel = " + idPersonnel + ", datedebut = '" + strDateDebut + "' , datefin = '" + strDateFin + "' , idMotif = " + idMotif + " WHERE idpersonnel = " + idPersonnel + " AND datedebut = '" + strDateDebut + "'");
            connection.ReqUpdate(commande);
        }


        /// <summary>
        /// Ajoute un nouveau personnel à la bdd
        /// </summary>
        /// <param name="nom">Valeur de nom du nouveau personnel</param>
        /// <param name="prenom">Valeur de prenom du nouveau personnel</param>
        /// <param name="tel">Valeur de tel du nouveau personnel</param>
        /// <param name="mail">Valeur de mail du nouveau personnel</param>
        /// <param name="idServiceAffectation">Valeur de idServiceAffectation du nouveau personnel</param>
        public void AjouterPersonnel(string nom, string prenom, string tel, string mail, int idServiceAffectation)
        {
            string commande = ("INSERT INTO personnel VALUES(NULL, '" + nom + "', '" + prenom + "', '" + tel + "', '" + mail + "', " + idServiceAffectation + ")");
            connection.ReqUpdate(commande);
        }

        /// <summary>
        /// Supprime un personnel de la bdd, en utilisant idPersonnelAsupprimer comme clé primaire
        /// </summary>
        /// <param name="idPersonnelAsupprimer">Valeur de l'id du personnel à supprimer</param>
        public void SupprimerPersonnel(int idPersonnelAsupprimer)
        {
            string commande = ("DELETE FROM personnel WHERE idpersonnel = " + idPersonnelAsupprimer);
            connection.ReqUpdate(commande);
        }

        /// <summary>
        /// Modifie un personnel de la bdd, en utilisant idPersonnelModifie comme clé primaire
        /// </summary>
        /// <param name="idPersonnelModifie">Valeur de l'id du personnel à modifier</param>
        /// <param name="nom">Nouvelle valeur de nom</param>
        /// <param name="prenom">Nouvelle valeur de prenom</param>
        /// <param name="tel">Nouvelle valeur de tel</param>
        /// <param name="mail">Nouvelle valeur de mail</param>
        /// <param name="idServiceAffectation">Nouvelle valeur de idServiceAffectation</param>
        public void ModifierPersonnel(int idPersonnelModifie, string nom, string prenom, string tel, string mail, int idServiceAffectation)
        {
            string commande = ("UPDATE personnel SET nom = '" + nom + "' , prenom = '" + prenom + "' , tel = '" + tel + "' , mail = '" + mail + "' , idservice = " + idServiceAffectation + " WHERE idpersonnel = " + idPersonnelModifie);
            connection.ReqUpdate(commande); 
        }

    }
}
