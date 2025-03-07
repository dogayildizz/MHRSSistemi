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
            dtpBitis.MinDate = dtpBaslangic.Value;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lvZRaporu.View = View.Details;  //.View öğelerin nasıl gösterileceğini belirler. View.Details detaylı görünüm demek
            lvZRaporu.GridLines = true;  //satır ve sütun aralarındaki çizgilerin görünürlüğünü aktif ettik.
            lvZRaporu.Columns.Add("Hasta Adı Soyadı", 150, HorizontalAlignment.Center); //sütun ekledik : (sütunun başlığı, sütunun genişliği)
            lvZRaporu.Columns.Add("Bölüm Adı ", 180, HorizontalAlignment.Center);
            lvZRaporu.Columns.Add("Doktor Adı Soyadı", 160, HorizontalAlignment.Center);
            lvZRaporu.Columns.Add("Şikayet", 160,HorizontalAlignment.Center);
            lvZRaporu.Columns.Add("Tarih", 130, HorizontalAlignment.Center);
            
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
            //Bitiş tarihini, başlangıç tarihinden daha erken seçemesin diye, bitiş tarihinin minimumunu başlangıç tarihi yaptım.
            dtpBitis.MinDate = dtpBaslangic.Value;  
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void btnDokumanOlustur_Click(object sender, EventArgs e)
        {
            //Value property si kullanıcının yaptığı seçimi veya girdiyi almak için kullanılır.

            try
            {
                DateTime baslangicTarihi = dtpBaslangic.Value.Date;
                DateTime bitisTarihi = dtpBitis.Value.Date;
                ListeyiGuncelle(baslangicTarihi,bitisTarihi);

                //using, farklı namespace'lerdeki sınıfları ve fonksiyonları projemize dahil etmek için kullanılır.

                //Excel çalışma kitabı oluşturur ve işlem tamamlandıktan sonra otomatik temizlenmesini sağlar.
                using (var workbook = new XLWorkbook()) 
                {
                    //Worksheet, Excel dosyası (Workbook) içindeki tek bir sayfayı (sheet) ifade eder. AddWorksheet ile "Z Raporu" adında yeni bir sayfa(sheet) ekledik.
                    var workSheet = workbook.AddWorksheet("Z Raporu"); 

                    workSheet.Cell(1, 1).Value = "Hasta Adı Soyadı"; // Cell(satır,sütun) ==> excelde belirtilen konuma yazı yazdık.
                    workSheet.Cell(1, 2).Value = "Bölümü";
                    workSheet.Cell(1, 3).Value = "Doktor";
                    workSheet.Cell(1, 4).Value = "Şikayet";
                    workSheet.Cell(1, 5).Value = "Tarih";

                    int satir = 2;
                    foreach (ListViewItem item in lvZRaporu.Items)
                    {
                        //ListViewItem dan bilgileri alıyoruz, excele yazdırıyoruz.
                        workSheet.Cell(satir,1).Value = item.SubItems[0].Text; //SubItems[0] ==> 2. satırdaki ilk öğe.
                        workSheet.Cell(satir,2).Value = item.SubItems[1].Text;
                        workSheet.Cell(satir,3).Value = item.SubItems[2].Text;
                        workSheet.Cell(satir,4).Value = item.SubItems[3].Text;
                        workSheet.Cell(satir,5).Value = item.SubItems[4].Text;
                        satir++;
                    }

                    //SaveFileDialog, kullanıcının bir dosyayı kaydetmek için dosya adı ve konumu seçmesini sağlayan bir Windows bileşenidir.
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";   //Dosya türü
                        saveFileDialog.Title = "Excel Dosyasını Kaydet"; //Pencere başlığı
                        saveFileDialog.FileName = "ZRaporu.xlsx";    //Seçilen dosya adı ve yolu

                        if (saveFileDialog.ShowDialog() == DialogResult.OK) //Kullanıcı açılan pencerede OK(tamam,evet,vs.. bir onay tuşuna) basarsa: (DialogResult.OK bu anlama geliyor. Zıttı ise(onaylamama durumu)  DialogResult.Cancel)
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath); //Oluşturduğumuz workbook u (excel dosyasını), kullanıcının belirlediği konuma kaydet.
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
