
namespace nesneprojee
{
    partial class Formgiris
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnkullanici = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpkullanici = new System.Windows.Forms.GroupBox();
            this.grpmusteri = new System.Windows.Forms.GroupBox();
            this.btnmusteri = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grpkullanici.SuspendLayout();
            this.grpmusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 32);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "şifre";
            // 
            // btnkullanici
            // 
            this.btnkullanici.Location = new System.Drawing.Point(124, 178);
            this.btnkullanici.Name = "btnkullanici";
            this.btnkullanici.Size = new System.Drawing.Size(93, 46);
            this.btnkullanici.TabIndex = 7;
            this.btnkullanici.Text = "giriş";
            this.btnkullanici.UseVisualStyleBackColor = true;
            this.btnkullanici.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "nick";
            // 
            // grpkullanici
            // 
            this.grpkullanici.Controls.Add(this.btnkullanici);
            this.grpkullanici.Controls.Add(this.textBox2);
            this.grpkullanici.Controls.Add(this.label1);
            this.grpkullanici.Controls.Add(this.label2);
            this.grpkullanici.Controls.Add(this.textBox1);
            this.grpkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpkullanici.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpkullanici.Location = new System.Drawing.Point(45, 112);
            this.grpkullanici.Name = "grpkullanici";
            this.grpkullanici.Size = new System.Drawing.Size(333, 288);
            this.grpkullanici.TabIndex = 10;
            this.grpkullanici.TabStop = false;
            this.grpkullanici.Text = "Yönetici Girişi";
            // 
            // grpmusteri
            // 
            this.grpmusteri.Controls.Add(this.btnmusteri);
            this.grpmusteri.Controls.Add(this.textBox3);
            this.grpmusteri.Controls.Add(this.label3);
            this.grpmusteri.Controls.Add(this.label4);
            this.grpmusteri.Controls.Add(this.textBox4);
            this.grpmusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpmusteri.Location = new System.Drawing.Point(425, 112);
            this.grpmusteri.Name = "grpmusteri";
            this.grpmusteri.Size = new System.Drawing.Size(329, 288);
            this.grpmusteri.TabIndex = 11;
            this.grpmusteri.TabStop = false;
            this.grpmusteri.Text = "Müşteri Girişi";
            // 
            // btnmusteri
            // 
            this.btnmusteri.Location = new System.Drawing.Point(124, 178);
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.Size = new System.Drawing.Size(98, 46);
            this.btnmusteri.TabIndex = 7;
            this.btnmusteri.Text = "giriş";
            this.btnmusteri.UseVisualStyleBackColor = true;
            this.btnmusteri.Click += new System.EventHandler(this.btnmusteri_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 32);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "nick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "şifre";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(181, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 32);
            this.textBox4.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpmusteri);
            this.Controls.Add(this.grpkullanici);
            this.Name = "Form1";
            this.grpkullanici.ResumeLayout(false);
            this.grpkullanici.PerformLayout();
            this.grpmusteri.ResumeLayout(false);
            this.grpmusteri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnkullanici;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpkullanici;
        private System.Windows.Forms.GroupBox grpmusteri;
        private System.Windows.Forms.Button btnmusteri;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
    }
}

