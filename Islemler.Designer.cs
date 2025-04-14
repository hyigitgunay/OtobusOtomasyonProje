namespace OtobüsOtomasyonProje
{
    partial class Islemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Islemler));
            BtnOtobus = new Button();
            BtnBilet = new Button();
            BtnSefer = new Button();
            BtnCıkıs = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // BtnOtobus
            // 
            BtnOtobus.BackgroundImage = (Image)resources.GetObject("BtnOtobus.BackgroundImage");
            BtnOtobus.BackgroundImageLayout = ImageLayout.Stretch;
            BtnOtobus.Location = new Point(236, 53);
            BtnOtobus.Name = "BtnOtobus";
            BtnOtobus.Size = new Size(92, 82);
            BtnOtobus.TabIndex = 0;
            BtnOtobus.UseVisualStyleBackColor = true;
            BtnOtobus.Click += BtnOtobus_Click;
            // 
            // BtnBilet
            // 
            BtnBilet.BackgroundImage = (Image)resources.GetObject("BtnBilet.BackgroundImage");
            BtnBilet.BackgroundImageLayout = ImageLayout.Stretch;
            BtnBilet.Location = new Point(6, 53);
            BtnBilet.Name = "BtnBilet";
            BtnBilet.Size = new Size(92, 82);
            BtnBilet.TabIndex = 1;
            BtnBilet.UseVisualStyleBackColor = true;
            BtnBilet.Click += BtnBilet_Click;
            // 
            // BtnSefer
            // 
            BtnSefer.BackgroundImage = (Image)resources.GetObject("BtnSefer.BackgroundImage");
            BtnSefer.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSefer.Location = new Point(6, 216);
            BtnSefer.Name = "BtnSefer";
            BtnSefer.Size = new Size(92, 82);
            BtnSefer.TabIndex = 2;
            BtnSefer.UseVisualStyleBackColor = true;
            BtnSefer.Click += BtnSefer_Click;
            // 
            // BtnCıkıs
            // 
            BtnCıkıs.BackgroundImage = (Image)resources.GetObject("BtnCıkıs.BackgroundImage");
            BtnCıkıs.BackgroundImageLayout = ImageLayout.Stretch;
            BtnCıkıs.Location = new Point(236, 216);
            BtnCıkıs.Name = "BtnCıkıs";
            BtnCıkıs.Size = new Size(92, 82);
            BtnCıkıs.TabIndex = 3;
            BtnCıkıs.UseVisualStyleBackColor = true;
            BtnCıkıs.Click += BtnCıkıs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 4;
            label1.Text = "Biletler";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 185);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 5;
            label2.Text = "Seferler";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(236, 185);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 6;
            label3.Text = "Çıkış";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(236, 22);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 7;
            label4.Text = "Araçlar";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(114, 73);
            label5.Name = "label5";
            label5.Size = new Size(105, 56);
            label5.TabIndex = 9;
            label5.Text = "Yolcuların\r\n Bilgileri";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(114, 132);
            button1.Name = "button1";
            button1.Size = new Size(105, 97);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Islemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(328, 325);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCıkıs);
            Controls.Add(BtnSefer);
            Controls.Add(BtnBilet);
            Controls.Add(BtnOtobus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Islemler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Islemler";
            Load += Islemler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnOtobus;
        private Button BtnBilet;
        private Button BtnSefer;
        private Button BtnCıkıs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}