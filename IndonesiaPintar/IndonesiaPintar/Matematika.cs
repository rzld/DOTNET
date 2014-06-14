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
         public class Matematika
    {
        public string Id { get; set; }
        public string Soal { get; set; }
        public string Jawaban { get; set; }
    }

    public static class MatematikaIsi
    {
        public static List<Matematika> items { get; set; }
        public static void MatematikaIsi()
        {
            items = new List<Matematika>()
            {
                new Matematika() { Id = "MTK1", Soal = "Matematika/MTK1.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK2", Soal = "Matematika/MTK2.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK3", Soal = "Matematika/MTK3.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK4", Soal = "Matematika/MTK4.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK5", Soal = "Matematika/MTK5.JPG",Jawaban = "D" },
                new Matematika() { Id = "MTK6", Soal = "Matematika/MTK6.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK7", Soal = "Matematika/MTK7.JPG",Jawaban = "D" },
                new Matematika() { Id = "MTK8", Soal = "Matematika/MTK8.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK9", Soal = "Matematika/MTK9.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK10", Soal = "Matematika/MTK10.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK11", Soal = "Matematika/MTK11.JPG",Jawaban = "D" },
                new Matematika() { Id = "MTK12", Soal = "Matematika/MTK12.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK13", Soal = "Matematika/MTK13.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK14", Soal = "Matematika/MTK14.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK15", Soal = "Matematika/MTK15.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK16", Soal = "Matematika/MTK16.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK17", Soal = "Matematika/MTK17.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK18", Soal = "Matematika/MTK18.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK19", Soal = "Matematika/MTK19.JPG",Jawaban = "A" }, 
                new Matematika() { Id = "MTK20", Soal = "Matematika/MTK20.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK21", Soal = "Matematika/MTK21.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK22", Soal = "Matematika/MTK22.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK23", Soal = "Matematika/MTK23.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK24", Soal = "Matematika/MTK24.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK25", Soal = "Matematika/MTK25.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK26", Soal = "Matematika/MTK26.JPG",Jawaban = "D" },
                new Matematika() { Id = "MTK27", Soal = "Matematika/MTK27.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK28", Soal = "Matematika/MTK28.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK29", Soal = "Matematika/MTK29.JPG",Jawaban = "D" },
                new Matematika() { Id = "MTK30", Soal = "Matematika/MTK30.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK31", Soal = "Matematika/MTK31.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK32", Soal = "Matematika/MTK32.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK33", Soal = "Matematika/MTK33.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK34", Soal = "Matematika/MTK34.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK35", Soal = "Matematika/MTK35.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK36", Soal = "Matematika/MTK36.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK37", Soal = "Matematika/MTK37.JPG",Jawaban = "D" },
                new Matematika() { Id = "MTK38", Soal = "Matematika/MTK38.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK39", Soal = "Matematika/MTK39.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK40", Soal = "Matematika/MTK40.JPG",Jawaban = "D" },
                new Matematika() { Id = "MTK41", Soal = "Matematika/MTK41.JPG",Jawaban = "B" },
                new Matematika() { Id = "MTK42", Soal = "Matematika/MTK42.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK43", Soal = "Matematika/MTK43.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK44", Soal = "Matematika/MTK44.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK45", Soal = "Matematika/MTK45.JPG",Jawaban = "A" },
                new Matematika() { Id = "MTK46", Soal = "Matematika/MTK46.JPG",Jawaban = "D" },
                new Matematika() { Id = "MTK47", Soal = "Matematika/MTK47.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK48", Soal = "Matematika/MTK48.JPG",Jawaban = "C" },
                new Matematika() { Id = "MTK49", Soal = "Matematika/MTK49.JPG",Jawaban = "D" },
                new Matematika() { Id = "MTK50", Soal = "Matematika/MTK50.JPG",Jawaban = "B" },
            
            };
        }
    }
    }
}
