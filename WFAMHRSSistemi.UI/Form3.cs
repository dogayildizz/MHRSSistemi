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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Doktor[] doktorlarDizisi) : this()   //this() , önce parametre almayan constructor ı çalıştır sonra burayı çalıştır anlamına geliyor.
        {
            foreach (Doktor item in doktorlarDizisi)
            {
                cmbDoktorlar.Items.Add(item);
            }
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHastaAdiSoyadi.Text) || cmbDoktorlar == null || string.IsNullOrWhiteSpace(txtSikayet.Text))
            {
                MessageBox.Show("Hiçbir alan boş geçilemez!");
                return;
            }
            if (dtpTarih.Value < DateTime.Today)  //dtpTarih.Value kullanıcının seçtiği tarihi döndürür.
            {
                MessageBox.Show("Geçmiş tarihe randevu alamazınız!");
            }
            Hasta hasta = new Hasta()
            {
                AdSoyad = txtHastaAdiSoyadi.Text,
                Sikayet = txtSikayet.Text,
                Doktor = cmbDoktorlar.SelectedItem as Doktor,
            };
            Randevu randevu = new Randevu()
            {
                Hasta = hasta,
                Tarih = dtpTarih.Value.Date
            };
            lstRandevular.Items.Add(randevu);
            Temizle();
            MessageBox.Show("Randevu başarıyla oluşturuldu!");

        }
        private void Temizle()
        {
            txtHastaAdiSoyadi.Text = txtSikayet.Text = string.Empty;
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            Randevu[] randevular = new Randevu[lstRandevular.Items.Count];
            lstRandevular.Items.CopyTo(randevular, 0);  //lstRandevular ın itemlerini, randevular dizisine 0. indeksten başlayarak kopyala.

            Form4 form4 = new Form4(randevular);
            form4.ShowDialog();
        }
    }
}
