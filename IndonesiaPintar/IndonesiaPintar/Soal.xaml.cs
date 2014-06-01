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
    public partial class Soal : PhoneApplicationPage
    {
        public Soal()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string pelajaran, idsoal;
            NavigationContext.QueryString.TryGetValue("Pelajaran", out pelajaran);
            NavigationContext.QueryString.TryGetValue("IdSoal", out idsoal);
            if(pelajaran.Equals("B. Indonesia"))
            {
                BahasaIndonesia soal = new BahasaIndonesia() ;
                foreach(BahasaIndonesia b in BahasaIndonesiaIsi.items)
                {
                    if(b.Id.Equals(idsoal))
                    {
                        soal = b;
                        break;
                    }
                }
                soalPanel.DataContext = soal;
             
            }

        }
    }
}