﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace IndonesiaPintar
{
    public partial class Main : PhoneApplicationPage
    {
        public Main()
        {
            InitializeComponent();
        }

        // tombol info UN
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            
        }

        // tombol tentang
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tentang.xaml", UriKind.Relative));
        }
    }
}