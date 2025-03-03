using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMHRSSistemi.UI
{
    public partial class Form2 : Form
    {

        public List<string> Bolumler = new List<string>();  //Form1den Form2 ye çekeceğiz.
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string item in Bolumler)
            {
                cmbBolumler.Items.Add(item);
            }

        }
    }
}
