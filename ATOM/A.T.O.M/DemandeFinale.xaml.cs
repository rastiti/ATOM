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
    /// Logique d'interaction pour DemandeFinale.xaml
    /// </summary>
    public partial class DemandeFinale : Window
    {
        public DemandeFinale()
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

        private void Finaliser(object sender, RoutedEventArgs e)
        {
            FinalisationDemande demande = new FinalisationDemande();
            demande.ShowDialog();
        }
        
    }
}
