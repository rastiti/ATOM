﻿using System;
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
    /// Logique d'interaction pour CreationEquipage.xaml
    /// </summary>
    public partial class CreationEquipage : Window
    {
        public CreationEquipage()
        {
            InitializeComponent();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
           

            DemandeATraiter demande = new DemandeATraiter();
            DialogResult = false;
            Close();
            demande.ShowDialog();
            
            
        }
    }
}
