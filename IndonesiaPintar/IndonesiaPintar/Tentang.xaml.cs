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
    public partial class Tentang : PhoneApplicationPage
    {
        public Tentang()
        {
            InitializeComponent();
            textBlock1.Text = 
            "Indonesia Pintar Merupakan Applikasi yang membantu anak - anak Sekolah dasar untuk berlatih soal - soal Ujian Nasional. Soal terdiri dari mata pelajaran Matematika, Bahasa Indonesia dan IPA. terdapat dari 50 bulir soal tiap mata pelajaran yang bisa di jawab kemudian akan di beritahukanjawaban yang anda pilih benar atau salah. anda dapat pula melihat info ujian nasional dengan me-klik tombolnya. SELAMAT BELAJAR";
        }
    }
}