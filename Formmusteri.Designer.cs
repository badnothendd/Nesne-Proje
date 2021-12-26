
namespace nesneprojee
{
    partial class Formmusteri
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
            this.lblurunsec = new System.Windows.Forms.Label();
            this.cmburunsec = new System.Windows.Forms.ComboBox();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbltutar = new System.Windows.Forms.Label();
            this.btnodeme = new System.Windows.Forms.Button();
            this.lblodemetur = new System.Windows.Forms.Label();
            this.cmbodemeturu = new System.Windows.Forms.ComboBox();
            this.btntutarhesap = new System.Windows.Forms.Button();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.lblmusteriadsoyad = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.lblmusteriadres = new System.Windows.Forms.Label();
            this.lblurunkgfiyati = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblurunsec
            // 
            this.lblurunsec.AutoSize = true;
            this.lblurunsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblurunsec.Location = new System.Drawing.Point(260, 110);
            this.lblurunsec.Name = "lblurunsec";
            this.lblurunsec.Size = new System.Drawing.Size(94, 25);
            this.lblurunsec.TabIndex = 0;
            this.lblurunsec.Text = "Ürün Seç";
            // 
            // cmburunsec
            // 
            this.cmburunsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmburunsec.FormattingEnabled = true;
            this.cmburunsec.Location = new System.Drawing.Point(404, 110);
            this.cmburunsec.Name = "cmburunsec";
            this.cmburunsec.Size = new System.Drawing.Size(110, 33);
            this.cmburunsec.TabIndex = 1;
            this.cmburunsec.SelectedIndexChanged += new System.EventHandler(this.cmburunsec_SelectedIndexChanged);
            // 
            // lblmiktar
            // 
            this.lblmiktar.AutoSize = true;
            this.lblmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmiktar.Location = new System.Drawing.Point(260, 161);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(65, 25);
            this.lblmiktar.TabIndex = 2;
            this.lblmiktar.Text = "Miktar";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmiktar.Location = new System.Drawing.Point(404, 161);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(110, 30);
            this.txtmiktar.TabIndex = 3;
            this.txtmiktar.TextChanged += new System.EventHandler(this.txtmiktar_TextChanged);
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.Location = new System.Drawing.Point(519, 223);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(46, 17);
            this.lbltutar.TabIndex = 4;
            this.lbltutar.Text = "Tutar:";
            // 
            // btnodeme
            // 
            this.btnodeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnodeme.Location = new System.Drawing.Point(320, 359);
            this.btnodeme.Name = "btnodeme";
            this.btnodeme.Size = new System.Drawing.Size(135, 53);
            this.btnodeme.TabIndex = 5;
            this.btnodeme.Text = "Sipariş Ver";
            this.btnodeme.UseVisualStyleBackColor = true;
            this.btnodeme.Click += new System.EventHandler(this.btnodeme_Click);
            // 
            // lblodemetur
            // 
            this.lblodemetur.AutoSize = true;
            this.lblodemetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblodemetur.Location = new System.Drawing.Point(260, 284);
            this.lblodemetur.Name = "lblodemetur";
            this.lblodemetur.Size = new System.Drawing.Size(129, 25);
            this.lblodemetur.TabIndex = 6;
            this.lblodemetur.Text = "Ödeme Türü:";
            // 
            // cmbodemeturu
            // 
            this.cmbodemeturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbodemeturu.FormattingEnabled = true;
            this.cmbodemeturu.Items.AddRange(new object[] {
            "Kredi",
            "Nakit",
            "Bitcoin"});
            this.cmbodemeturu.Location = new System.Drawing.Point(404, 281);
            this.cmbodemeturu.Name = "cmbodemeturu";
            this.cmbodemeturu.Size = new System.Drawing.Size(121, 33);
            this.cmbodemeturu.TabIndex = 7;
            // 
            // btntutarhesap
            // 
            this.btntutarhesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntutarhesap.Location = new System.Drawing.Point(320, 207);
            this.btntutarhesap.Name = "btntutarhesap";
            this.btntutarhesap.Size = new System.Drawing.Size(153, 49);
            this.btntutarhesap.TabIndex = 8;
            this.btntutarhesap.Text = "Tutar Hesapla";
            this.btntutarhesap.UseVisualStyleBackColor = true;
            this.btntutarhesap.Click += new System.EventHandler(this.btntutarhesap_Click);
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyad.Location = new System.Drawing.Point(404, 22);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(110, 30);
            this.txtadsoyad.TabIndex = 10;
            // 
            // lblmusteriadsoyad
            // 
            this.lblmusteriadsoyad.AutoSize = true;
            this.lblmusteriadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmusteriadsoyad.Location = new System.Drawing.Point(260, 22);
            this.lblmusteriadsoyad.Name = "lblmusteriadsoyad";
            this.lblmusteriadsoyad.Size = new System.Drawing.Size(101, 25);
            this.lblmusteriadsoyad.TabIndex = 9;
            this.lblmusteriadsoyad.Text = "Ad-Soyad";
            // 
            // txtadres
            // 
            this.txtadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadres.Location = new System.Drawing.Point(404, 67);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(110, 30);
            this.txtadres.TabIndex = 12;
            // 
            // lblmusteriadres
            // 
            this.lblmusteriadres.AutoSize = true;
            this.lblmusteriadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmusteriadres.Location = new System.Drawing.Point(261, 67);
            this.lblmusteriadres.Name = "lblmusteriadres";
            this.lblmusteriadres.Size = new System.Drawing.Size(64, 25);
            this.lblmusteriadres.TabIndex = 11;
            this.lblmusteriadres.Text = "Adres";
            // 
            // lblurunkgfiyati
            // 
            this.lblurunkgfiyati.AutoSize = true;
            this.lblurunkgfiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblurunkgfiyati.Location = new System.Drawing.Point(693, 118);
            this.lblurunkgfiyati.Name = "lblurunkgfiyati";
            this.lblurunkgfiyati.Size = new System.Drawing.Size(0, 25);
            this.lblurunkgfiyati.TabIndex = 13;
            this.lblurunkgfiyati.Click += new System.EventHandler(this.lblurunkgfiyati_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(579, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 59);
            this.button1.TabIndex = 14;
            this.button1.Text = "Yönetici Ekranı";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(546, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ürün Kg Fiyatı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Formmusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblurunkgfiyati);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.lblmusteriadres);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.lblmusteriadsoyad);
            this.Controls.Add(this.btntutarhesap);
            this.Controls.Add(this.cmbodemeturu);
            this.Controls.Add(this.lblodemetur);
            this.Controls.Add(this.btnodeme);
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.lblmiktar);
            this.Controls.Add(this.cmburunsec);
            this.Controls.Add(this.lblurunsec);
            this.Name = "Formmusteri";
            this.Text = "formkullanici";
            this.Load += new System.EventHandler(this.Formmusteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblurunsec;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.Button btnodeme;
        private System.Windows.Forms.Label lblodemetur;
        private System.Windows.Forms.ComboBox cmbodemeturu;
        public System.Windows.Forms.ComboBox cmburunsec;
        private System.Windows.Forms.Button btntutarhesap;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label lblmusteriadsoyad;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label lblmusteriadres;
        private System.Windows.Forms.Label lblurunkgfiyati;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}