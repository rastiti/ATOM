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

namespace ATOM
{
    /// <summary>
    /// Logique d'interaction pour SuppressionEquipage.xaml
    /// </summary>
    public partial class SuppressionEquipage : Window
    {
        public SuppressionEquipage()
        {
            InitializeComponent();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
