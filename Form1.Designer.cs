namespace Personel_Takip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonListele = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonMaxmaas = new System.Windows.Forms.Button();
            this.buttonMinmaas = new System.Windows.Forms.Button();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonAsgari = new System.Windows.Forms.Button();
            this.buttonAsgarifazla = new System.Windows.Forms.Button();
            this.buttonZam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(12, 12);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(394, 32);
            this.buttonListele.TabIndex = 0;
            this.buttonListele.Text = "Oluştur veya Listele";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 420);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(79, 490);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 26);
            this.textBox1.TabIndex = 3;
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(315, 488);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(91, 32);
            this.buttonAra.TabIndex = 4;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(412, 12);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(394, 32);
            this.buttonTemizle.TabIndex = 5;
            this.buttonTemizle.Text = "Listeyi Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonMaxmaas
            // 
            this.buttonMaxmaas.Location = new System.Drawing.Point(412, 76);
            this.buttonMaxmaas.Name = "buttonMaxmaas";
            this.buttonMaxmaas.Size = new System.Drawing.Size(194, 68);
            this.buttonMaxmaas.TabIndex = 6;
            this.buttonMaxmaas.Text = "En Yüksek Maaş Alan Personeli Göster";
            this.buttonMaxmaas.UseVisualStyleBackColor = true;
            this.buttonMaxmaas.Click += new System.EventHandler(this.buttonMaxmaas_Click);
            // 
            // buttonMinmaas
            // 
            this.buttonMinmaas.Location = new System.Drawing.Point(412, 186);
            this.buttonMinmaas.Name = "buttonMinmaas";
            this.buttonMinmaas.Size = new System.Drawing.Size(194, 68);
            this.buttonMinmaas.TabIndex = 7;
            this.buttonMinmaas.Text = "En Düşük Maaş Alan Personeli Göster";
            this.buttonMinmaas.UseVisualStyleBackColor = true;
            this.buttonMinmaas.Click += new System.EventHandler(this.buttonMinmaas_Click);
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(412, 294);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(194, 68);
            this.buttonTotal.TabIndex = 9;
            this.buttonTotal.Text = "Toplam Ödenen Maaş Tutarını Göster";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.Location = new System.Drawing.Point(612, 76);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(194, 68);
            this.buttonTop.TabIndex = 11;
            this.buttonTop.Text = "Toplam Personel";
            this.buttonTop.UseVisualStyleBackColor = true;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // buttonAsgari
            // 
            this.buttonAsgari.Location = new System.Drawing.Point(612, 186);
            this.buttonAsgari.Name = "buttonAsgari";
            this.buttonAsgari.Size = new System.Drawing.Size(194, 68);
            this.buttonAsgari.TabIndex = 12;
            this.buttonAsgari.Text = "Asgari Ücret Alan veya Düşük Alan Personeller";
            this.buttonAsgari.UseVisualStyleBackColor = true;
            this.buttonAsgari.Click += new System.EventHandler(this.buttonAsgari_Click);
            // 
            // buttonAsgarifazla
            // 
            this.buttonAsgarifazla.Location = new System.Drawing.Point(612, 294);
            this.buttonAsgarifazla.Name = "buttonAsgarifazla";
            this.buttonAsgarifazla.Size = new System.Drawing.Size(194, 68);
            this.buttonAsgarifazla.TabIndex = 13;
            this.buttonAsgarifazla.Text = "Asgar Ücretten Fazla Alan Personeller";
            this.buttonAsgarifazla.UseVisualStyleBackColor = true;
            this.buttonAsgarifazla.Click += new System.EventHandler(this.buttonAsgarifazla_Click);
            // 
            // buttonZam
            // 
            this.buttonZam.Location = new System.Drawing.Point(506, 402);
            this.buttonZam.Name = "buttonZam";
            this.buttonZam.Size = new System.Drawing.Size(194, 68);
            this.buttonZam.TabIndex = 14;
            this.buttonZam.Text = "Seçilen Personelin Maaşına 500Tl Zam Yap";
            this.buttonZam.UseVisualStyleBackColor = true;
            this.buttonZam.Click += new System.EventHandler(this.buttonZam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZam);
            this.Controls.Add(this.buttonAsgarifazla);
            this.Controls.Add(this.buttonAsgari);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.buttonMinmaas);
            this.Controls.Add(this.buttonMaxmaas);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonListele);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PERSONEL TAKİP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonMaxmaas;
        private System.Windows.Forms.Button buttonMinmaas;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Button buttonAsgari;
        private System.Windows.Forms.Button buttonAsgarifazla;
        private System.Windows.Forms.Button buttonZam;
        private System.Windows.Forms.Label label2;
    }
}

