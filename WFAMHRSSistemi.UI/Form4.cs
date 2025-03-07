using ClosedXML.Excel;
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
    public partial class Form4 : Form
    {
        public Randevu[] randevular;
        public Form4(Randevu[] array) : this()
        {
            this.randevular = array;    //this kelimesi şuanki sınıfı temsil eder. (form4 sınıfında olduğumuz için form4 ü temsil ediyor.)  

            ListeyiGuncelle(DateTime.Today, DateTime.Today);
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lvZRaporu.View = View.Details;  //.View öğelerin nasıl gösterileceğini belirler. View.Details detaylı görünüm demek
            lvZRaporu.GridLines = true;  //satır ve sütun aralarındaki çizgilerin görünürlüğünü aktif ettik.
            lvZRaporu.Columns.Add("Hasta Adı Soyadı", 160); //sütun ekledik : (sütunun başlığı, sütunun genişliği)
            lvZRaporu.Columns.Add("Bölüm Adı ", 160);
            lvZRaporu.Columns.Add("Doktor Adı Soyadı", 160);
            lvZRaporu.Columns.Add("Şikayet", 160);
            lvZRaporu.Columns.Add("Tarih", 160);
        }
        private void ListeyiGuncelle(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            lvZRaporu.Items.Clear();


            //Where() metodu koleksiyonlar üzerinde filtreleme yapar. Parantez içine yazılan şartlara uyan koleksiyon elemanlarını geriye döndürür.

            var filtrelenmisRandevular = randevular
                .Where(r => r.Tarih.Date >= baslangicTarihi && r.Tarih.Date <= bitisTarihi)
                .ToList();

            foreach (var item in filtrelenmisRandevular)
            {
                //ListViewItem, ListView kontrolünde öğelerden oluşan sınıftır.

                //form4_load eventinde ListLiew oluşturduk ve sütunları isimlendirdik. Aynı sırayı koruyarak ListViewItem sınıfından oluşan nesneler ürettik.

                //randevu sınıfından oluşan nesnelerimizdeki verileri, ListViewItem sınıfından oluşan nesnelere aktardık.
                ListViewItem listViewItem = new ListViewItem(item.Hasta.AdSoyad);
                listViewItem.SubItems.Add(item.Hasta.Doktor.Bolum.ToString());
                listViewItem.SubItems.Add(item.Hasta.Doktor.ToString());
                listViewItem.SubItems.Add(item.Hasta.Sikayet);
                listViewItem.SubItems.Add(item.Tarih.ToShortDateString());


                lvZRaporu.Items.Add(listViewItem);  //Bu nesneleri ListView in itemlerine ekledik.
            }


        }
        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void btnDokumanOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dtpBaslangic.Value.Date;
                DateTime bitisTarihi = dtpBitis.Value.Date;
                ListeyiGuncelle(baslangicTarihi,bitisTarihi);

                using(var workbook = new XLWorkbook())
                {
                    var workSheet = workbook.AddWorksheet("Z Raporu");

                    workSheet.Cell(1, 1).Value = "Hasta Adı Soyadı";
                    workSheet.Cell(1, 2).Value = "Bölümü";
                    workSheet.Cell(1, 3).Value = "Doktor";
                    workSheet.Cell(1, 4).Value = "Şikayet";
                    workSheet.Cell(1, 5).Value = "Tarih";

                    int satir = 2;
                    foreach (ListViewItem item in lvZRaporu.Items)
                    {
                        workSheet.Cell(satir,1).Value = item.SubItems[0].Text;
                        workSheet.Cell(satir,2).Value = item.SubItems[1].Text;
                        workSheet.Cell(satir,3).Value = item.SubItems[2].Text;
                        workSheet.Cell(satir,4).Value = item.SubItems[3].Text;
                        workSheet.Cell(satir,5).Value = item.SubItems[4].Text;
                        satir++;
                    }
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*xlsx";
                        saveFileDialog.Title = "Excel Dosyasını Kaydet";
                        saveFileDialog.FileName = "ZRaporu.xlsx";

                        if(saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);
                            MessageBox.Show("Excel başarıyla oluşturuldu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
