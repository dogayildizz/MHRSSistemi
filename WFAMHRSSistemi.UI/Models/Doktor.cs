using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAMHRSSistemi.UI.Models
{
    public class Doktor
    {
        public string AdSoyad { get; set; }
        public string TelNo { get; set; }
        public Bolum Bolum { get; set; }  //navigation property


    }
}
