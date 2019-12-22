namespace KütüphaneOtomasyon
{
    partial class FrmKitapKatalogu
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
            this.menuStripKitapKatalogu = new System.Windows.Forms.MenuStrip();
            this.kİTAPİSLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPLARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPVERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPİSMİNEGÖREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPTÜRÜNEGÖREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAZARLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAZARLARIGÖRÜNTÜLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAZARARAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAZARADAGÖREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAZARSOYADAGÖREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAYINEVLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxCikis = new System.Windows.Forms.PictureBox();
            this.kİTAPGÜNCELLEMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPEKLEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPGÜNCELLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripKitapKatalogu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripKitapKatalogu
            // 
            this.menuStripKitapKatalogu.BackColor = System.Drawing.Color.White;
            this.menuStripKitapKatalogu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kİTAPİSLEMLERİToolStripMenuItem,
            this.kİTAPVERToolStripMenuItem,
            this.kİTAPEKLEToolStripMenuItem,
            this.yAZARLARToolStripMenuItem,
            this.yAYINEVLERİToolStripMenuItem,
            this.kİTAPGÜNCELLEMEToolStripMenuItem});
            this.menuStripKitapKatalogu.Location = new System.Drawing.Point(0, 0);
            this.menuStripKitapKatalogu.Name = "menuStripKitapKatalogu";
            this.menuStripKitapKatalogu.Size = new System.Drawing.Size(780, 33);
            this.menuStripKitapKatalogu.TabIndex = 0;
            this.menuStripKitapKatalogu.Text = "menuStrip1";
            this.menuStripKitapKatalogu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripKitapKatalogu_ItemClicked);
            // 
            // kİTAPİSLEMLERİToolStripMenuItem
            // 
            this.kİTAPİSLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kİTAPİŞLEMLERİToolStripMenuItem,
            this.kİTAPLARToolStripMenuItem1});
            this.kİTAPİSLEMLERİToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kİTAPİSLEMLERİToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.images__2_;
            this.kİTAPİSLEMLERİToolStripMenuItem.Name = "kİTAPİSLEMLERİToolStripMenuItem";
            this.kİTAPİSLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.kİTAPİSLEMLERİToolStripMenuItem.Text = "KİTAP İSLEMLERİ";
            this.kİTAPİSLEMLERİToolStripMenuItem.Click += new System.EventHandler(this.kİTAPİSLEMLERİToolStripMenuItem_Click);
            // 
            // kİTAPİŞLEMLERİToolStripMenuItem
            // 
            this.kİTAPİŞLEMLERİToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.library_773689;
            this.kİTAPİŞLEMLERİToolStripMenuItem.Name = "kİTAPİŞLEMLERİToolStripMenuItem";
            this.kİTAPİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.kİTAPİŞLEMLERİToolStripMenuItem.Text = "KİTAP KATOLOĞU";
            this.kİTAPİŞLEMLERİToolStripMenuItem.Click += new System.EventHandler(this.kİTAPİŞLEMLERİToolStripMenuItem_Click);
            // 
            // kİTAPLARToolStripMenuItem1
            // 
            this.kİTAPLARToolStripMenuItem1.Image = global::KütüphaneOtomasyon.Properties.Resources.Untitled_6;
            this.kİTAPLARToolStripMenuItem1.Name = "kİTAPLARToolStripMenuItem1";
            this.kİTAPLARToolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.kİTAPLARToolStripMenuItem1.Text = "KİTAP DETAYLARI";
            this.kİTAPLARToolStripMenuItem1.Click += new System.EventHandler(this.kİTAPLARToolStripMenuItem1_Click);
            // 
            // kİTAPVERToolStripMenuItem
            // 
            this.kİTAPVERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kİTAPİSMİNEGÖREToolStripMenuItem,
            this.kİTAPTÜRÜNEGÖREToolStripMenuItem});
            this.kİTAPVERToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kİTAPVERToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.kitapara;
            this.kİTAPVERToolStripMenuItem.Name = "kİTAPVERToolStripMenuItem";
            this.kİTAPVERToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.kİTAPVERToolStripMenuItem.Text = "KİTAP ARAMA";
            this.kİTAPVERToolStripMenuItem.Click += new System.EventHandler(this.kİTAPVERToolStripMenuItem_Click);
            // 
            // kİTAPİSMİNEGÖREToolStripMenuItem
            // 
            this.kİTAPİSMİNEGÖREToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.library_773689;
            this.kİTAPİSMİNEGÖREToolStripMenuItem.Name = "kİTAPİSMİNEGÖREToolStripMenuItem";
            this.kİTAPİSMİNEGÖREToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.kİTAPİSMİNEGÖREToolStripMenuItem.Text = "KİTAP İSMİNE GÖRE";
            this.kİTAPİSMİNEGÖREToolStripMenuItem.Click += new System.EventHandler(this.kİTAPİSMİNEGÖREToolStripMenuItem_Click);
            // 
            // kİTAPTÜRÜNEGÖREToolStripMenuItem
            // 
            this.kİTAPTÜRÜNEGÖREToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.library_773689;
            this.kİTAPTÜRÜNEGÖREToolStripMenuItem.Name = "kİTAPTÜRÜNEGÖREToolStripMenuItem";
            this.kİTAPTÜRÜNEGÖREToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.kİTAPTÜRÜNEGÖREToolStripMenuItem.Text = "KİTAP TÜRÜNE GÖRE";
            this.kİTAPTÜRÜNEGÖREToolStripMenuItem.Click += new System.EventHandler(this.kİTAPTÜRÜNEGÖREToolStripMenuItem_Click);
            // 
            // kİTAPEKLEToolStripMenuItem
            // 
            this.kİTAPEKLEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kİTAPEKLEToolStripMenuItem1,
            this.kİTAPGÜNCELLEToolStripMenuItem});
            this.kİTAPEKLEToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kİTAPEKLEToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.images;
            this.kİTAPEKLEToolStripMenuItem.Name = "kİTAPEKLEToolStripMenuItem";
            this.kİTAPEKLEToolStripMenuItem.Size = new System.Drawing.Size(185, 29);
            this.kİTAPEKLEToolStripMenuItem.Text = "KİTAP EKLE/GÜNCELLE";
            this.kİTAPEKLEToolStripMenuItem.Click += new System.EventHandler(this.kİTAPEKLEToolStripMenuItem_Click);
            // 
            // yAZARLARToolStripMenuItem
            // 
            this.yAZARLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yAZARLARIGÖRÜNTÜLEToolStripMenuItem,
            this.yAZARARAMAToolStripMenuItem});
            this.yAZARLARToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yAZARLARToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.icon;
            this.yAZARLARToolStripMenuItem.Name = "yAZARLARToolStripMenuItem";
            this.yAZARLARToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.yAZARLARToolStripMenuItem.Text = "YAZARLAR";
            this.yAZARLARToolStripMenuItem.Click += new System.EventHandler(this.yAZARLARToolStripMenuItem_Click);
            // 
            // yAZARLARIGÖRÜNTÜLEToolStripMenuItem
            // 
            this.yAZARLARIGÖRÜNTÜLEToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.students_icon;
            this.yAZARLARIGÖRÜNTÜLEToolStripMenuItem.Name = "yAZARLARIGÖRÜNTÜLEToolStripMenuItem";
            this.yAZARLARIGÖRÜNTÜLEToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.yAZARLARIGÖRÜNTÜLEToolStripMenuItem.Text = "YAZARLARI GÖRÜNTÜLE";
            this.yAZARLARIGÖRÜNTÜLEToolStripMenuItem.Click += new System.EventHandler(this.yAZARLARIGÖRÜNTÜLEToolStripMenuItem_Click);
            // 
            // yAZARARAMAToolStripMenuItem
            // 
            this.yAZARARAMAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yAZARADAGÖREToolStripMenuItem,
            this.yAZARSOYADAGÖREToolStripMenuItem});
            this.yAZARARAMAToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.students_icon;
            this.yAZARARAMAToolStripMenuItem.Name = "yAZARARAMAToolStripMenuItem";
            this.yAZARARAMAToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.yAZARARAMAToolStripMenuItem.Text = "YAZAR ARAMA";
            this.yAZARARAMAToolStripMenuItem.Click += new System.EventHandler(this.yAZARARAMAToolStripMenuItem_Click);
            // 
            // yAZARADAGÖREToolStripMenuItem
            // 
            this.yAZARADAGÖREToolStripMenuItem.Name = "yAZARADAGÖREToolStripMenuItem";
            this.yAZARADAGÖREToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.yAZARADAGÖREToolStripMenuItem.Text = "YAZAR ADA GÖRE";
            this.yAZARADAGÖREToolStripMenuItem.Click += new System.EventHandler(this.yAZARADAGÖREToolStripMenuItem_Click);
            // 
            // yAZARSOYADAGÖREToolStripMenuItem
            // 
            this.yAZARSOYADAGÖREToolStripMenuItem.Name = "yAZARSOYADAGÖREToolStripMenuItem";
            this.yAZARSOYADAGÖREToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.yAZARSOYADAGÖREToolStripMenuItem.Text = "YAZAR SOYADA GÖRE";
            this.yAZARSOYADAGÖREToolStripMenuItem.Click += new System.EventHandler(this.yAZARSOYADAGÖREToolStripMenuItem_Click);
            // 
            // yAYINEVLERİToolStripMenuItem
            // 
            this.yAYINEVLERİToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yAYINEVLERİToolStripMenuItem.Image = global::KütüphaneOtomasyon.Properties.Resources.indir__1_;
            this.yAYINEVLERİToolStripMenuItem.Name = "yAYINEVLERİToolStripMenuItem";
            this.yAYINEVLERİToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.yAYINEVLERİToolStripMenuItem.Text = "YAYINEVLERİ";
            this.yAYINEVLERİToolStripMenuItem.Click += new System.EventHandler(this.yAYINEVLERİToolStripMenuItem_Click);
            // 
            // pictureBoxCikis
            // 
            this.pictureBoxCikis.Image = global::KütüphaneOtomasyon.Properties.Resources.exit;
            this.pictureBoxCikis.Location = new System.Drawing.Point(694, 450);
            this.pictureBoxCikis.Name = "pictureBoxCikis";
            this.pictureBoxCikis.Size = new System.Drawing.Size(86, 67);
            this.pictureBoxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCikis.TabIndex = 1;
            this.pictureBoxCikis.TabStop = false;
            this.pictureBoxCikis.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kİTAPGÜNCELLEMEToolStripMenuItem
            // 
            this.kİTAPGÜNCELLEMEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kİTAPGÜNCELLEMEToolStripMenuItem.Name = "kİTAPGÜNCELLEMEToolStripMenuItem";
            this.kİTAPGÜNCELLEMEToolStripMenuItem.Size = new System.Drawing.Size(209, 29);
            this.kİTAPGÜNCELLEMEToolStripMenuItem.Text = "KİTAP GÜNCELLEME ";
            // 
            // kİTAPEKLEToolStripMenuItem1
            // 
            this.kİTAPEKLEToolStripMenuItem1.Name = "kİTAPEKLEToolStripMenuItem1";
            this.kİTAPEKLEToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.kİTAPEKLEToolStripMenuItem1.Text = "KİTAP EKLE";
            this.kİTAPEKLEToolStripMenuItem1.Click += new System.EventHandler(this.kİTAPEKLEToolStripMenuItem1_Click);
            // 
            // kİTAPGÜNCELLEToolStripMenuItem
            // 
            this.kİTAPGÜNCELLEToolStripMenuItem.Name = "kİTAPGÜNCELLEToolStripMenuItem";
            this.kİTAPGÜNCELLEToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.kİTAPGÜNCELLEToolStripMenuItem.Text = "KİTAP GÜNCELLE";
            this.kİTAPGÜNCELLEToolStripMenuItem.Click += new System.EventHandler(this.kİTAPGÜNCELLEToolStripMenuItem_Click);
            // 
            // FrmKitapKatalogu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::KütüphaneOtomasyon.Properties.Resources._8;
            this.ClientSize = new System.Drawing.Size(780, 519);
            this.Controls.Add(this.pictureBoxCikis);
            this.Controls.Add(this.menuStripKitapKatalogu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStripKitapKatalogu;
            this.Name = "FrmKitapKatalogu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Kataloğu";
            this.Load += new System.EventHandler(this.FrmKitapKatalogu_Load);
            this.menuStripKitapKatalogu.ResumeLayout(false);
            this.menuStripKitapKatalogu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripKitapKatalogu;
        private System.Windows.Forms.ToolStripMenuItem kİTAPİSLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPVERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPLARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yAYINEVLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAZARLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPİSMİNEGÖREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPTÜRÜNEGÖREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAZARLARIGÖRÜNTÜLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAZARARAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAZARADAGÖREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAZARSOYADAGÖREToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxCikis;
        private System.Windows.Forms.ToolStripMenuItem kİTAPGÜNCELLEMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPEKLEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kİTAPGÜNCELLEToolStripMenuItem;
    }
}

