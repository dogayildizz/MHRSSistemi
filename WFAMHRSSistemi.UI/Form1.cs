using WFAMHRSSistemi.UI.Models;

namespace WFAMHRSSistemi.UI
{
    public partial class Form1 : Form
    {

        List<Bolum> bolumlerListesi = new List<Bolum>();   
        public Form1()
        {
           InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text) || string.IsNullOrWhiteSpace(txtBolumAdi.Text))
            {
                MessageBox.Show("B�l�m ad� ve b�l�m a��klamas� bo� ge�ilemez.");
                return;
            }
            try
            {
                Bolum bolum = new Bolum();
                bolum.Adi = txtBolumAdi.Text;
                bolum.Aciklama = txtBolumAciklamasi.Text;
                bolumlerListesi.Add(bolum);          
                lstBolumler.Items.Add(bolum);
                MessageBox.Show("B�l�m ba�ar�yla eklenmi�tir.");
                Temizle();
            }
            catch (Exception)
            {
            }
       }
        private void Temizle()
        {
            txtBolumAciklamasi.Text = txtBolumAdi.Text = string.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstBolumler.SelectedItem == null)
            {
                MessageBox.Show("L�tfen b�l�m se�iniz!!!");
                return;
            }
            bolumlerListesi.Remove((Bolum)lstBolumler.SelectedItem);              
            lstBolumler.Items.Remove(lstBolumler.SelectedItem);
            MessageBox.Show("B�l�m ba�ar�yla silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstBolumler.SelectedItem == null)
            {
                MessageBox.Show("G�ncellemek istedi�iniz b�l�m� se�iniz.");
                return;
            }
            Bolum seciliBolum = (Bolum)lstBolumler.SelectedItem;

            txtBolumAdi.Text = seciliBolum.Adi;
            txtBolumAciklamasi.Text = seciliBolum.Aciklama;

            seciliBolum.Adi = txtBolumAdi.Text;
            seciliBolum.Aciklama = txtBolumAciklamasi.Text;

            lstBolumler.Items[lstBolumler.SelectedIndex] = seciliBolum;
            Temizle();

        }

        private void btnGec_Click(object sender, EventArgs e) 
        {
            Form2 form2 = new Form2();
            form2.Bolumler = bolumlerListesi;
            form2.ShowDialog();
        }
    }
}
