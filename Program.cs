using MedTk86.Vue;
using MedTk86.dal;
using MedTk86.Controlleur;

namespace MedTk86
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MedTk86.dal.ConnectionBdd.ConnecterAvecBdd();
            FormGestion formGestion = new FormGestion();
            FormAuthentification formAuth = new FormAuthentification(formGestion);
            FormAuthController authController = new FormAuthController(formAuth);
            FormGestionController gestionControlleur = new FormGestionController(formGestion);
            Application.Run(formAuth);

            if(formAuth.succesAuth == true)
            {
                Application.Run(formGestion);
            }
            
        }
    }
}