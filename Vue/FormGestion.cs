using Habilitations.bddmanager;
using MedTk86.Controlleur;
using MedTk86.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedTk86.Vue
{
    /// <summary>
    /// Cette classe de la vue passe par son controlleur FormGestionController pour agir sur la bdd et récupérer ses données
    /// </summary>
    public partial class FormGestion : Form
    {
        private FormGestionController formGestionControlRef = null;
        private int idPersonnelSelected = 1;
        private int idPersonnelSelectedLocal = -1;
        private int indexAbsenceSelectedRow = -1;
        private bool modificationPersonnel = false;
        private bool modificationAbsence = false;

        /// <summary>
        /// Constructeur où la référence avec le controlleur est définie
        /// </summary>
        public FormGestion()
        {
            InitializeComponent();
            formGestionControlRef = FormGestionController.GetInstance(this);
            Actualiser();
        }


        private void FormGestion_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Permet d'actualiser les données visible dans le logiciel à partir de la bdd
        /// </summary>
        public void Actualiser()
        {
            if (formGestionControlRef != null)
            {
                formGestionControlRef.DefinirTables();
            }
            RemplirComboBoxService();
            RemplirComboBoxMotif();
            RemplirListboxAbsence();
            RemplirListboxPersonnel();
        }

        /// <summary>
        /// Remplie la listBox Absence à partir de la bdd
        /// </summary>
        public void RemplirListboxAbsence()
        {
            dgv_Absence.SelectionChanged -= dgv_Absence_SelectionChanged;
            dgv_Absence.Rows.Clear();
            if(dgv_Personnel.SelectedRows.Count == 1)
            {
                foreach (Absence absence in Absence.listeInstance)
                {
                    if (absence.idpersonnel == idPersonnelSelected)
                    {
                        dgv_Absence.Rows.Add(absence.idpersonnel, absence.datedebut, absence.datefin, cb_Motif.Items[absence.idmotif-1].ToString());
                    }
                }
            }
            dgv_Absence.SelectionChanged += dgv_Absence_SelectionChanged;
        }

        /// <summary>
        /// Remplie la listBox Personnel à partir de la bdd
        /// </summary>
        public void RemplirListboxPersonnel()
        {
            
            dgv_Personnel.Rows.Clear();
            foreach (Personnel personnel in Personnel.listeInstance)
            {
                dgv_Personnel.Rows.Add(personnel.idpersonnel, personnel.nom, personnel.prenom, personnel.tel, personnel.mail, cb_ServiceAffectation.Items[personnel.idservice-1].ToString());
            }
            
        }

        /// <summary>
        /// Remplie la comboBox ServiceAffectation à partir de la bdd
        /// </summary>
        public void RemplirComboBoxService()
        {
            cb_ServiceAffectation.Items.Clear();
            foreach (Service service in Service.listeInstance)
            {
                cb_ServiceAffectation.Items.Add(service.nom);
            }
        }

        /// <summary>
        /// Remplie la comboBox Motif à partir de la bdd
        /// </summary>
        public void RemplirComboBoxMotif()
        {
            cb_Motif.Items.Clear();
            foreach (Motif motif in Motif.listeInstance)
            {
                cb_Motif.Items.Add(motif.libelle);
            }
        }

        /// <summary>
        /// On actualise les absences selon le personnel selectionné, on active également les boutons lié à la suppression et la modification du personnel
        /// </summary>
        private void dgv_Personnel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Personnel.SelectedRows.Count == 1)
            {
                idPersonnelSelected = (int)dgv_Personnel.CurrentRow.Cells[0].Value;
                idPersonnelSelectedLocal = idPersonnelSelected - 1;
                lbl_idPersonnelSelectedNb.Text = idPersonnelSelected.ToString();
                lbl_idPersonnelSelectedNbAbsence.Text = idPersonnelSelected.ToString();
                btn_GoModifierPersonnel.Enabled = true;
                btn_SupprimerPersonnel.Enabled = true;
                btn_GoAjouterAbsence.Enabled = true;
                RemplirListboxAbsence();
            }
            else
            {
                btn_GoModifierPersonnel.Enabled = false;
                btn_SupprimerPersonnel.Enabled = false;
                btn_GoAjouterAbsence.Enabled = false;
                RemplirListboxAbsence();
            }
        }

        /// <summary>
        /// On active les boutons lié à la suppression et la modification d'une absence
        /// </summary>
        private void dgv_Absence_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Absence.SelectedRows.Count == 1)
            {
                indexAbsenceSelectedRow = dgv_Absence.CurrentRow.Index;
                btn_GoModifierAbsence.Enabled = true;
                btn_SupprimerAbsence.Enabled = true;
            }
            else
            {
                btn_GoModifierAbsence.Enabled = false;
                btn_SupprimerAbsence.Enabled = false;
            }
        }

        /// <summary>
        /// Permet de changer de "page" sans pour autant avoir à créer d'autres Form, il y a plusieurs groupBox superposé et caché, on définit laquelle sera affiché avec cette fonction
        /// </summary>
        /// <param name="goTo">Nom (pas exactement le même) de la page (groupBox) à afficher</param>
        public void ChangerVisibleGroupBox(string goTo)
        {
            Actualiser();
            List<GroupBox> listeGbCache = new List<GroupBox> {gb_AjoutModifAbsence ,gb_AjoutModifPersonnel, gb_Gestion};
            switch (goTo)
            {
                case "GbGestion":
                    gb_Gestion.Visible = true;
                    listeGbCache.Remove(gb_Gestion);
                    foreach(GroupBox gb in listeGbCache)
                    {
                        gb.Visible = false;
                    }
                    break;

                case "GbAjoutModifPersonnel":
                    gb_AjoutModifPersonnel.Visible = true;
                    listeGbCache.Remove(gb_AjoutModifPersonnel);
                    foreach (GroupBox gb in listeGbCache)
                    {
                        gb.Visible = false;
                    }
                    break;
                case "GbAjoutModifAbsence":
                    gb_AjoutModifAbsence.Visible = true;
                    listeGbCache.Remove(gb_AjoutModifAbsence);
                    foreach (GroupBox gb in listeGbCache)
                    {
                        gb.Visible = false;
                    }
                    break;
            }
        }


        /// <summary>
        /// Adapte la page (la groupBox) personnel selon si on y va pour une modification ou un ajout
        /// </summary>
        /// <param name="modification">Permet de définir si on va à la groupBox personnel pour modifier ou ajouter un personnel</param>
        private void AdapterGbPersonnel(bool modification)
        {
            modificationPersonnel = modification;
            if (modification)
            {
                btn_ModifierOuAjouterPersonnel.Text = "Modifier";
                lbl_idPersonnelSelected.Visible = true;
                lbl_idPersonnelSelectedNb.Visible = true;
                txtb_Nom.Text = Personnel.listeInstance[idPersonnelSelectedLocal].nom;
                txtb_Prenom.Text = Personnel.listeInstance[idPersonnelSelectedLocal].prenom;
                txtb_Tel.Text = Personnel.listeInstance[idPersonnelSelectedLocal].tel;
                txtb_Mail.Text = Personnel.listeInstance[idPersonnelSelectedLocal].mail;
                cb_ServiceAffectation.SelectedIndex = (Personnel.listeInstance[idPersonnelSelectedLocal].idservice - 1);
                gb_AjoutModifPersonnel.Text = "Modification d'un personnel";
            }
            else
            {
                txtb_Nom.Text = "";
                txtb_Prenom.Text = "";
                txtb_Tel.Text = "";
                txtb_Mail.Text = "";
                cb_ServiceAffectation.SelectedIndex = 0;
                btn_ModifierOuAjouterPersonnel.Text = "Ajouter";
                lbl_idPersonnelSelected.Visible = false;
                lbl_idPersonnelSelectedNb.Visible = false;
                gb_AjoutModifPersonnel.Text = "Ajout d'un personnel";
            }
        }

        /// <summary>
        /// Adapte la page (la groupBox) absence selon si on y va pour une modification ou un ajout
        /// </summary>
        /// <param name="modification">Permet de définir si on va à la groupBox absence pour modifier ou ajouter une absence</param>
        private void AdapterGbAbsence(bool modification)
        {
            modificationAbsence = modification;
            if (modification)
            {
                btn_ModifierOuAjouterAbsence.Text = "Modifier";
                dtp_DateDebut.Value = Absence.listeInstance[indexAbsenceSelectedRow].datedebut;
                dtp_DateFin.Value = Absence.listeInstance[indexAbsenceSelectedRow].datefin;
                cb_Motif.SelectedIndex = (Personnel.listeInstance[idPersonnelSelectedLocal].idservice - 1);
                gb_AjoutModifAbsence.Text = "Modification d'une absence";
            }
            else
            {
                dtp_DateDebut.Value = DateTime.Now;
                dtp_DateFin.Value = DateTime.Now;
                cb_Motif.SelectedIndex = 0;
                btn_ModifierOuAjouterAbsence.Text = "Ajouter";
                gb_AjoutModifAbsence.Text = "Ajout d'une absence";
            }
        }

        /// <summary>
        /// Cliquer lance une confirmation, si l'utilisateur confirme alors on modifie ou ajoute le personnel dans la bdd"
        /// </summary>
        private void btn_ModifierOuAjouterPersonnel_Click(object sender, EventArgs e)
        {
            if (txtb_Mail.Text != "" && txtb_Nom.Text != "" && txtb_Prenom.Text != "" && txtb_Tel.Text != "")
            {
                DialogResult resultat = MessageBox.Show("Voulez-vous vraiment procéder ?", "Confirmation", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes)
                {
                    if (modificationPersonnel)
                    {
                        formGestionControlRef.ModifierPersonnel(idPersonnelSelected, txtb_Nom.Text, txtb_Prenom.Text, txtb_Tel.Text, txtb_Mail.Text, (cb_ServiceAffectation.SelectedIndex + 1));
                        ChangerVisibleGroupBox("GbGestion");
                    }
                    else
                    {
                        formGestionControlRef.AjouterPersonnel(txtb_Nom.Text, txtb_Prenom.Text, txtb_Tel.Text, txtb_Mail.Text, (cb_ServiceAffectation.SelectedIndex + 1));
                        ChangerVisibleGroupBox("GbGestion");
                    }
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Erreur", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void btn_RetourAjoutModifPersonnel_Click(object sender, EventArgs e)
        {
            ChangerVisibleGroupBox("GbGestion");
        }

        /// <summary>
        /// Ramène à la page (groupBox) ajoutModifAbsence en l'adaptant pour un ajout
        /// </summary>
        private void btn_GoAjouterAbsence_Click(object sender, EventArgs e)
        {
            ChangerVisibleGroupBox("GbAjoutModifAbsence");
            AdapterGbAbsence(false);
        }

        /// <summary>
        /// Ramène à la page (groupBox) ajoutModifPersonnel en l'adaptant pour une modification
        /// </summary>
        private void btn_GoModifierPersonnel_Click(object sender, EventArgs e)
        {
            ChangerVisibleGroupBox("GbAjoutModifPersonnel");
            AdapterGbPersonnel(true);
        }

        /// <summary>
        /// Ramène à la page (groupBox) ajoutModifPersonnel en l'adaptant pour un ajout
        /// </summary>
        private void btn_GoAjouterPersonnel_Click(object sender, EventArgs e)
        {
            ChangerVisibleGroupBox("GbAjoutModifPersonnel");
            AdapterGbPersonnel(false);
        }

        /// <summary>
        /// Cliquer lance une confirmation, si l'utilisateur confirme alors on supprime le personnel dans la bdd et on actualise
        /// </summary>
        private void btn_SupprimerPersonnel_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous vraiment supprimer ce personnel ?", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                formGestionControlRef.SupprimerPersonnel(idPersonnelSelected);
                ActualiserApresDelay(500);
            }
            
        }

        /// <summary>
        /// Cliquer lance une confirmation, si l'utilisateur confirme alors on supprime l'absence dans la bdd et on actualise
        /// </summary>
        private void btn_SupprimerAbsence_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Confirmation", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                formGestionControlRef.SupprimerAbsence(idPersonnelSelected, (DateTime)(dgv_Absence.CurrentRow.Cells[1].Value));
                ActualiserApresDelay(500);
                btn_SupprimerAbsence.Enabled = false;
            }
            
        }

        /// <summary>
        /// Lance une actualisation du logiciel (en prenant les données actuelles de la bdd), la fonction est async car elle inclut un delay de 500 millisecondes, le temps de prendre en compte de nouvelles modifications
        /// </summary>
        /// <param name="delayEnMilliseconde">durée en milliseconde d'attente avant d'actualiser</param>
        private async void ActualiserApresDelay(int delayEnMilliseconde)
        {
            await Task.Delay(delayEnMilliseconde);
            Actualiser();
        }

        /// <summary>
        /// Ramène à la page (groupBox) gestion
        /// </summary>
        private void btn_RetourAjoutModifAbsence_Click(object sender, EventArgs e)
        {
            ChangerVisibleGroupBox("GbGestion");
        }

        /// <summary>
        /// Cliquer lance une confirmation, si l'utilisateur confirme alors on modifie ou ajoute l'absence dans la bdd et on actualise
        /// </summary>
        private void btn_ModifierOuAjouterAbsence_Click(object sender, EventArgs e)
        {
                DialogResult resultat = MessageBox.Show("Voulez-vous vraiment procéder ?", "Confirmation", MessageBoxButtons.YesNo);
                if (resultat == DialogResult.Yes)
                {
                    if (modificationAbsence)
                    {
                        formGestionControlRef.ModifierAbsence(idPersonnelSelected, dtp_DateDebut.Value, dtp_DateFin.Value, (cb_Motif.SelectedIndex + 1));
                        ChangerVisibleGroupBox("GbGestion");
                    }
                    else
                    {
                        formGestionControlRef.AjouterAbsence(idPersonnelSelected, dtp_DateDebut.Value, dtp_DateFin.Value, (cb_Motif.SelectedIndex + 1));
                        ChangerVisibleGroupBox("GbGestion");
                    }
                }        
        }

        /// <summary>
        /// Ramène à la page (groupBox) ajoutModifAbsence en l'adaptant pour une modification
        /// </summary>
        private void btn_GoModifierAbsence_Click(object sender, EventArgs e)
        {
            ChangerVisibleGroupBox("GbAjoutModifAbsence");
            AdapterGbAbsence(true);
        }

        /// <summary>
        /// Lance une actualisation du logiciel
        /// </summary>
        private void btn_Actualiser_Click(object sender, EventArgs e)
        {
            Actualiser();
        }
    }
}
