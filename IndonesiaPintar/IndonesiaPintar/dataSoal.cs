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

namespace IndonesiaPintar
{
    [Table]
    public class dataSoal
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity")]
        public int idSoal { get; set; }

        [Column]
        public String maPel { get; set; }

        [Column]
        public String Soal { get; set; }

        [Column]
        public String JawabanA { get; set; }

        [Column]
        public String JawabanB { get; set; }

        [Column]
        public String JawabanC { get; set; }

        [Column]
        public String JawabanD { get; set; }

        [Column]
        public String JawabanBenar { get; set; }
       

    }

    public class dataSoalContext : DataContext
    {
        public Table<dataSoal> Soal;
        public dataSoalContext(string connectionstring) : base(connectionstring) { }
    }
}
