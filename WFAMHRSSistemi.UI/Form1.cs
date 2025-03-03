using WFAMHRSSistemi.UI.Models;

namespace WFAMHRSSistemi.UI
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            //MHRSSystem, hastalar�n hastane ve b�l�m se�erek doktorlardan randevu almas�n� sa�layan bir sistemdir. Randevu sonras� Z raporu olu�turma �zelli�i de bulunmaktad�r.




            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtBolumAciklamasi.Text) || String.IsNullOrWhiteSpace(txtBolumAdi.Text))
            {
                MessageBox.Show("B�l�m ad� ve b�l�m a��klamas� bo� ge�ilemez.");
            }
            try
            {
                Bolum bolum = new Bolum();
                bolum.Adi = txtBolumAdi.Text;
                bolum.Aciklama = txtBolumAciklamasi.Text;
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
            txtBolumAciklamasi.Text = txtBolumAdi.Text = String.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstBolumler.SelectedItem == null)
            {
                MessageBox.Show("L�tfen b�l�m se�iniz!!!");
                return;
            }
            lstBolumler.Items.Remove(lstBolumler.SelectedItem);
            MessageBox.Show("B�l�m ba�ar�yla silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(lstBolumler.SelectedItem == null)
            {
                MessageBox.Show("G�ncellemek istedi�iniz b�l�m� se�iniz.");
                return;
            }
            Bolum seciliBolum = (Bolum)lstBolumler.SelectedItem;

            seciliBolum.Adi = txtBolumAdi.Text;
            seciliBolum.Aciklama = txtBolumAciklamasi.Text;

            int index = lstBolumler.SelectedIndex;
            lstBolumler.Items[index] = seciliBolum;
            Temizle();
            
        }
    }
}
