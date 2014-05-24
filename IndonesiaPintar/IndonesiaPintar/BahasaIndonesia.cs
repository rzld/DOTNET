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
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Collections.Generic;


namespace IndonesiaPintar
{

    public class BahasaIndonesia
    {
        public string Id { get; set; }
        public string Soal { get; set; }
        public string Jawaban { get; set; }
    }

    public class BahasaIndonesiaIsi
    {
        public List<BahasaIndonesia> items { get; set; }
        public BahasaIndonesiaIsi()
        {
            this.items = new List<BahasaIndonesia>()
            {
                new BahasaIndonesia() { Id = "BI1", Soal = "Bind/Bind no 1.JPG" ,Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI2", Soal = "Bind/Bind no 2.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI3", Soal = "Bind/Bind no 3.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI4", Soal = "Bind/Bind no 4.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI5", Soal = "Bind/Bind no 5.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI6", Soal = "Bind/Bind no 6.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI7", Soal = "Bind/Bind no 7.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI8", Soal = "Bind/Bind no 8.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI9", Soal = "Bind/Bind no 9.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI10", Soal = "Bind/Bind no 10.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI11", Soal = "Bind/Bind no 11.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI12", Soal = "Bind/Bind no 12.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI13", Soal = "Bind/Bind no 13.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI14", Soal = "Bind/Bind no 14.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI15", Soal = "Bind/Bind no 15.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI16", Soal = "Bind/Bind no 16.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI17", Soal = "Bind/Bind no 17.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI18", Soal = "Bind/Bind no 18.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI19", Soal = "Bind/Bind no 19.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI20", Soal = "Bind/Bind no 20.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI21", Soal = "Bind/Bind no 21.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI22", Soal = "Bind/Bind no 22.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI23", Soal = "Bind/Bind no 23.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI24", Soal = "Bind/Bind no 24.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI25", Soal = "Bind/Bind no 25.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI26", Soal = "Bind/Bind no 26.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI27", Soal = "Bind/Bind no 27.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI28", Soal = "Bind/Bind no 28.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI29", Soal = "Bind/Bind no 29.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI30", Soal = "Bind/Bind no 30.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI31", Soal = "Bind/Bind no 31.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI32", Soal = "Bind/Bind no 32.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI33", Soal = "Bind/Bind no 33.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI34", Soal = "Bind/Bind no 34.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI35", Soal = "Bind/Bind no 35.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI36", Soal = "Bind/Bind no 36.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI37", Soal = "Bind/Bind no 37.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI38", Soal = "Bind/Bind no 38.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI39", Soal = "Bind/Bind no 39.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI40", Soal = "Bind/Bind no 40.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI41", Soal = "Bind/Bind no 41.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI42", Soal = "Bind/Bind no 42.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI43", Soal = "Bind/Bind no 43.JPG",Jawaban = "B" },
                new BahasaIndonesia() { Id = "BI44", Soal = "Bind/Bind no 44.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI45", Soal = "Bind/Bind no 45.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI46", Soal = "Bind/Bind no 46.JPG",Jawaban = "D" },
                new BahasaIndonesia() { Id = "BI47", Soal = "Bind/Bind no 47.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI48", Soal = "Bind/Bind no 48.JPG",Jawaban = "C" },
                new BahasaIndonesia() { Id = "BI49", Soal = "Bind/Bind no 49.JPG",Jawaban = "A" },
                new BahasaIndonesia() { Id = "BI50", Soal = "Bind/Bind no 50.JPG",Jawaban = "B" },



            
            };
        }
    }
  

}
