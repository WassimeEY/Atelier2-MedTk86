using MedTk86.Controlleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace MedTk86.Vue
{
    /// <summary>
    /// Cette classe de la vue passe par son controlleur FormAuthController pour récupérer les données de la bdd permettant l'authentification
    /// </summary>
    public partial class FormAuthentification : Form
    {
        private FormAuthController formAuthControllerRef = null;
        private FormGestion formGestionRef;
        public bool succesAuth = false;

        /// <summary>
        /// Constructeur qui permet de créer la référence avec le controlleur
        /// </summary>
        /// <param name="frmGestionRef"></param>
        public FormAuthentification(FormGestion frmGestionRef)
        {
            formGestionRef = frmGestionRef;
            formAuthControllerRef = FormAuthController.GetFormAuthInstance(this);
            InitializeComponent();
        }

        /// <summary>
        /// Execute la fonction Authentifier après le clique
        /// </summary>
        private void btn_Connecter_Click(object sender, EventArgs e)
        {
            Authentifier();
        }

        /// <summary>
        /// Compare le login entré et le login stocké dans la seule ligne de la table responsable, de même pour le mot de passe, le mdp entré est haché en utilisant SHA256 pour la comparaison
        /// </summary>
        private void Authentifier()
        {
            if (txtb_Login.Text != "" && txtb_Mdp.Text != "")
            {
                string correctLogin = (string)formAuthControllerRef.GetLoginEtMdp()[0][0];
                string correctMdpHache = (string)formAuthControllerRef.GetLoginEtMdp()[0][1];
                string mdpEntreeHache = txtb_Mdp.Text;
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(mdpEntreeHache));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte unByte in bytes)
                    {
                        builder.Append(unByte.ToString("x2"));
                    }
                    mdpEntreeHache = builder.ToString();
                }
                if (txtb_Login.Text == correctLogin && mdpEntreeHache == correctMdpHache)
                {
                    succesAuth = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Mauvais mot de passe", "Erreur", MessageBoxButtons.OK);
                    txtb_Mdp.Text = "";
                    txtb_Login.Text = "";
                }
            }
        }
    }
}
