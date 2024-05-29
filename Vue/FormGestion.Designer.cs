namespace MedTk86.Vue
{
    partial class FormGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_AjoutModifPersonnel = new System.Windows.Forms.GroupBox();
            this.lbl_idPersonnelSelectedNb = new System.Windows.Forms.Label();
            this.lbl_idPersonnelSelected = new System.Windows.Forms.Label();
            this.btn_ModifierOuAjouterPersonnel = new System.Windows.Forms.Button();
            this.cb_ServiceAffectation = new System.Windows.Forms.ComboBox();
            this.btn_RetourAjoutModifPersonnel = new System.Windows.Forms.Button();
            this.lbl_ServiceAffectation = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.txtb_Mail = new System.Windows.Forms.TextBox();
            this.txtb_Tel = new System.Windows.Forms.TextBox();
            this.txtb_Prenom = new System.Windows.Forms.TextBox();
            this.txtb_Nom = new System.Windows.Forms.TextBox();
            this.gb_Gestion = new System.Windows.Forms.GroupBox();
            this.btn_Actualiser = new System.Windows.Forms.Button();
            this.dgv_Personnel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idservice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Absence = new System.Windows.Forms.DataGridView();
            this.btn_GoModifierAbsence = new System.Windows.Forms.Button();
            this.btn_SupprimerAbsence = new System.Windows.Forms.Button();
            this.btn_GoAjouterAbsence = new System.Windows.Forms.Button();
            this.btn_GoModifierPersonnel = new System.Windows.Forms.Button();
            this.btn_SupprimerPersonnel = new System.Windows.Forms.Button();
            this.btn_GoAjouterPersonnel = new System.Windows.Forms.Button();
            this.idpersonnel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_AjoutModifAbsence = new System.Windows.Forms.GroupBox();
            this.dtp_DateFin = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateDebut = new System.Windows.Forms.DateTimePicker();
            this.lbl_idPersonnelSelectedNbAbsence = new System.Windows.Forms.Label();
            this.lbl_idPersonnelSelectedAbsence = new System.Windows.Forms.Label();
            this.btn_ModifierOuAjouterAbsence = new System.Windows.Forms.Button();
            this.cb_Motif = new System.Windows.Forms.ComboBox();
            this.btn_RetourAjoutModifAbsence = new System.Windows.Forms.Button();
            this.lbl_Motif = new System.Windows.Forms.Label();
            this.lbl_DateFin = new System.Windows.Forms.Label();
            this.lbl_DateDebut = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmotif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_AjoutModifPersonnel.SuspendLayout();
            this.gb_Gestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Absence)).BeginInit();
            this.gb_AjoutModifAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_AjoutModifPersonnel
            // 
            this.gb_AjoutModifPersonnel.Controls.Add(this.lbl_idPersonnelSelectedNb);
            this.gb_AjoutModifPersonnel.Controls.Add(this.lbl_idPersonnelSelected);
            this.gb_AjoutModifPersonnel.Controls.Add(this.btn_ModifierOuAjouterPersonnel);
            this.gb_AjoutModifPersonnel.Controls.Add(this.cb_ServiceAffectation);
            this.gb_AjoutModifPersonnel.Controls.Add(this.btn_RetourAjoutModifPersonnel);
            this.gb_AjoutModifPersonnel.Controls.Add(this.lbl_ServiceAffectation);
            this.gb_AjoutModifPersonnel.Controls.Add(this.lbl_Mail);
            this.gb_AjoutModifPersonnel.Controls.Add(this.lbl_Tel);
            this.gb_AjoutModifPersonnel.Controls.Add(this.lbl_Prenom);
            this.gb_AjoutModifPersonnel.Controls.Add(this.lbl_Nom);
            this.gb_AjoutModifPersonnel.Controls.Add(this.txtb_Mail);
            this.gb_AjoutModifPersonnel.Controls.Add(this.txtb_Tel);
            this.gb_AjoutModifPersonnel.Controls.Add(this.txtb_Prenom);
            this.gb_AjoutModifPersonnel.Controls.Add(this.txtb_Nom);
            this.gb_AjoutModifPersonnel.Location = new System.Drawing.Point(12, 22);
            this.gb_AjoutModifPersonnel.Name = "gb_AjoutModifPersonnel";
            this.gb_AjoutModifPersonnel.Size = new System.Drawing.Size(992, 526);
            this.gb_AjoutModifPersonnel.TabIndex = 1;
            this.gb_AjoutModifPersonnel.TabStop = false;
            this.gb_AjoutModifPersonnel.Text = "Ajout d\'un personnel";
            this.gb_AjoutModifPersonnel.Visible = false;
            // 
            // lbl_idPersonnelSelectedNb
            // 
            this.lbl_idPersonnelSelectedNb.AutoSize = true;
            this.lbl_idPersonnelSelectedNb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_idPersonnelSelectedNb.Location = new System.Drawing.Point(330, 33);
            this.lbl_idPersonnelSelectedNb.Name = "lbl_idPersonnelSelectedNb";
            this.lbl_idPersonnelSelectedNb.Size = new System.Drawing.Size(18, 15);
            this.lbl_idPersonnelSelectedNb.TabIndex = 11;
            this.lbl_idPersonnelSelectedNb.Text = "-1";
            // 
            // lbl_idPersonnelSelected
            // 
            this.lbl_idPersonnelSelected.AutoSize = true;
            this.lbl_idPersonnelSelected.Location = new System.Drawing.Point(157, 32);
            this.lbl_idPersonnelSelected.Name = "lbl_idPersonnelSelected";
            this.lbl_idPersonnelSelected.Size = new System.Drawing.Size(152, 15);
            this.lbl_idPersonnelSelected.TabIndex = 10;
            this.lbl_idPersonnelSelected.Text = "id du personnel séléctionné";
            // 
            // btn_ModifierOuAjouterPersonnel
            // 
            this.btn_ModifierOuAjouterPersonnel.Location = new System.Drawing.Point(330, 319);
            this.btn_ModifierOuAjouterPersonnel.Name = "btn_ModifierOuAjouterPersonnel";
            this.btn_ModifierOuAjouterPersonnel.Size = new System.Drawing.Size(121, 39);
            this.btn_ModifierOuAjouterPersonnel.TabIndex = 3;
            this.btn_ModifierOuAjouterPersonnel.Text = "Ajouter";
            this.btn_ModifierOuAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btn_ModifierOuAjouterPersonnel.Click += new System.EventHandler(this.btn_ModifierOuAjouterPersonnel_Click);
            // 
            // cb_ServiceAffectation
            // 
            this.cb_ServiceAffectation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ServiceAffectation.FormattingEnabled = true;
            this.cb_ServiceAffectation.Location = new System.Drawing.Point(330, 260);
            this.cb_ServiceAffectation.Name = "cb_ServiceAffectation";
            this.cb_ServiceAffectation.Size = new System.Drawing.Size(121, 23);
            this.cb_ServiceAffectation.TabIndex = 9;
            // 
            // btn_RetourAjoutModifPersonnel
            // 
            this.btn_RetourAjoutModifPersonnel.Location = new System.Drawing.Point(6, 22);
            this.btn_RetourAjoutModifPersonnel.Name = "btn_RetourAjoutModifPersonnel";
            this.btn_RetourAjoutModifPersonnel.Size = new System.Drawing.Size(144, 39);
            this.btn_RetourAjoutModifPersonnel.TabIndex = 2;
            this.btn_RetourAjoutModifPersonnel.Text = "Retour";
            this.btn_RetourAjoutModifPersonnel.UseVisualStyleBackColor = true;
            this.btn_RetourAjoutModifPersonnel.Click += new System.EventHandler(this.btn_RetourAjoutModifPersonnel_Click);
            // 
            // lbl_ServiceAffectation
            // 
            this.lbl_ServiceAffectation.AutoSize = true;
            this.lbl_ServiceAffectation.Location = new System.Drawing.Point(199, 263);
            this.lbl_ServiceAffectation.Name = "lbl_ServiceAffectation";
            this.lbl_ServiceAffectation.Size = new System.Drawing.Size(114, 15);
            this.lbl_ServiceAffectation.TabIndex = 8;
            this.lbl_ServiceAffectation.Text = "Service d\'affectation";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(279, 214);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(30, 15);
            this.lbl_Mail.TabIndex = 7;
            this.lbl_Mail.Text = "Mail";
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Location = new System.Drawing.Point(190, 160);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(123, 15);
            this.lbl_Tel.TabIndex = 6;
            this.lbl_Tel.Text = "Numéro de téléphone";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(264, 112);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(49, 15);
            this.lbl_Prenom.TabIndex = 5;
            this.lbl_Prenom.Text = "Prénom";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(279, 64);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(34, 15);
            this.lbl_Nom.TabIndex = 4;
            this.lbl_Nom.Text = "Nom";
            // 
            // txtb_Mail
            // 
            this.txtb_Mail.Location = new System.Drawing.Point(330, 211);
            this.txtb_Mail.Name = "txtb_Mail";
            this.txtb_Mail.Size = new System.Drawing.Size(121, 23);
            this.txtb_Mail.TabIndex = 3;
            // 
            // txtb_Tel
            // 
            this.txtb_Tel.Location = new System.Drawing.Point(330, 160);
            this.txtb_Tel.Name = "txtb_Tel";
            this.txtb_Tel.Size = new System.Drawing.Size(121, 23);
            this.txtb_Tel.TabIndex = 2;
            // 
            // txtb_Prenom
            // 
            this.txtb_Prenom.Location = new System.Drawing.Point(330, 109);
            this.txtb_Prenom.Name = "txtb_Prenom";
            this.txtb_Prenom.Size = new System.Drawing.Size(121, 23);
            this.txtb_Prenom.TabIndex = 1;
            // 
            // txtb_Nom
            // 
            this.txtb_Nom.Location = new System.Drawing.Point(330, 61);
            this.txtb_Nom.Name = "txtb_Nom";
            this.txtb_Nom.Size = new System.Drawing.Size(121, 23);
            this.txtb_Nom.TabIndex = 0;
            // 
            // gb_Gestion
            // 
            this.gb_Gestion.Controls.Add(this.btn_Actualiser);
            this.gb_Gestion.Controls.Add(this.dgv_Personnel);
            this.gb_Gestion.Controls.Add(this.dgv_Absence);
            this.gb_Gestion.Controls.Add(this.btn_GoModifierAbsence);
            this.gb_Gestion.Controls.Add(this.btn_SupprimerAbsence);
            this.gb_Gestion.Controls.Add(this.btn_GoAjouterAbsence);
            this.gb_Gestion.Controls.Add(this.btn_GoModifierPersonnel);
            this.gb_Gestion.Controls.Add(this.btn_SupprimerPersonnel);
            this.gb_Gestion.Controls.Add(this.btn_GoAjouterPersonnel);
            this.gb_Gestion.Location = new System.Drawing.Point(12, 22);
            this.gb_Gestion.Name = "gb_Gestion";
            this.gb_Gestion.Size = new System.Drawing.Size(992, 526);
            this.gb_Gestion.TabIndex = 2;
            this.gb_Gestion.TabStop = false;
            this.gb_Gestion.Text = "Gestion";
            // 
            // btn_Actualiser
            // 
            this.btn_Actualiser.Location = new System.Drawing.Point(433, 464);
            this.btn_Actualiser.Name = "btn_Actualiser";
            this.btn_Actualiser.Size = new System.Drawing.Size(133, 52);
            this.btn_Actualiser.TabIndex = 11;
            this.btn_Actualiser.Text = "Actualiser";
            this.btn_Actualiser.UseVisualStyleBackColor = true;
            this.btn_Actualiser.Click += new System.EventHandler(this.btn_Actualiser_Click);
            // 
            // dgv_Personnel
            // 
            this.dgv_Personnel.AllowUserToAddRows = false;
            this.dgv_Personnel.AllowUserToDeleteRows = false;
            this.dgv_Personnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Personnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.nom,
            this.prenom,
            this.tel,
            this.mail,
            this.idservice});
            this.dgv_Personnel.Location = new System.Drawing.Point(16, 34);
            this.dgv_Personnel.MultiSelect = false;
            this.dgv_Personnel.Name = "dgv_Personnel";
            this.dgv_Personnel.ReadOnly = true;
            this.dgv_Personnel.RowHeadersWidth = 20;
            this.dgv_Personnel.RowTemplate.Height = 25;
            this.dgv_Personnel.Size = new System.Drawing.Size(467, 397);
            this.dgv_Personnel.TabIndex = 10;
            this.dgv_Personnel.SelectionChanged += new System.EventHandler(this.dgv_Personnel_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 35;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prenom.HeaderText = "prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tel.HeaderText = "tel";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mail.HeaderText = "mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // idservice
            // 
            this.idservice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idservice.HeaderText = "service";
            this.idservice.Name = "idservice";
            this.idservice.ReadOnly = true;
            // 
            // dgv_Absence
            // 
            this.dgv_Absence.AllowUserToAddRows = false;
            this.dgv_Absence.AllowUserToDeleteRows = false;
            this.dgv_Absence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Absence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.DateDebut,
            this.DateFin,
            this.idmotif});
            this.dgv_Absence.Location = new System.Drawing.Point(509, 34);
            this.dgv_Absence.MultiSelect = false;
            this.dgv_Absence.Name = "dgv_Absence";
            this.dgv_Absence.ReadOnly = true;
            this.dgv_Absence.RowHeadersWidth = 20;
            this.dgv_Absence.RowTemplate.Height = 25;
            this.dgv_Absence.Size = new System.Drawing.Size(467, 397);
            this.dgv_Absence.TabIndex = 9;
            this.dgv_Absence.SelectionChanged += new System.EventHandler(this.dgv_Absence_SelectionChanged);
            // 
            // btn_GoModifierAbsence
            // 
            this.btn_GoModifierAbsence.Enabled = false;
            this.btn_GoModifierAbsence.Location = new System.Drawing.Point(582, 464);
            this.btn_GoModifierAbsence.Name = "btn_GoModifierAbsence";
            this.btn_GoModifierAbsence.Size = new System.Drawing.Size(133, 23);
            this.btn_GoModifierAbsence.TabIndex = 8;
            this.btn_GoModifierAbsence.Text = "Modifier";
            this.btn_GoModifierAbsence.UseVisualStyleBackColor = true;
            this.btn_GoModifierAbsence.Click += new System.EventHandler(this.btn_GoModifierAbsence_Click);
            // 
            // btn_SupprimerAbsence
            // 
            this.btn_SupprimerAbsence.Enabled = false;
            this.btn_SupprimerAbsence.Location = new System.Drawing.Point(737, 464);
            this.btn_SupprimerAbsence.Name = "btn_SupprimerAbsence";
            this.btn_SupprimerAbsence.Size = new System.Drawing.Size(133, 23);
            this.btn_SupprimerAbsence.TabIndex = 7;
            this.btn_SupprimerAbsence.Text = "Supprimer";
            this.btn_SupprimerAbsence.UseVisualStyleBackColor = true;
            this.btn_SupprimerAbsence.Click += new System.EventHandler(this.btn_SupprimerAbsence_Click);
            // 
            // btn_GoAjouterAbsence
            // 
            this.btn_GoAjouterAbsence.Enabled = false;
            this.btn_GoAjouterAbsence.Location = new System.Drawing.Point(659, 493);
            this.btn_GoAjouterAbsence.Name = "btn_GoAjouterAbsence";
            this.btn_GoAjouterAbsence.Size = new System.Drawing.Size(133, 23);
            this.btn_GoAjouterAbsence.TabIndex = 6;
            this.btn_GoAjouterAbsence.Text = "Ajouter Absence";
            this.btn_GoAjouterAbsence.UseVisualStyleBackColor = true;
            this.btn_GoAjouterAbsence.Click += new System.EventHandler(this.btn_GoAjouterAbsence_Click);
            // 
            // btn_GoModifierPersonnel
            // 
            this.btn_GoModifierPersonnel.Enabled = false;
            this.btn_GoModifierPersonnel.Location = new System.Drawing.Point(96, 464);
            this.btn_GoModifierPersonnel.Name = "btn_GoModifierPersonnel";
            this.btn_GoModifierPersonnel.Size = new System.Drawing.Size(133, 23);
            this.btn_GoModifierPersonnel.TabIndex = 5;
            this.btn_GoModifierPersonnel.Text = "Modifier";
            this.btn_GoModifierPersonnel.UseVisualStyleBackColor = true;
            this.btn_GoModifierPersonnel.Click += new System.EventHandler(this.btn_GoModifierPersonnel_Click);
            // 
            // btn_SupprimerPersonnel
            // 
            this.btn_SupprimerPersonnel.Location = new System.Drawing.Point(251, 464);
            this.btn_SupprimerPersonnel.Name = "btn_SupprimerPersonnel";
            this.btn_SupprimerPersonnel.Size = new System.Drawing.Size(133, 23);
            this.btn_SupprimerPersonnel.TabIndex = 4;
            this.btn_SupprimerPersonnel.Text = "Supprimer";
            this.btn_SupprimerPersonnel.UseVisualStyleBackColor = true;
            this.btn_SupprimerPersonnel.Click += new System.EventHandler(this.btn_SupprimerPersonnel_Click);
            // 
            // btn_GoAjouterPersonnel
            // 
            this.btn_GoAjouterPersonnel.Location = new System.Drawing.Point(173, 493);
            this.btn_GoAjouterPersonnel.Name = "btn_GoAjouterPersonnel";
            this.btn_GoAjouterPersonnel.Size = new System.Drawing.Size(133, 23);
            this.btn_GoAjouterPersonnel.TabIndex = 3;
            this.btn_GoAjouterPersonnel.Text = "Ajouter Personnel";
            this.btn_GoAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btn_GoAjouterPersonnel.Click += new System.EventHandler(this.btn_GoAjouterPersonnel_Click);
            // 
            // idpersonnel
            // 
            this.idpersonnel.HeaderText = "idpersonnel";
            this.idpersonnel.Name = "idpersonnel";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "idpersonnel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // gb_AjoutModifAbsence
            // 
            this.gb_AjoutModifAbsence.Controls.Add(this.dtp_DateFin);
            this.gb_AjoutModifAbsence.Controls.Add(this.dtp_DateDebut);
            this.gb_AjoutModifAbsence.Controls.Add(this.lbl_idPersonnelSelectedNbAbsence);
            this.gb_AjoutModifAbsence.Controls.Add(this.lbl_idPersonnelSelectedAbsence);
            this.gb_AjoutModifAbsence.Controls.Add(this.btn_ModifierOuAjouterAbsence);
            this.gb_AjoutModifAbsence.Controls.Add(this.cb_Motif);
            this.gb_AjoutModifAbsence.Controls.Add(this.btn_RetourAjoutModifAbsence);
            this.gb_AjoutModifAbsence.Controls.Add(this.lbl_Motif);
            this.gb_AjoutModifAbsence.Controls.Add(this.lbl_DateFin);
            this.gb_AjoutModifAbsence.Controls.Add(this.lbl_DateDebut);
            this.gb_AjoutModifAbsence.Location = new System.Drawing.Point(12, 22);
            this.gb_AjoutModifAbsence.Name = "gb_AjoutModifAbsence";
            this.gb_AjoutModifAbsence.Size = new System.Drawing.Size(992, 526);
            this.gb_AjoutModifAbsence.TabIndex = 3;
            this.gb_AjoutModifAbsence.TabStop = false;
            this.gb_AjoutModifAbsence.Text = "Ajout d\'une absence";
            this.gb_AjoutModifAbsence.Visible = false;
            // 
            // dtp_DateFin
            // 
            this.dtp_DateFin.Location = new System.Drawing.Point(330, 117);
            this.dtp_DateFin.Name = "dtp_DateFin";
            this.dtp_DateFin.Size = new System.Drawing.Size(200, 23);
            this.dtp_DateFin.TabIndex = 17;
            // 
            // dtp_DateDebut
            // 
            this.dtp_DateDebut.Location = new System.Drawing.Point(330, 71);
            this.dtp_DateDebut.Name = "dtp_DateDebut";
            this.dtp_DateDebut.Size = new System.Drawing.Size(200, 23);
            this.dtp_DateDebut.TabIndex = 16;
            // 
            // lbl_idPersonnelSelectedNbAbsence
            // 
            this.lbl_idPersonnelSelectedNbAbsence.AutoSize = true;
            this.lbl_idPersonnelSelectedNbAbsence.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_idPersonnelSelectedNbAbsence.Location = new System.Drawing.Point(330, 33);
            this.lbl_idPersonnelSelectedNbAbsence.Name = "lbl_idPersonnelSelectedNbAbsence";
            this.lbl_idPersonnelSelectedNbAbsence.Size = new System.Drawing.Size(18, 15);
            this.lbl_idPersonnelSelectedNbAbsence.TabIndex = 11;
            this.lbl_idPersonnelSelectedNbAbsence.Text = "-1";
            // 
            // lbl_idPersonnelSelectedAbsence
            // 
            this.lbl_idPersonnelSelectedAbsence.AutoSize = true;
            this.lbl_idPersonnelSelectedAbsence.Location = new System.Drawing.Point(157, 32);
            this.lbl_idPersonnelSelectedAbsence.Name = "lbl_idPersonnelSelectedAbsence";
            this.lbl_idPersonnelSelectedAbsence.Size = new System.Drawing.Size(152, 15);
            this.lbl_idPersonnelSelectedAbsence.TabIndex = 10;
            this.lbl_idPersonnelSelectedAbsence.Text = "id du personnel séléctionné";
            // 
            // btn_ModifierOuAjouterAbsence
            // 
            this.btn_ModifierOuAjouterAbsence.Location = new System.Drawing.Point(330, 196);
            this.btn_ModifierOuAjouterAbsence.Name = "btn_ModifierOuAjouterAbsence";
            this.btn_ModifierOuAjouterAbsence.Size = new System.Drawing.Size(121, 39);
            this.btn_ModifierOuAjouterAbsence.TabIndex = 3;
            this.btn_ModifierOuAjouterAbsence.Text = "Ajouter";
            this.btn_ModifierOuAjouterAbsence.UseVisualStyleBackColor = true;
            this.btn_ModifierOuAjouterAbsence.Click += new System.EventHandler(this.btn_ModifierOuAjouterAbsence_Click);
            // 
            // cb_Motif
            // 
            this.cb_Motif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Motif.FormattingEnabled = true;
            this.cb_Motif.Location = new System.Drawing.Point(330, 160);
            this.cb_Motif.Name = "cb_Motif";
            this.cb_Motif.Size = new System.Drawing.Size(121, 23);
            this.cb_Motif.TabIndex = 9;
            // 
            // btn_RetourAjoutModifAbsence
            // 
            this.btn_RetourAjoutModifAbsence.Location = new System.Drawing.Point(6, 22);
            this.btn_RetourAjoutModifAbsence.Name = "btn_RetourAjoutModifAbsence";
            this.btn_RetourAjoutModifAbsence.Size = new System.Drawing.Size(144, 39);
            this.btn_RetourAjoutModifAbsence.TabIndex = 2;
            this.btn_RetourAjoutModifAbsence.Text = "Retour";
            this.btn_RetourAjoutModifAbsence.UseVisualStyleBackColor = true;
            this.btn_RetourAjoutModifAbsence.Click += new System.EventHandler(this.btn_RetourAjoutModifAbsence_Click);
            // 
            // lbl_Motif
            // 
            this.lbl_Motif.AutoSize = true;
            this.lbl_Motif.Location = new System.Drawing.Point(273, 164);
            this.lbl_Motif.Name = "lbl_Motif";
            this.lbl_Motif.Size = new System.Drawing.Size(36, 15);
            this.lbl_Motif.TabIndex = 8;
            this.lbl_Motif.Text = "Motif";
            // 
            // lbl_DateFin
            // 
            this.lbl_DateFin.AutoSize = true;
            this.lbl_DateFin.Location = new System.Drawing.Point(261, 117);
            this.lbl_DateFin.Name = "lbl_DateFin";
            this.lbl_DateFin.Size = new System.Drawing.Size(48, 15);
            this.lbl_DateFin.TabIndex = 5;
            this.lbl_DateFin.Text = "Date fin";
            // 
            // lbl_DateDebut
            // 
            this.lbl_DateDebut.AutoSize = true;
            this.lbl_DateDebut.Location = new System.Drawing.Point(244, 77);
            this.lbl_DateDebut.Name = "lbl_DateDebut";
            this.lbl_DateDebut.Size = new System.Drawing.Size(65, 15);
            this.lbl_DateDebut.TabIndex = 4;
            this.lbl_DateDebut.Text = "Date début";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 35;
            // 
            // DateDebut
            // 
            this.DateDebut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateDebut.FillWeight = 57.78689F;
            this.DateDebut.HeaderText = "datedebut";
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.ReadOnly = true;
            // 
            // DateFin
            // 
            this.DateFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateFin.FillWeight = 57.78689F;
            this.DateFin.HeaderText = "datefin";
            this.DateFin.Name = "DateFin";
            this.DateFin.ReadOnly = true;
            // 
            // idmotif
            // 
            this.idmotif.FillWeight = 184.4262F;
            this.idmotif.HeaderText = "motif";
            this.idmotif.Name = "idmotif";
            this.idmotif.ReadOnly = true;
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 550);
            this.Controls.Add(this.gb_AjoutModifAbsence);
            this.Controls.Add(this.gb_Gestion);
            this.Controls.Add(this.gb_AjoutModifPersonnel);
            this.Name = "FormGestion";
            this.Text = "Gestion personnel";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.gb_AjoutModifPersonnel.ResumeLayout(false);
            this.gb_AjoutModifPersonnel.PerformLayout();
            this.gb_Gestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Absence)).EndInit();
            this.gb_AjoutModifAbsence.ResumeLayout(false);
            this.gb_AjoutModifAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_AjoutModifPersonnel;
        private TextBox txtb_Nom;
        private TextBox txtb_Prenom;
        private TextBox txtb_Mail;
        private TextBox txtb_Tel;
        private Label lbl_Mail;
        private Label lbl_Tel;
        private Label lbl_Prenom;
        private Label lbl_Nom;
        private ComboBox cb_ServiceAffectation;
        private Label lbl_ServiceAffectation;
        private Button btn_RetourAjoutModifPersonnel;
        private Button btn_ModifierOuAjouterPersonnel;
        private GroupBox gb_Gestion;
        private Button btn_GoModifierAbsence;
        private Button btn_SupprimerAbsence;
        private Button btn_GoAjouterAbsence;
        private Button btn_GoModifierPersonnel;
        private Button btn_SupprimerPersonnel;
        private Button btn_GoAjouterPersonnel;
        private DataGridView dgv_Absence;
        private DataGridViewTextBoxColumn idpersonnel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView dgv_Personnel;
        private Label lbl_idPersonnelSelectedNb;
        private Label lbl_idPersonnelSelected;
        private GroupBox gb_AjoutModifAbsence;
        private Label lbl_idPersonnelSelectedNbAbsence;
        private Label lbl_idPersonnelSelectedAbsence;
        private Button btn_ModifierOuAjouterAbsence;
        private ComboBox cb_Motif;
        private Button btn_RetourAjoutModifAbsence;
        private Label lbl_Motif;
        private Label lbl_DateFin;
        private Label lbl_DateDebut;
        private DateTimePicker dtp_DateDebut;
        private DateTimePicker dtp_DateFin;
        private Button btn_Actualiser;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn prenom;
        private DataGridViewTextBoxColumn tel;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn idservice;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn DateDebut;
        private DataGridViewTextBoxColumn DateFin;
        private DataGridViewTextBoxColumn idmotif;
    }
}