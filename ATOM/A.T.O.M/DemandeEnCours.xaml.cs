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
using System.Windows.Shapes;

namespace A.T.O.M
{
    /// <summary>
    /// Logique d'interaction pour DemandeEnCours.xaml
    /// </summary>
    public partial class DemandeEnCours : Window
    {
        public DemandeEnCours()
        {
            
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            
        }

        private void Creer(object sender, RoutedEventArgs e)
        {
            CreationDemande creer = new CreationDemande();
            if (creer.ShowDialog() == true)
            {
                
            }
        }

        private void Modifier(object sender, RoutedEventArgs e)
        {
            
        }

        private void Supprimer(object sender, RoutedEventArgs e)
        {
            Validation suppr = new Validation();
            suppr.ShowDialog();
            
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            Validation suppr = new Validation();
            suppr.ShowDialog();
            
        }

        private void Deconnexion(object sender, RoutedEventArgs e)
        {
            LoginPage login = new LoginPage();
            DialogResult = false;
            Close();
            login.ShowDialog();

        }

        private void DemandeATraiter(object sender, RoutedEventArgs e)
        {
            DemandeATraiter demande = new DemandeATraiter();
            DialogResult = false;
            Close();
            demande.ShowDialog();
        }
    }
}
