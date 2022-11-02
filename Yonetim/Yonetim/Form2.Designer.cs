
namespace Yonetim
{
    partial class Form2
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
            this.BtnKayit = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnBorclar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKayit
            // 
            this.BtnKayit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnKayit.Location = new System.Drawing.Point(103, 62);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(277, 194);
            this.BtnKayit.TabIndex = 0;
            this.BtnKayit.Text = "Kayıt ve Güncelleme İşlemleri";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCikis.Location = new System.Drawing.Point(510, 385);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(277, 194);
            this.BtnCikis.TabIndex = 1;
            this.BtnCikis.Text = "Uygulamadan Çık";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnBorclar
            // 
            this.BtnBorclar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBorclar.Location = new System.Drawing.Point(510, 62);
            this.BtnBorclar.Name = "BtnBorclar";
            this.BtnBorclar.Size = new System.Drawing.Size(277, 194);
            this.BtnBorclar.TabIndex = 2;
            this.BtnBorclar.Text = "Borçlar";
            this.BtnBorclar.UseVisualStyleBackColor = true;
            this.BtnBorclar.Click += new System.EventHandler(this.BtnBorclar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(103, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(277, 194);
            this.button4.TabIndex = 3;
            this.button4.Text = "Site Görüntüleri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(900, 633);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnBorclar);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnKayit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnBorclar;
        private System.Windows.Forms.Button button4;
    }
}