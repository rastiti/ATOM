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
    /// Logique d'interaction pour CreationDemande.xaml
    /// </summary>
    public partial class CreationDemande : Window
    {
        public String valeurPriorite;

        public CreationDemande()
        {
            Calendar calendar = new Calendar();
            InitializeComponent();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }


        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            valeurPriorite = (sender as RadioButton).Content.ToString();
            //Récupère la valeur du radiobutton  
        }


    }
}
