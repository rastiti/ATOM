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
    /// Logique d'interaction pour CreationDemande.xaml
    /// </summary>
    public partial class CreationDemande : Window
    {
        public CreationDemande()
        {
            Calendar calendar = new Calendar();
            InitializeComponent();
        }
    }
}
