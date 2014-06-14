using System;
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
            BahasaIndonesiaIsi.Isiindong();
            IPAIsi.isiIPA();
            // tambahin mtk sama ipa
        }

        // tombol Matematika
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListSoal.xaml?Pelajaran=Matematika ", UriKind.Relative));
        }

        // tombol Bahasa Indonesia
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListSoal.xaml?Pelajaran=B. Indonesia ", UriKind.Relative));
        }

        // tombol IPA
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListSoal.xaml?Pelajaran=IPA ", UriKind.Relative));
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