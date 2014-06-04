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

    public class IPA
    {
        public string Id { get; set; }
        public string Soal { get; set; }
        public string Jawaban { get; set; }
    }

    public class IPAIsi
    {
        public List<IPA> items { get; set; }
        public IPAIsi()
        {
            this.items = new List<IPA>()
            {
                new IPA() { Id = "IPA1", Soal = "IPA/soal1ipa.PNG" ,Jawaban = "A" },
                new IPA() { Id = "IPA2", Soal = "IPA/soal2ipa.PNG",Jawaban = "D" },
                new IPA() { Id = "IPA3", Soal = "IPA/soal3ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA4", Soal = "IPA/soal4ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA5", Soal = "IPA/soal5ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA6", Soal = "IPA/soal6ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA7", Soal = "IPA/soal7ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA8", Soal = "IPA/soal8ipa.PNG",Jawaban = "D" },
                new IPA() { Id = "IPA9", Soal = "IPA/soal9ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA10", Soal = "IPA/soal10ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA11", Soal = "IPA/soal11ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA12", Soal = "IPA/soal12ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA13", Soal = "IPA/soal13ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA14", Soal = "IPA/soal14ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA15", Soal = "IPA/soal15ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA16", Soal = "IPA/soal16ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA17", Soal = "IPA/soal17ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA18", Soal = "IPA/soal18ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA19", Soal = "IPA/soal19ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA20", Soal = "IPA/soal20ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA21", Soal = "IPA/soal21ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA22", Soal = "IPA/soal22ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA23", Soal = "IPA/soal23ipa.PNG",Jawaban = "D" },
                new IPA() { Id = "IPA24", Soal = "IPA/soal24ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA25", Soal = "IPA/soal25ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA26", Soal = "IPA/soal26ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA27", Soal = "IPA/soal27ipa.PNG",Jawaban = "D" },
                new IPA() { Id = "IPA28", Soal = "IPA/soal28ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA29", Soal = "IPA/soal29ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA30", Soal = "IPA/soal30ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA31", Soal = "IPA/soal31ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA32", Soal = "IPA/soal32ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA33", Soal = "IPA/soal33ipa.PNG",Jawaban = "D" },
                new IPA() { Id = "IPA34", Soal = "IPA/soal34ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA35", Soal = "IPA/soal35ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA36", Soal = "IPA/soal36ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA37", Soal = "IPA/soal37ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA38", Soal = "IPA/soal38ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA39", Soal = "IPA/soal39ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA40", Soal = "IPA/soal40ipa.PNG",Jawaban = "D" },
                new IPA() { Id = "IPA41", Soal = "IPA/soal41ipa.PNG",Jawaban = "D" },
                new IPA() { Id = "IPA42", Soal = "IPA/soal42ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA43", Soal = "IPA/soal43ipa.PNG",Jawaban = "A" },
                new IPA() { Id = "IPA44", Soal = "IPA/soal44ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA45", Soal = "IPA/soal45ipa.PNG",Jawaban = "D" },
                new IPA() { Id = "IPA46", Soal = "IPA/soal46ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA47", Soal = "IPA/soal47ipa.PNG",Jawaban = "C" },
                new IPA() { Id = "IPA48", Soal = "IPA/soal48ipa.PNG",Jawaban = "D" },
                new IPA() { Id = "IPA49", Soal = "IPA/soal49ipa.PNG",Jawaban = "B" },
                new IPA() { Id = "IPA50", Soal = "IPA/soal50ipa.PNG",Jawaban = "B" },



            
            };
        }
    }


}