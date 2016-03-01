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
            String query = "SELECT * FROM utilisateur WHERE Login='" + log + "' AND Mdp='" + pass + "';";
            //Console.WriteLine("login: " + log + " Password: " + pass);
            //Console.WriteLine("SELECT * FROM utilisateur WHERE Login=" + log + " AND Mdp=" + pass + ";");
            var reader = dbm.executerRequete(query);
            Console.WriteLine(reader);
            if (reader is Boolean)
                MessageBox.Show("Identifiant ou mot de passe incorrect");
            else if(reader is String)
                MessageBox.Show(reader);
            else {
                switch((String)reader[6]){
                    case "regulateur":
                        DemandeATraiter dat = new DemandeATraiter();
                        Close();
                        dat.ShowDialog();
                        break;
                    case "soin":
                        DemandeEnCours dec = new DemandeEnCours();
                        Close();
                        dec.ShowDialog();
                        break;
                    case "ambulancier":
                        DemandeFinale df = new DemandeFinale();
                        Close();
                        df.ShowDialog();
                        break;
                    case "admin":
                        //en attente fenetre création compte
                        //Close();
                        //demande.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Problème avec votre compte. Veuillez contacter l'administrateur.");
                        break;
                }
            }
        }
    }
}
