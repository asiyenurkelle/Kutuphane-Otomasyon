namespace KütüphaneOtomasyon
{
    partial class FrmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGirisi));
            this.groupBoxKullaniciGirisi = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtbxSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.pictureBoxKitaplarKullaniciGirisi = new System.Windows.Forms.PictureBox();
            this.pictureBoxKullaniciGirisi = new System.Windows.Forms.PictureBox();
            this.groupBoxKullaniciGirisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitaplarKullaniciGirisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKullaniciGirisi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKullaniciGirisi
            // 
            this.groupBoxKullaniciGirisi.Controls.Add(this.pictureBoxKullaniciGirisi);
            this.groupBoxKullaniciGirisi.Controls.Add(this.btnGiris);
            this.groupBoxKullaniciGirisi.Controls.Add(this.txtbxSifre);
            this.groupBoxKullaniciGirisi.Controls.Add(this.lblSifre);
            this.groupBoxKullaniciGirisi.Controls.Add(this.txtbxKullaniciAdi);
            this.groupBoxKullaniciGirisi.Controls.Add(this.lblKullaniciAdi);
            this.groupBoxKullaniciGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKullaniciGirisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxKullaniciGirisi.Location = new System.Drawing.Point(343, 36);
            this.groupBoxKullaniciGirisi.Name = "groupBoxKullaniciGirisi";
            this.groupBoxKullaniciGirisi.Size = new System.Drawing.Size(242, 394);
            this.groupBoxKullaniciGirisi.TabIndex = 0;
            this.groupBoxKullaniciGirisi.TabStop = false;
            this.groupBoxKullaniciGirisi.Text = "Kullanici Girişi";
            this.groupBoxKullaniciGirisi.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiris.Location = new System.Drawing.Point(44, 308);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(137, 39);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbxSifre
            // 
            this.txtbxSifre.Location = new System.Drawing.Point(20, 254);
            this.txtbxSifre.Name = "txtbxSifre";
            this.txtbxSifre.Size = new System.Drawing.Size(174, 26);
            this.txtbxSifre.TabIndex = 3;
            this.txtbxSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSifre.Location = new System.Drawing.Point(20, 214);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(48, 21);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtbxKullaniciAdi
            // 
            this.txtbxKullaniciAdi.Location = new System.Drawing.Point(20, 173);
            this.txtbxKullaniciAdi.Name = "txtbxKullaniciAdi";
            this.txtbxKullaniciAdi.Size = new System.Drawing.Size(174, 26);
            this.txtbxKullaniciAdi.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(20, 136);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(109, 21);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // pictureBoxKitaplarKullaniciGirisi
            // 
            this.pictureBoxKitaplarKullaniciGirisi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKitaplarKullaniciGirisi.Image")));
            this.pictureBoxKitaplarKullaniciGirisi.Location = new System.Drawing.Point(36, 130);
            this.pictureBoxKitaplarKullaniciGirisi.Name = "pictureBoxKitaplarKullaniciGirisi";
            this.pictureBoxKitaplarKullaniciGirisi.Size = new System.Drawing.Size(235, 210);
            this.pictureBoxKitaplarKullaniciGirisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKitaplarKullaniciGirisi.TabIndex = 1;
            this.pictureBoxKitaplarKullaniciGirisi.TabStop = false;
            // 
            // pictureBoxKullaniciGirisi
            // 
            this.pictureBoxKullaniciGirisi.Image = global::KütüphaneOtomasyon.Properties.Resources.positive_kunder;
            this.pictureBoxKullaniciGirisi.Location = new System.Drawing.Point(44, 25);
            this.pictureBoxKullaniciGirisi.Name = "pictureBoxKullaniciGirisi";
            this.pictureBoxKullaniciGirisi.Size = new System.Drawing.Size(150, 102);
            this.pictureBoxKullaniciGirisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKullaniciGirisi.TabIndex = 6;
            this.pictureBoxKullaniciGirisi.TabStop = false;
            // 
            // FrmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(660, 457);
            this.Controls.Add(this.pictureBoxKitaplarKullaniciGirisi);
            this.Controls.Add(this.groupBoxKullaniciGirisi);
            this.Name = "FrmKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKullaniciGirisi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKullaniciGirisi_FormClosing);
            this.Load += new System.EventHandler(this.FrmKullaniciGirisi_Load);
            this.groupBoxKullaniciGirisi.ResumeLayout(false);
            this.groupBoxKullaniciGirisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitaplarKullaniciGirisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKullaniciGirisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKullaniciGirisi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtbxSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtbxKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.PictureBox pictureBoxKullaniciGirisi;
        private System.Windows.Forms.PictureBox pictureBoxKitaplarKullaniciGirisi;
    }
}