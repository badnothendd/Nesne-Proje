
namespace nesneprojee
{
    partial class Formyonetici
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
            this.btnurunekle = new System.Windows.Forms.Button();
            this.btnuruncıkar = new System.Windows.Forms.Button();
            this.btnurunguncelle = new System.Windows.Forms.Button();
            this.btnmusteritkp = new System.Windows.Forms.Button();
            this.txturunekle = new System.Windows.Forms.TextBox();
            this.cmburuncikar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.btnfiyat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.musteriadsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnurunekle
            // 
            this.btnurunekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnurunekle.Location = new System.Drawing.Point(45, 293);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(111, 53);
            this.btnurunekle.TabIndex = 0;
            this.btnurunekle.Text = "Ürün Ekle";
            this.btnurunekle.UseVisualStyleBackColor = true;
            this.btnurunekle.Click += new System.EventHandler(this.btnurunekle_Click);
            // 
            // btnuruncıkar
            // 
            this.btnuruncıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuruncıkar.Location = new System.Drawing.Point(385, 293);
            this.btnuruncıkar.Name = "btnuruncıkar";
            this.btnuruncıkar.Size = new System.Drawing.Size(108, 53);
            this.btnuruncıkar.TabIndex = 1;
            this.btnuruncıkar.Text = "Ürün Çıkar";
            this.btnuruncıkar.UseVisualStyleBackColor = true;
            this.btnuruncıkar.Click += new System.EventHandler(this.btnuruncıkar_Click);
            // 
            // btnurunguncelle
            // 
            this.btnurunguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnurunguncelle.Location = new System.Drawing.Point(185, 63);
            this.btnurunguncelle.Name = "btnurunguncelle";
            this.btnurunguncelle.Size = new System.Drawing.Size(183, 65);
            this.btnurunguncelle.TabIndex = 2;
            this.btnurunguncelle.Text = "Ürün Güncelle";
            this.btnurunguncelle.UseVisualStyleBackColor = true;
            this.btnurunguncelle.Click += new System.EventHandler(this.btnurunguncelle_Click);
            // 
            // btnmusteritkp
            // 
            this.btnmusteritkp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmusteritkp.Location = new System.Drawing.Point(891, 51);
            this.btnmusteritkp.Name = "btnmusteritkp";
            this.btnmusteritkp.Size = new System.Drawing.Size(217, 77);
            this.btnmusteritkp.TabIndex = 3;
            this.btnmusteritkp.Text = "Müşteri Takip";
            this.btnmusteritkp.UseVisualStyleBackColor = true;
            this.btnmusteritkp.Click += new System.EventHandler(this.btnmusteritkp_Click);
            // 
            // txturunekle
            // 
            this.txturunekle.Location = new System.Drawing.Point(45, 188);
            this.txturunekle.Multiline = true;
            this.txturunekle.Name = "txturunekle";
            this.txturunekle.Size = new System.Drawing.Size(106, 58);
            this.txturunekle.TabIndex = 4;
            this.txturunekle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmburuncikar
            // 
            this.cmburuncikar.FormattingEnabled = true;
            this.cmburuncikar.Location = new System.Drawing.Point(360, 188);
            this.cmburuncikar.Name = "cmburuncikar";
            this.cmburuncikar.Size = new System.Drawing.Size(121, 24);
            this.cmburuncikar.TabIndex = 6;
            this.cmburuncikar.SelectedIndexChanged += new System.EventHandler(this.cmburuncikar_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriadsoyad,
            this.adres,
            this.urunadi,
            this.urunmiktar,
            this.odeme,
            this.tutar});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(612, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 391);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(211, 224);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 22);
            this.txtfiyat.TabIndex = 8;
            // 
            // btnfiyat
            // 
            this.btnfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfiyat.Location = new System.Drawing.Point(211, 293);
            this.btnfiyat.Name = "btnfiyat";
            this.btnfiyat.Size = new System.Drawing.Size(108, 53);
            this.btnfiyat.TabIndex = 11;
            this.btnfiyat.Text = "Fiyat Ekle";
            this.btnfiyat.UseVisualStyleBackColor = true;
            this.btnfiyat.Click += new System.EventHandler(this.btnfiyat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(106, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 92);
            this.button1.TabIndex = 12;
            this.button1.Text = "Müşteri Girişi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musteriadsoyad
            // 
            this.musteriadsoyad.HeaderText = "Müşteri Ad/Soyad";
            this.musteriadsoyad.MinimumWidth = 6;
            this.musteriadsoyad.Name = "musteriadsoyad";
            this.musteriadsoyad.Width = 125;
            // 
            // adres
            // 
            this.adres.HeaderText = "Adres";
            this.adres.MinimumWidth = 6;
            this.adres.Name = "adres";
            this.adres.Width = 125;
            // 
            // urunadi
            // 
            this.urunadi.HeaderText = "Ürün Adı";
            this.urunadi.MinimumWidth = 6;
            this.urunadi.Name = "urunadi";
            this.urunadi.Width = 125;
            // 
            // urunmiktar
            // 
            this.urunmiktar.HeaderText = "Ürün Miktarı";
            this.urunmiktar.MinimumWidth = 6;
            this.urunmiktar.Name = "urunmiktar";
            this.urunmiktar.Width = 125;
            // 
            // odeme
            // 
            this.odeme.HeaderText = "Ödeme";
            this.odeme.MinimumWidth = 6;
            this.odeme.Name = "odeme";
            this.odeme.Width = 125;
            // 
            // tutar
            // 
            this.tutar.HeaderText = "Toplam Tutar";
            this.tutar.MinimumWidth = 6;
            this.tutar.Name = "tutar";
            this.tutar.Width = 125;
            // 
            // Formyonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1427, 790);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnfiyat);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmburuncikar);
            this.Controls.Add(this.txturunekle);
            this.Controls.Add(this.btnmusteritkp);
            this.Controls.Add(this.btnurunguncelle);
            this.Controls.Add(this.btnuruncıkar);
            this.Controls.Add(this.btnurunekle);
            this.Name = "Formyonetici";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Formyonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Button btnuruncıkar;
        private System.Windows.Forms.Button btnurunguncelle;
        private System.Windows.Forms.Button btnmusteritkp;
        private System.Windows.Forms.TextBox txturunekle;
        private System.Windows.Forms.ComboBox cmburuncikar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Button btnfiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriadsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
    }
}