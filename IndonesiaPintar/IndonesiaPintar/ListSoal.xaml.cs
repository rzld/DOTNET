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
    public partial class Page1 : PhoneApplicationPage
    {
        String pelajaran;
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
         
            NavigationContext.QueryString.TryGetValue("Pelajaran", out pelajaran);
            PageTitle.Text = pelajaran;
            
            if (pelajaran.Equals("B. Indonesia"))
            {
                listBox1.ItemsSource = BahasaIndonesiaIsi.items.ToList();
            }
            if (pelajaran.Equals("IPA"))
            {
                listBox1.ItemsSource = IPAIsi.items.ToList();
            }

            if (pelajaran.Equals("Matematika"))
            {
                listBox1.ItemsSource = MatematikaIsi.items.ToList();
            }
            //if mtk ipa
        }

        private void TextBlock_Tap(object sender, GestureEventArgs e)
        {
            String IdSoal = "";
            if (PageTitle.Text.Equals("B. Indonesia"))
                IdSoal = BahasaIndonesiaIsi.items.ElementAt(listBox1.SelectedIndex).Id;
            if (PageTitle.Text.Equals("IPA"))
                IdSoal = IPAIsi.items.ElementAt(listBox1.SelectedIndex).Id;
            if (PageTitle.Text.Equals("Matematika"))
                IdSoal = MatematikaIsi.items.ElementAt(listBox1.SelectedIndex).Id;
           
            //if mtk ipa
            NavigationService.Navigate(new Uri("/Soal.xaml?Pelajaran=" + PageTitle.Text + "&IdSoal=" + IdSoal, UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int skor=0;
            if (pelajaran.Equals("B. Indonesia"))
            {
                skor = SkorPemain.skorBi * 2;
            }

            if (pelajaran.Equals("IPA"))
            {
                skor = SkorPemain.skorIpa * 2;
            }

            if (pelajaran.Equals("Matematika"))
            {
                skor = SkorPemain.skorMtk * 2;
            }
            MessageBox.Show("Skor kamu adalah " + skor);

        }  

    }
}