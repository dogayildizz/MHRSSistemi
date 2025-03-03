namespace WFAMHRSSistemi.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGec = new Button();
            txtBolumAdi = new TextBox();
            label1 = new Label();
            lstBolumler = new ListBox();
            btnGuncelle = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            label2 = new Label();
            txtBolumAciklamasi = new TextBox();
            SuspendLayout();
            // 
            // btnGec
            // 
            btnGec.BackColor = SystemColors.ActiveCaption;
            btnGec.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGec.Location = new Point(523, 490);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(200, 50);
            btnGec.TabIndex = 0;
            btnGec.Text = "Geç";
            btnGec.UseVisualStyleBackColor = false;
            btnGec.Click += btnGec_Click;
            // 
            // txtBolumAdi
            // 
            txtBolumAdi.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBolumAdi.Location = new Point(247, 64);
            txtBolumAdi.Name = "txtBolumAdi";
            txtBolumAdi.Size = new Size(476, 28);
            txtBolumAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(73, 67);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 2;
            label1.Text = "Bölüm Adı :";
            // 
            // lstBolumler
            // 
            lstBolumler.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstBolumler.FormattingEnabled = true;
            lstBolumler.ItemHeight = 22;
            lstBolumler.Location = new Point(73, 246);
            lstBolumler.Name = "lstBolumler";
            lstBolumler.Size = new Size(650, 224);
            lstBolumler.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ButtonFace;
            btnGuncelle.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(523, 174);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(200, 55);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ButtonFace;
            btnEkle.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(73, 174);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 55);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonFace;
            btnSil.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(296, 174);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(200, 55);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(73, 103);
            label2.Name = "label2";
            label2.Size = new Size(168, 22);
            label2.TabIndex = 2;
            label2.Text = "Bölüm Açıklaması :";
            // 
            // txtBolumAciklamasi
            // 
            txtBolumAciklamasi.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBolumAciklamasi.Location = new Point(247, 100);
            txtBolumAciklamasi.Multiline = true;
            txtBolumAciklamasi.Name = "txtBolumAciklamasi";
            txtBolumAciklamasi.Size = new Size(476, 68);
            txtBolumAciklamasi.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(813, 559);
            Controls.Add(lstBolumler);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBolumAciklamasi);
            Controls.Add(txtBolumAdi);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnGec);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGec;
        private TextBox txtBolumAdi;
        private Label label1;
        private ListBox lstBolumler;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnSil;
        private Label label2;
        private TextBox txtBolumAciklamasi;
    }
}
