using WFAMHRSSistemi.UI.Models;

namespace WFAMHRSSistemi.UI
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            //MHRSSystem, hastalarýn hastane ve bölüm seçerek doktorlardan randevu almasýný saðlayan bir sistemdir. Randevu sonrasý Z raporu oluþturma özelliði de bulunmaktadýr.




            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtBolumAciklamasi.Text) || String.IsNullOrWhiteSpace(txtBolumAdi.Text))
            {
                MessageBox.Show("Bölüm adý ve bölüm açýklamasý boþ geçilemez.");
            }
            try
            {
                Bolum bolum = new Bolum();
                bolum.Adi = txtBolumAdi.Text;
                bolum.Aciklama = txtBolumAciklamasi.Text;
                lstBolumler.Items.Add(bolum);
                MessageBox.Show("Bölüm baþarýyla eklenmiþtir.");
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
                MessageBox.Show("Lütfen bölüm seçiniz!!!");
                return;
            }
            lstBolumler.Items.Remove(lstBolumler.SelectedItem);
            MessageBox.Show("Bölüm baþarýyla silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(lstBolumler.SelectedItem == null)
            {
                MessageBox.Show("Güncellemek istediðiniz bölümü seçiniz.");
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
