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
    }
}