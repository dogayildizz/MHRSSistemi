using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAMHRSSistemi.UI.Models
{
    public class Randevu
    {
        public DateTime Tarih { get; set; }    
        public Hasta Hasta { get; set; }

        public override string ToString()
        {
            return Hasta +" "+Tarih.ToShortDateString();
        }
    }
}
