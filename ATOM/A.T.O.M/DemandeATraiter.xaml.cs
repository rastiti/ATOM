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

namespace ATOM
{
    /// <summary>
    /// Logique d'interaction pour DemandeATraiter.xaml
    /// </summary>
    public partial class DemandeATraiter : Window
    {
        public DemandeATraiter()
        {
            InitializeComponent();
        }

        private void Deconnexion(object sender, RoutedEventArgs e)
        {
            LoginPage login = new LoginPage();
            DialogResult = false;
            Close();
            login.ShowDialog();

        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            
        }

        private void CreationEquipage(object sender, RoutedEventArgs e)
        {
            CreationEquipage crea = new CreationEquipage();          
            crea.ShowDialog();
        }

        private void DemandeEnCours(object sender, RoutedEventArgs e)
        {
            DemandeEnCours demande = new DemandeEnCours();
            DialogResult = false;
            Close();
            demande.ShowDialog();
        }

        private void DemandeFinale(object sender, RoutedEventArgs e)
        {
            DemandeFinale demande = new DemandeFinale();
            DialogResult = false;
            Close();
            demande.ShowDialog();
        }
        private void SuppressionEquipage(object sender, RoutedEventArgs e)
        {
            SuppressionEquipage suppression = new SuppressionEquipage();
            suppression.ShowDialog();
        }
    }
}
