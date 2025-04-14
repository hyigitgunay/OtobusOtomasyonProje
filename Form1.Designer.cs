namespace OtobüsOtomasyonProje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TxtAD = new TextBox();
            TxtŞifre = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(397, 205);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Ad : ";
            // 
            // TxtAD
            // 
            TxtAD.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtAD.Location = new Point(565, 205);
            TxtAD.Name = "TxtAD";
            TxtAD.Size = new Size(233, 38);
            TxtAD.TabIndex = 1;
            // 
            // TxtŞifre
            // 
            TxtŞifre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TxtŞifre.Location = new Point(565, 249);
            TxtŞifre.Name = "TxtŞifre";
            TxtŞifre.Size = new Size(233, 38);
            TxtŞifre.TabIndex = 3;
            TxtŞifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(477, 249);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 2;
            label2.Text = "Şifre : ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(565, 293);
            button1.Name = "button1";
            button1.Size = new Size(233, 60);
            button1.TabIndex = 4;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1178, 562);
            Controls.Add(button1);
            Controls.Add(TxtŞifre);
            Controls.Add(label2);
            Controls.Add(TxtAD);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtAD;
        private TextBox TxtŞifre;
        private Label label2;
        private Button button1;
    }
}
