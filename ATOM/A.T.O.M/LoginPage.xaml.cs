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
            //test pour savoir si la personne a accès a tel fenetre

            //if(l'utilisateur est régulateur ou du service de soin )
            DemandeATraiter demande = new DemandeATraiter();
            Close();
            if (demande.ShowDialog() == true)
            {
                   
            }
        }
    }
}
