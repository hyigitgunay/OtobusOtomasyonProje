namespace OtobüsOtomasyonProje
{
    partial class Seferlercs
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            label4 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(544, 539);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(565, 111);
            label2.Name = "label2";
            label2.Size = new Size(150, 31);
            label2.TabIndex = 3;
            label2.Text = "Sefer Nereye";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(562, 187);
            label3.Name = "label3";
            label3.Size = new Size(143, 31);
            label3.TabIndex = 5;
            label3.Text = "Araç Plakası";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AKSARAY", "AMASYA", "ANKARA", "ANTALYA", "ARDAHAN", "ARTVİN", "AYDIN", "BALIKESİR", "BARTIN", "BATMAN", "BAYBURT", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM", "DENİZLİ", "DİYARBAKIR", "DÜZCE", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY", "IĞDIR", "ISPARTA", "İSTANBUL", "İZMİR", "KAHRAMANMARAŞ", "KARABÜK", "KARAMAN", "KARS", "KASTAMONU", "KAYSERİ", "KIRIKKALE", "KIRKLARELİ", "KIRŞEHİR", "KİLİS", "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "MARDİN", "MERSİN", "MUĞLA", "MUŞ", "NEVŞEHİR", "NİĞDE", "ORDU", "OSMANİYE", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "ŞANLIURFA", "ŞIRNAK", "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ", "UŞAK", "VAN", "YALOVA", "YOZGAT", "ZONGULDAK" });
            comboBox1.Location = new Point(565, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(361, 39);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(565, 221);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(358, 39);
            comboBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(562, 345);
            button1.Name = "button1";
            button1.Size = new Size(180, 100);
            button1.TabIndex = 9;
            button1.Text = "Sefer Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(754, 345);
            button2.Name = "button2";
            button2.Size = new Size(172, 100);
            button2.TabIndex = 10;
            button2.Text = "Sefer Sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(565, 451);
            button3.Name = "button3";
            button3.Size = new Size(361, 100);
            button3.TabIndex = 11;
            button3.Text = "Sefer Güncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            maskedTextBox2.Location = new Point(562, 70);
            maskedTextBox2.Mask = "00/00/0000 90:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(361, 38);
            maskedTextBox2.TabIndex = 13;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(562, 36);
            label4.Name = "label4";
            label4.Size = new Size(135, 31);
            label4.TabIndex = 12;
            label4.Text = "Sefer Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(562, 263);
            label1.Name = "label1";
            label1.Size = new Size(96, 31);
            label1.TabIndex = 14;
            label1.Text = "Sefer Id";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox4.Location = new Point(565, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(358, 34);
            textBox4.TabIndex = 15;
            // 
            // Seferlercs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 563);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(maskedTextBox2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Seferlercs";
            Text = "Seferlercs";
            Load += Seferlercs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private Label label1;
        private TextBox textBox4;
    }
}