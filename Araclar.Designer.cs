namespace OtobüsOtomasyonProje
{
    partial class Araclar
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(572, 615);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(577, 8);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 1;
            label1.Text = "Araç Modeli";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(577, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(575, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 34);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(575, 94);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 3;
            label2.Text = "Araç Yılı";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(575, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 34);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(575, 185);
            label3.Name = "label3";
            label3.Size = new Size(143, 31);
            label3.TabIndex = 5;
            label3.Text = "Araç Plakası";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(577, 355);
            button1.Name = "button1";
            button1.Size = new Size(151, 78);
            button1.TabIndex = 7;
            button1.Text = "Araç Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(734, 355);
            button2.Name = "button2";
            button2.Size = new Size(150, 78);
            button2.TabIndex = 8;
            button2.Text = "Araç Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(576, 455);
            button3.Name = "button3";
            button3.Size = new Size(306, 78);
            button3.TabIndex = 9;
            button3.Text = "Araç Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox4.Location = new Point(577, 303);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 34);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(575, 269);
            label4.Name = "label4";
            label4.Size = new Size(89, 31);
            label4.TabIndex = 10;
            label4.Text = "Araç Id\r\n";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(576, 539);
            button4.Name = "button4";
            button4.Size = new Size(306, 78);
            button4.TabIndex = 12;
            button4.Text = "Excele Dönüştür";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Araclar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 639);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Araclar";
            Text = "Araclar";
            Load += Araclar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private Label label4;
        private Button button4;
    }
}