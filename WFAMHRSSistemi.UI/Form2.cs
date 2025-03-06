using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAMHRSSistemi.UI.Models;

namespace WFAMHRSSistemi.UI
{
    public partial class Form2 : Form
    {

        public List<Bolum> Bolumler = new List<Bolum>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Bolum item in Bolumler)
            {
                cmbBolumler.Items.Add(item);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoktorAdiSoyadi.Text) || string.IsNullOrWhiteSpace(mtxtDoktorTelNo.Text))
            {
                MessageBox.Show("Doktor adı ve telefon numarası boş geçilemez.");
                return;
            }
            if (cmbBolumler.SelectedItem == null)
            {
                MessageBox.Show("Bölüm seçmek zorunludur!");
                return;
            }
            try
            {
                Doktor doktor = new Doktor();
                doktor.AdSoyad = txtDoktorAdiSoyadi.Text;
                doktor.TelNo = mtxtDoktorTelNo.Text;
                doktor.Bolum = (Bolum)cmbBolumler.SelectedItem;
                lstDoktorlar.Items.Add(doktor);
                MessageBox.Show("Doktor başarıyla eklenmiştir.");
            }
            catch (Exception)
            {

                throw;
            }
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Güncellemek istediğiniz bölümü seçiniz.");
                return;
            }
            Doktor seciliDoktor = lstDoktorlar.SelectedItem as Doktor;  //(Doktor)lstDoktorlar.SelectedItem;  da yazabilirdik.Ama hata fırlatabilir. as ile cast yapmak daha güvenilir bir yol. 

            seciliDoktor.AdSoyad = txtDoktorAdiSoyadi.Text;
            seciliDoktor.TelNo = mtxtDoktorTelNo.Text;

            lstDoktorlar.Items[lstDoktorlar.SelectedIndex] = seciliDoktor;
            Temizle();
        }
        private void Temizle()
        {
            txtDoktorAdiSoyadi.Text = mtxtDoktorTelNo.Text = String.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen doktorlar seçiniz!!!");
                return;
            }
            Doktor seciliDoktor =lstDoktorlar.SelectedItem as Doktor;



            lstDoktorlar.Items.Remove(lstDoktorlar.SelectedItem);
            MessageBox.Show("Doktor başarıyla silindi.");
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            // List ile de aktarım yapabilirdik. Bu da farklı bir yol. Ama genel olarak list ile aktarım yapmak daha güzel bir yol.Çünkü eleman ekleme silme daha kolay.
            Doktor[] doktorlar = new Doktor[0];                
            foreach (Doktor item in lstDoktorlar.Items)
            {
                //Her eleman eklemesi yaptığında yeniden bir dizi oluşturuyor. Performans açısından kötü.
                Array.Resize(ref doktorlar, doktorlar.Length+1);
                doktorlar[doktorlar.Length - 1] = item;
            }
            Form3 form3 = new Form3(doktorlar);
            form3.ShowDialog();
        }
    }
}
