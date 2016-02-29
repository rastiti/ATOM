using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BibDeClasses;

namespace ATOM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Quitter(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Valider(object sender, RoutedEventArgs e)
        {


            DataBaseManager dbm = DataBaseManager.getInstance();
            String log = login.Text;
            String pass = password.Password;
            Console.WriteLine("login: " + log + " Password: " + pass);
            String query = ("SELECT * FROM utilisateur WHERE Login='" + log + "' AND Mdp='" + pass + "';");
            Console.WriteLine(query);
            var reader = dbm.executerRequete(query);
            Console.WriteLine(reader);

            if (reader == true)
            {
                //test pour savoir si la personne a accès a quelle fenetre

                //if(l'utilisateur est régulateur ou du service de soin )
                DemandeATraiter demande = new DemandeATraiter();
                Close();
                demande.ShowDialog();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects");
            }



        }
    }
}
