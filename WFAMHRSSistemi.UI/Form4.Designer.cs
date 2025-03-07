namespace WFAMHRSSistemi.UI
{
    partial class Form4
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
            lvZRaporu = new ListView();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            btnDokumanOlustur = new Button();
            SuspendLayout();
            // 
            // lvZRaporu
            // 
            lvZRaporu.Font = new Font("Times New Roman", 10.8F);
            lvZRaporu.Location = new Point(49, 134);
            lvZRaporu.Name = "lvZRaporu";
            lvZRaporu.Size = new Size(698, 303);
            lvZRaporu.TabIndex = 0;
            lvZRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Font = new Font("Times New Roman", 10.8F);
            dtpBaslangic.Location = new Point(104, 49);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(251, 28);
            dtpBaslangic.TabIndex = 1;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Font = new Font("Times New Roman", 10.8F);
            dtpBitis.Location = new Point(434, 49);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(251, 28);
            dtpBitis.TabIndex = 1;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // btnDokumanOlustur
            // 
            btnDokumanOlustur.BackColor = SystemColors.ButtonFace;
            btnDokumanOlustur.Font = new Font("Times New Roman", 10.8F);
            btnDokumanOlustur.Location = new Point(570, 466);
            btnDokumanOlustur.Name = "btnDokumanOlustur";
            btnDokumanOlustur.Size = new Size(177, 66);
            btnDokumanOlustur.TabIndex = 2;
            btnDokumanOlustur.Text = "Döküman Oluştur";
            btnDokumanOlustur.UseVisualStyleBackColor = false;
            btnDokumanOlustur.Click += btnDokumanOlustur_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(813, 559);
            Controls.Add(btnDokumanOlustur);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(lvZRaporu);
            Name = "Form4";
            Text = "Döküman";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvZRaporu;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private Button btnDokumanOlustur;
    }
}