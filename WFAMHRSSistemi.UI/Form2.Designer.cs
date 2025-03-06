namespace WFAMHRSSistemi.UI
{
    partial class Form2
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
            cmbBolumler = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtDoktorAdiSoyadi = new TextBox();
            btnSil = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnGec = new Button();
            label3 = new Label();
            lstDoktorlar = new ListBox();
            mtxtDoktorTelNo = new MaskedTextBox();
            SuspendLayout();
            // 
            // cmbBolumler
            // 
            cmbBolumler.FormattingEnabled = true;
            cmbBolumler.Location = new Point(253, 129);
            cmbBolumler.Name = "cmbBolumler";
            cmbBolumler.Size = new Size(388, 28);
            cmbBolumler.Sorted = true;
            cmbBolumler.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(79, 94);
            label2.Name = "label2";
            label2.Size = new Size(162, 22);
            label2.TabIndex = 12;
            label2.Text = "Telefon Numarası :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(79, 58);
            label1.Name = "label1";
            label1.Size = new Size(170, 22);
            label1.TabIndex = 13;
            label1.Text = "Doktor Adı Soyadı :";
            // 
            // txtDoktorAdiSoyadi
            // 
            txtDoktorAdiSoyadi.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDoktorAdiSoyadi.Location = new Point(253, 56);
            txtDoktorAdiSoyadi.Name = "txtDoktorAdiSoyadi";
            txtDoktorAdiSoyadi.Size = new Size(388, 28);
            txtDoktorAdiSoyadi.TabIndex = 11;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonFace;
            btnSil.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(301, 176);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(200, 55);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ButtonFace;
            btnEkle.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(78, 176);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 55);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ButtonFace;
            btnGuncelle.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(528, 176);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(200, 55);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnGec
            // 
            btnGec.BackColor = SystemColors.ActiveCaption;
            btnGec.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGec.Location = new Point(528, 467);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(200, 50);
            btnGec.TabIndex = 9;
            btnGec.Text = "Geç";
            btnGec.UseVisualStyleBackColor = false;
            btnGec.Click += btnGec_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(79, 131);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 12;
            label3.Text = "Bölüm Seçiniz :";
            // 
            // lstDoktorlar
            // 
            lstDoktorlar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstDoktorlar.FormattingEnabled = true;
            lstDoktorlar.ItemHeight = 22;
            lstDoktorlar.Location = new Point(79, 237);
            lstDoktorlar.Name = "lstDoktorlar";
            lstDoktorlar.Size = new Size(650, 224);
            lstDoktorlar.TabIndex = 14;
            // 
            // mtxtDoktorTelNo
            // 
            mtxtDoktorTelNo.Location = new Point(253, 92);
            mtxtDoktorTelNo.Mask = "(999) 000-0000";
            mtxtDoktorTelNo.Name = "mtxtDoktorTelNo";
            mtxtDoktorTelNo.Size = new Size(117, 27);
            mtxtDoktorTelNo.TabIndex = 15;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(813, 559);
            Controls.Add(mtxtDoktorTelNo);
            Controls.Add(lstDoktorlar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDoktorAdiSoyadi);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnGec);
            Controls.Add(cmbBolumler);
            Name = "Form2";
            Text = "Doktor";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDoktorlar;
        private ComboBox cmbBolumler;
        private Label label2;
        private Label label1;
        private TextBox txtDoktorAdiSoyadi;
        private Button btnSil;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnGec;
        private Label label3;
        private MaskedTextBox mtxtDoktorTelNo;
    }
}