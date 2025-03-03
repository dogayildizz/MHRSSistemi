using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAMHRSSistemi.UI.Models
{
    public class Bolum
    {
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public override string ToString()
        {
            return Adi+" : "+Aciklama;
        }

    }
}
