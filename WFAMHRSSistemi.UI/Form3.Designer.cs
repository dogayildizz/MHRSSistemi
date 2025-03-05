namespace WFAMHRSSistemi.UI
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstRandevular = new ListBox();
            btnRandevuOlustur = new Button();
            label1 = new Label();
            txtHastaAdiSoyadi = new TextBox();
            dtpTarih = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cmbDoktorlar = new ComboBox();
            label4 = new Label();
            txtSikayet = new TextBox();
            btnZRaporu = new Button();
            SuspendLayout();
            // 
            // lstRandevular
            // 
            lstRandevular.Font = new Font("Times New Roman", 12F);
            lstRandevular.FormattingEnabled = true;
            lstRandevular.ItemHeight = 22;
            lstRandevular.Location = new Point(88, 393);
            lstRandevular.Name = "lstRandevular";
            lstRandevular.Size = new Size(637, 180);
            lstRandevular.TabIndex = 0;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.BackColor = SystemColors.ButtonFace;
            btnRandevuOlustur.Font = new Font("Times New Roman", 12F);
            btnRandevuOlustur.Location = new Point(242, 329);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(228, 47);
            btnRandevuOlustur.TabIndex = 1;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = false;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(88, 54);
            label1.Name = "label1";
            label1.Size = new Size(148, 22);
            label1.TabIndex = 2;
            label1.Text = "Hasta Ad Soyad :";
            // 
            // txtHastaAdiSoyadi
            // 
            txtHastaAdiSoyadi.Font = new Font("Times New Roman", 12F);
            txtHastaAdiSoyadi.Location = new Point(242, 50);
            txtHastaAdiSoyadi.Name = "txtHastaAdiSoyadi";
            txtHastaAdiSoyadi.Size = new Size(483, 30);
            txtHastaAdiSoyadi.TabIndex = 3;
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Times New Roman", 12F);
            dtpTarih.Location = new Point(242, 86);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(483, 30);
            dtpTarih.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(88, 127);
            label2.Name = "label2";
            label2.Size = new Size(139, 22);
            label2.TabIndex = 2;
            label2.Text = "Doktor Seçiniz :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(88, 92);
            label3.Name = "label3";
            label3.Size = new Size(63, 22);
            label3.TabIndex = 2;
            label3.Text = "Tarih :";
            // 
            // cmbDoktorlar
            // 
            cmbDoktorlar.Font = new Font("Times New Roman", 12F);
            cmbDoktorlar.FormattingEnabled = true;
            cmbDoktorlar.Location = new Point(242, 124);
            cmbDoktorlar.Name = "cmbDoktorlar";
            cmbDoktorlar.Size = new Size(483, 30);
            cmbDoktorlar.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(88, 163);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 2;
            label4.Text = "Şikayet :";
            // 
            // txtSikayet
            // 
            txtSikayet.Font = new Font("Times New Roman", 12F);
            txtSikayet.Location = new Point(242, 160);
            txtSikayet.Multiline = true;
            txtSikayet.Name = "txtSikayet";
            txtSikayet.Size = new Size(483, 147);
            txtSikayet.TabIndex = 3;
            // 
            // btnZRaporu
            // 
            btnZRaporu.BackColor = SystemColors.ButtonFace;
            btnZRaporu.Font = new Font("Times New Roman", 12F);
            btnZRaporu.Location = new Point(497, 329);
            btnZRaporu.Name = "btnZRaporu";
            btnZRaporu.Size = new Size(228, 47);
            btnZRaporu.TabIndex = 1;
            btnZRaporu.Text = "Z Raporu";
            btnZRaporu.UseVisualStyleBackColor = false;
            btnZRaporu.Click += btnZRaporu_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(813, 665);
            Controls.Add(cmbDoktorlar);
            Controls.Add(dtpTarih);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSikayet);
            Controls.Add(label4);
            Controls.Add(txtHastaAdiSoyadi);
            Controls.Add(label1);
            Controls.Add(btnZRaporu);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(lstRandevular);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstRandevular;
        private Button btnRandevuOlustur;
        private Label label1;
        private TextBox txtHastaAdiSoyadi;
        private DateTimePicker dtpTarih;
        private Label label2;
        private Label label3;
        private ComboBox cmbDoktorlar;
        private Label label4;
        private TextBox txtSikayet;
        private Button btnZRaporu;
    }
}