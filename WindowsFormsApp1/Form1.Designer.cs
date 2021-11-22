
namespace WindowsFormsApp1
{
    partial class Kasirapp
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
            this.KASIR = new System.Windows.Forms.Label();
            this.cb_jenisbarang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.HARGA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_bayar = new System.Windows.Forms.TextBox();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_totalharga = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kembalian = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_jumlahbarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_jumlah = new System.Windows.Forms.Label();
            this.tb_items = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // KASIR
            // 
            this.KASIR.AutoSize = true;
            this.KASIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KASIR.Location = new System.Drawing.Point(121, 29);
            this.KASIR.Name = "KASIR";
            this.KASIR.Size = new System.Drawing.Size(313, 37);
            this.KASIR.TabIndex = 0;
            this.KASIR.Text = "TOKO ALAT TULIS";
            this.KASIR.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.KASIR.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_jenisbarang
            // 
            this.cb_jenisbarang.DisplayMember = "None";
            this.cb_jenisbarang.FormattingEnabled = true;
            this.cb_jenisbarang.Items.AddRange(new object[] {
            "Pensil",
            "Pulpen",
            "Kertas",
            "Buku Tulis",
            "Penghapus",
            "Rautan",
            "Spidol",
            "Brush pen",
            "None"});
            this.cb_jenisbarang.Location = new System.Drawing.Point(222, 86);
            this.cb_jenisbarang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_jenisbarang.Name = "cb_jenisbarang";
            this.cb_jenisbarang.Size = new System.Drawing.Size(273, 28);
            this.cb_jenisbarang.TabIndex = 1;
            this.cb_jenisbarang.Text = "None";
            this.cb_jenisbarang.ValueMember = "None";
            this.cb_jenisbarang.SelectedIndexChanged += new System.EventHandler(this.cb_jenisbarang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "JENIS BARANG";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(222, 133);
            this.tb_harga.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(273, 27);
            this.tb_harga.TabIndex = 3;
            this.tb_harga.Text = "0";
            this.tb_harga.TextChanged += new System.EventHandler(this.tb_harga_TextChanged);
            // 
            // HARGA
            // 
            this.HARGA.AutoSize = true;
            this.HARGA.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HARGA.Location = new System.Drawing.Point(126, 138);
            this.HARGA.Name = "HARGA";
            this.HARGA.Size = new System.Drawing.Size(44, 20);
            this.HARGA.TabIndex = 4;
            this.HARGA.Text = "HARGA";
            this.HARGA.Click += new System.EventHandler(this.HARGA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAYAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_bayar
            // 
            this.tb_bayar.Location = new System.Drawing.Point(222, 292);
            this.tb_bayar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tb_bayar.Name = "tb_bayar";
            this.tb_bayar.Size = new System.Drawing.Size(273, 27);
            this.tb_bayar.TabIndex = 5;
            this.tb_bayar.TextChanged += new System.EventHandler(this.tb_bayar_TextChanged);
            // 
            // btn_hitung
            // 
            this.btn_hitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hitung.Location = new System.Drawing.Point(128, 430);
            this.btn_hitung.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(214, 74);
            this.btn_hitung.TabIndex = 7;
            this.btn_hitung.Text = "HITUNG";
            this.btn_hitung.UseVisualStyleBackColor = true;
            this.btn_hitung.Click += new System.EventHandler(this.btn_hitung_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(362, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 74);
            this.button1.TabIndex = 8;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_totalharga
            // 
            this.txt_totalharga.AutoSize = true;
            this.txt_totalharga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_totalharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalharga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_totalharga.Location = new System.Drawing.Point(543, 104);
            this.txt_totalharga.Name = "txt_totalharga";
            this.txt_totalharga.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.txt_totalharga.Size = new System.Drawing.Size(307, 85);
            this.txt_totalharga.TabIndex = 9;
            this.txt_totalharga.Text = "Rp. 100,000";
            this.txt_totalharga.Click += new System.EventHandler(this.txt_totalharga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Harga";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kembalian";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_kembalian
            // 
            this.txt_kembalian.AutoSize = true;
            this.txt_kembalian.BackColor = System.Drawing.Color.Black;
            this.txt_kembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kembalian.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_kembalian.Location = new System.Drawing.Point(543, 223);
            this.txt_kembalian.Name = "txt_kembalian";
            this.txt_kembalian.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.txt_kembalian.Size = new System.Drawing.Size(224, 69);
            this.txt_kembalian.TabIndex = 11;
            this.txt_kembalian.Text = "Rp. 100,000";
            this.txt_kembalian.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 911);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 76);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "JUMLAH";
            // 
            // tb_jumlahbarang
            // 
            this.tb_jumlahbarang.Location = new System.Drawing.Point(223, 180);
            this.tb_jumlahbarang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tb_jumlahbarang.Name = "tb_jumlahbarang";
            this.tb_jumlahbarang.Size = new System.Drawing.Size(272, 27);
            this.tb_jumlahbarang.TabIndex = 15;
            this.tb_jumlahbarang.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(804, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Jumlah";
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.AutoSize = true;
            this.txt_jumlah.BackColor = System.Drawing.Color.Black;
            this.txt_jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jumlah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_jumlah.Location = new System.Drawing.Point(794, 223);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.txt_jumlah.Size = new System.Drawing.Size(56, 69);
            this.txt_jumlah.TabIndex = 17;
            this.txt_jumlah.Text = "1";
            // 
            // tb_items
            // 
            this.tb_items.Location = new System.Drawing.Point(541, 296);
            this.tb_items.Multiline = true;
            this.tb_items.Name = "tb_items";
            this.tb_items.Size = new System.Drawing.Size(309, 126);
            this.tb_items.TabIndex = 19;
            // 
            // Kasirapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 527);
            this.Controls.Add(this.tb_items);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_jumlah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_jumlahbarang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kembalian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_totalharga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_hitung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_bayar);
            this.Controls.Add(this.HARGA);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_jenisbarang);
            this.Controls.Add(this.KASIR);
            this.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Kasirapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasir App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KASIR;
        private System.Windows.Forms.ComboBox cb_jenisbarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.Label HARGA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_bayar;
        private System.Windows.Forms.Button btn_hitung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_totalharga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_kembalian;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_jumlahbarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_jumlah;
        private System.Windows.Forms.TextBox tb_items;
    }
}

