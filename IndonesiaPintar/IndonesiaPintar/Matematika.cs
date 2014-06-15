using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace IndonesiaPintar
{
    public class Matematika
    {
        public string Id { get; set; }
        public string Soal { get; set; }
        public string Jawaban { get; set; }
    }

    public static class MatematikaIsi
    {
        public static List<Matematika> items { get; set; }
        public static void IsiMTK()
        {
            items = new List<Matematika>()
            {
                new Matematika() { Id = "MTK1", Soal = "Matematika/MTK1.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK2", Soal = "Matematika/MTK2.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK3", Soal = "Matematika/MTK3.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK4", Soal = "Matematika/MTK4.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK5", Soal = "Matematika/MTK5.PNG",Jawaban = "D" },
                new Matematika() { Id = "MTK6", Soal = "Matematika/MTK6.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK7", Soal = "Matematika/MTK7.PNG",Jawaban = "D" },
                new Matematika() { Id = "MTK8", Soal = "Matematika/MTK8.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK9", Soal = "Matematika/MTK9.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK10", Soal = "Matematika/MTK10.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK11", Soal = "Matematika/MTK11.PNG",Jawaban = "D" },
                new Matematika() { Id = "MTK12", Soal = "Matematika/MTK12.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK13", Soal = "Matematika/MTK13.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK14", Soal = "Matematika/MTK14.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK15", Soal = "Matematika/MTK15.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK16", Soal = "Matematika/MTK16.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK17", Soal = "Matematika/MTK17.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK18", Soal = "Matematika/MTK18.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK19", Soal = "Matematika/MTK19.PNG",Jawaban = "A" }, 
                new Matematika() { Id = "MTK20", Soal = "Matematika/MTK20.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK21", Soal = "Matematika/MTK21.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK22", Soal = "Matematika/MTK22.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK23", Soal = "Matematika/MTK23.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK24", Soal = "Matematika/MTK24.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK25", Soal = "Matematika/MTK25.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK26", Soal = "Matematika/MTK26.PNG",Jawaban = "D" },
                new Matematika() { Id = "MTK27", Soal = "Matematika/MTK27.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK28", Soal = "Matematika/MTK28.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK29", Soal = "Matematika/MTK29.PNG",Jawaban = "D" },
                new Matematika() { Id = "MTK30", Soal = "Matematika/MTK30.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK31", Soal = "Matematika/MTK31.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK32", Soal = "Matematika/MTK32.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK33", Soal = "Matematika/MTK33.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK34", Soal = "Matematika/MTK34.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK35", Soal = "Matematika/MTK35.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK36", Soal = "Matematika/MTK36.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK37", Soal = "Matematika/MTK37.PNG",Jawaban = "D" },
                new Matematika() { Id = "MTK38", Soal = "Matematika/MTK38.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK39", Soal = "Matematika/MTK39.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK40", Soal = "Matematika/MTK40.PNG",Jawaban = "D" },
                new Matematika() { Id = "MTK41", Soal = "Matematika/MTK41.PNG",Jawaban = "B" },
                new Matematika() { Id = "MTK42", Soal = "Matematika/MTK42.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK43", Soal = "Matematika/MTK43.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK44", Soal = "Matematika/MTK44.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK45", Soal = "Matematika/MTK45.PNG",Jawaban = "A" },
                new Matematika() { Id = "MTK46", Soal = "Matematika/MTK46.PNG",Jawaban = "D" },
                new Matematika() { Id = "MTK47", Soal = "Matematika/MTK47.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK48", Soal = "Matematika/MTK48.PNG",Jawaban = "C" },
                new Matematika() { Id = "MTK49", Soal = "Matematika/MTK49.PNG",Jawaban = "D" },
                new Matematika() { Id = "MTK50", Soal = "Matematika/MTK50.PNG",Jawaban = "B" },
            
            };
        }
    }
 }

