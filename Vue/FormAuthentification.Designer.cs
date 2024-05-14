namespace MedTk86.Vue
{
    partial class FormAuthentification
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
            this.gb_Authentification = new System.Windows.Forms.GroupBox();
            this.btn_Connecter = new System.Windows.Forms.Button();
            this.lbl_Mdp = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txtb_Mdp = new System.Windows.Forms.TextBox();
            this.txtb_Login = new System.Windows.Forms.TextBox();
            this.gb_Authentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Authentification
            // 
            this.gb_Authentification.Controls.Add(this.btn_Connecter);
            this.gb_Authentification.Controls.Add(this.lbl_Mdp);
            this.gb_Authentification.Controls.Add(this.lbl_Login);
            this.gb_Authentification.Controls.Add(this.txtb_Mdp);
            this.gb_Authentification.Controls.Add(this.txtb_Login);
            this.gb_Authentification.Location = new System.Drawing.Point(12, 22);
            this.gb_Authentification.Name = "gb_Authentification";
            this.gb_Authentification.Size = new System.Drawing.Size(383, 321);
            this.gb_Authentification.TabIndex = 0;
            this.gb_Authentification.TabStop = false;
            this.gb_Authentification.Text = "Authentification";
            // 
            // btn_Connecter
            // 
            this.btn_Connecter.Location = new System.Drawing.Point(103, 219);
            this.btn_Connecter.Name = "btn_Connecter";
            this.btn_Connecter.Size = new System.Drawing.Size(263, 40);
            this.btn_Connecter.TabIndex = 4;
            this.btn_Connecter.Text = "Connecter";
            this.btn_Connecter.UseVisualStyleBackColor = true;
            this.btn_Connecter.Click += new System.EventHandler(this.btn_Connecter_Click);
            // 
            // lbl_Mdp
            // 
            this.lbl_Mdp.AutoSize = true;
            this.lbl_Mdp.Location = new System.Drawing.Point(20, 150);
            this.lbl_Mdp.Name = "lbl_Mdp";
            this.lbl_Mdp.Size = new System.Drawing.Size(77, 15);
            this.lbl_Mdp.TabIndex = 3;
            this.lbl_Mdp.Text = "Mot de passe";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(60, 104);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(37, 15);
            this.lbl_Login.TabIndex = 2;
            this.lbl_Login.Text = "Login";
            // 
            // txtb_Mdp
            // 
            this.txtb_Mdp.Location = new System.Drawing.Point(103, 147);
            this.txtb_Mdp.Name = "txtb_Mdp";
            this.txtb_Mdp.Size = new System.Drawing.Size(263, 23);
            this.txtb_Mdp.TabIndex = 1;
            // 
            // txtb_Login
            // 
            this.txtb_Login.Location = new System.Drawing.Point(103, 96);
            this.txtb_Login.Name = "txtb_Login";
            this.txtb_Login.Size = new System.Drawing.Size(263, 23);
            this.txtb_Login.TabIndex = 0;
            // 
            // FormAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 354);
            this.Controls.Add(this.gb_Authentification);
            this.MaximizeBox = false;
            this.Name = "FormAuthentification";
            this.Text = "FormAuthentification";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.gb_Authentification.ResumeLayout(false);
            this.gb_Authentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_Authentification;
        private TextBox txtb_Mdp;
        private TextBox txtb_Login;
        private Label lbl_Mdp;
        private Label lbl_Login;
        private Button btn_Connecter;
    }
}