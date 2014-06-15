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
        //int i = 0;
        //int j = 0;
        string pelajaran, idsoal;
        public Soal()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
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

            if (pelajaran.Equals("IPA"))
            {
                IPA soal = new IPA();
                foreach (IPA a in IPAIsi.items)
                {
                    if (a.Id.Equals(idsoal))
                    {
                        soal = a;
                        break;
                    }
                }
                soalPanel.DataContext = soal;
            }

            if (pelajaran.Equals("Matematika"))
            {
                Matematika soal = new Matematika();
                foreach (Matematika m in MatematikaIsi.items)
                {
                    if (m.Id.Equals(idsoal))
                    {
                        soal = m;
                        break;
                    }
                }
                soalPanel.DataContext = soal;
            }
        }

        void cekJawaban(string Jawaban)
        { 
            if(pelajaran.Equals("B. Indonesia") && !SkorPemain.sudahBi.Contains(idsoal))
            {
                BahasaIndonesia soal = new BahasaIndonesia() ;
                foreach(BahasaIndonesia b in BahasaIndonesiaIsi.items)
                {
                    if(b.Id.Equals(idsoal))
                    {
                        if(Jawaban.Equals(b.Jawaban))
                        SkorPemain.skorBi++;
                        else
                            MessageBox.Show("Jawaban yang anda masukan SALAH, jawaban yang benar adalah " + b.Jawaban);
                    }
                }
                SkorPemain.sudahBi.Add(idsoal);
            }

            if (pelajaran.Equals("IPA") && !SkorPemain.sudahIPA.Contains(idsoal))
            {
                IPA soal = new IPA();
                foreach (IPA a in IPAIsi.items)
                {
                    if (a.Id.Equals(idsoal))
                    {
                       if(Jawaban.Equals(a.Jawaban))
                            SkorPemain.skorIpa++;
                       else
                           MessageBox.Show("Jawaban yang anda masukan SALAH, jawaban yang benar adalah " + a.Jawaban);
                    }
                }
                SkorPemain.sudahIPA.Add(idsoal);
            }

            if (pelajaran.Equals("Matematika") && !SkorPemain.sudahMtk.Contains(idsoal))
            {
                Matematika soal = new Matematika();
                
                foreach (Matematika m in MatematikaIsi.items)
                {
                    if (m.Id.Equals(idsoal))
                    {
                        if (Jawaban.Equals(m.Jawaban))
                            SkorPemain.skorMtk++;
                        else 
                            MessageBox.Show("Jawaban yang anda masukan SALAH, jawaban yang benar adalah "+m.Jawaban);
                    }
                }

                SkorPemain.sudahMtk.Add(idsoal);
            } 
        }

        //A
        private void button1_Click(object sender, RoutedEventArgs e)
        {
                cekJawaban("A");
        }
        //B
        private void button2_Click(object sender, RoutedEventArgs e)
        {

                cekJawaban("B");
        }
        //C
        private void button3_Click(object sender, RoutedEventArgs e)
        {

                cekJawaban("C");

        }
        //D
        private void button4_Click(object sender, RoutedEventArgs e)
        {

                cekJawaban("D");

        }



        //private void ZoomInButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (i < 2)
        //    {
        //        gambar.Height += 50;
        //        gambar.Width += 50;
        //        i++;
        //        j = i;
        //    }
        //}

        //private void ZoomOutButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (j > 0)
        //    {
        //        gambar.Height -= 50;
        //        gambar.Width -= 50;
        //        j--;
        //        i = j;
        //    }
        //}
    }

}