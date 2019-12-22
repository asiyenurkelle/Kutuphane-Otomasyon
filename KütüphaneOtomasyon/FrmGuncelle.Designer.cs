namespace KütüphaneOtomasyon
{
    partial class FrmGuncelle
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
            this.txtxSayfaSayisiGuncelle = new System.Windows.Forms.TextBox();
            this.txtbxTurGuncelle = new System.Windows.Forms.TextBox();
            this.txtbxBasimYiliGuncelle = new System.Windows.Forms.TextBox();
            this.txtbxKitapAdiGuncelle = new System.Windows.Forms.TextBox();
            this.lblBasimYiliGuncelle = new System.Windows.Forms.Label();
            this.lblTurGuncelle = new System.Windows.Forms.Label();
            this.lblSayfaSayisiGuncelle = new System.Windows.Forms.Label();
            this.lblKitapAdGuncelle = new System.Windows.Forms.Label();
            this.btnKatalogaEkle = new System.Windows.Forms.Button();
            this.listViewGuncelle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbxIdGuncelle = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnKitaplariGoruntule = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pictureBoxGeri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtxSayfaSayisiGuncelle
            // 
            this.txtxSayfaSayisiGuncelle.Location = new System.Drawing.Point(209, 317);
            this.txtxSayfaSayisiGuncelle.Name = "txtxSayfaSayisiGuncelle";
            this.txtxSayfaSayisiGuncelle.Size = new System.Drawing.Size(100, 20);
            this.txtxSayfaSayisiGuncelle.TabIndex = 17;
            this.txtxSayfaSayisiGuncelle.TextChanged += new System.EventHandler(this.txtxSayfaSayisiGuncelle_TextChanged);
            // 
            // txtbxTurGuncelle
            // 
            this.txtbxTurGuncelle.Location = new System.Drawing.Point(209, 261);
            this.txtbxTurGuncelle.Name = "txtbxTurGuncelle";
            this.txtbxTurGuncelle.Size = new System.Drawing.Size(100, 20);
            this.txtbxTurGuncelle.TabIndex = 16;
            this.txtbxTurGuncelle.TextChanged += new System.EventHandler(this.txtbxTurGuncelle_TextChanged);
            // 
            // txtbxBasimYiliGuncelle
            // 
            this.txtbxBasimYiliGuncelle.Location = new System.Drawing.Point(209, 205);
            this.txtbxBasimYiliGuncelle.Name = "txtbxBasimYiliGuncelle";
            this.txtbxBasimYiliGuncelle.Size = new System.Drawing.Size(100, 20);
            this.txtbxBasimYiliGuncelle.TabIndex = 15;
            this.txtbxBasimYiliGuncelle.TextChanged += new System.EventHandler(this.txtbxBasimYiliGuncelle_TextChanged);
            // 
            // txtbxKitapAdiGuncelle
            // 
            this.txtbxKitapAdiGuncelle.Location = new System.Drawing.Point(209, 148);
            this.txtbxKitapAdiGuncelle.Name = "txtbxKitapAdiGuncelle";
            this.txtbxKitapAdiGuncelle.Size = new System.Drawing.Size(100, 20);
            this.txtbxKitapAdiGuncelle.TabIndex = 14;
            this.txtbxKitapAdiGuncelle.TextChanged += new System.EventHandler(this.txtbxKitapAdiGuncelle_TextChanged);
            // 
            // lblBasimYiliGuncelle
            // 
            this.lblBasimYiliGuncelle.AutoSize = true;
            this.lblBasimYiliGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBasimYiliGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasimYiliGuncelle.Location = new System.Drawing.Point(52, 204);
            this.lblBasimYiliGuncelle.Name = "lblBasimYiliGuncelle";
            this.lblBasimYiliGuncelle.Size = new System.Drawing.Size(77, 19);
            this.lblBasimYiliGuncelle.TabIndex = 13;
            this.lblBasimYiliGuncelle.Text = "Basım Yılı:";
            this.lblBasimYiliGuncelle.Click += new System.EventHandler(this.lblBasimYiliGuncelle_Click);
            // 
            // lblTurGuncelle
            // 
            this.lblTurGuncelle.AutoSize = true;
            this.lblTurGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTurGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurGuncelle.Location = new System.Drawing.Point(52, 262);
            this.lblTurGuncelle.Name = "lblTurGuncelle";
            this.lblTurGuncelle.Size = new System.Drawing.Size(43, 19);
            this.lblTurGuncelle.TabIndex = 12;
            this.lblTurGuncelle.Text = "Türü:";
            this.lblTurGuncelle.Click += new System.EventHandler(this.lblTurGuncelle_Click);
            // 
            // lblSayfaSayisiGuncelle
            // 
            this.lblSayfaSayisiGuncelle.AutoSize = true;
            this.lblSayfaSayisiGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSayfaSayisiGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfaSayisiGuncelle.Location = new System.Drawing.Point(52, 318);
            this.lblSayfaSayisiGuncelle.Name = "lblSayfaSayisiGuncelle";
            this.lblSayfaSayisiGuncelle.Size = new System.Drawing.Size(90, 19);
            this.lblSayfaSayisiGuncelle.TabIndex = 11;
            this.lblSayfaSayisiGuncelle.Text = "Sayfa Sayısı:";
            this.lblSayfaSayisiGuncelle.Click += new System.EventHandler(this.lblSayfaSayisiGuncelle_Click);
            // 
            // lblKitapAdGuncelle
            // 
            this.lblKitapAdGuncelle.AutoSize = true;
            this.lblKitapAdGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKitapAdGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdGuncelle.Location = new System.Drawing.Point(54, 149);
            this.lblKitapAdGuncelle.Name = "lblKitapAdGuncelle";
            this.lblKitapAdGuncelle.Size = new System.Drawing.Size(75, 19);
            this.lblKitapAdGuncelle.TabIndex = 10;
            this.lblKitapAdGuncelle.Text = "Kitap Adı:";
            this.lblKitapAdGuncelle.Click += new System.EventHandler(this.lblKitapAdGuncelle_Click);
            // 
            // btnKatalogaEkle
            // 
            this.btnKatalogaEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKatalogaEkle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatalogaEkle.Location = new System.Drawing.Point(249, 375);
            this.btnKatalogaEkle.Name = "btnKatalogaEkle";
            this.btnKatalogaEkle.Size = new System.Drawing.Size(168, 51);
            this.btnKatalogaEkle.TabIndex = 18;
            this.btnKatalogaEkle.Text = "Güncelle";
            this.btnKatalogaEkle.UseVisualStyleBackColor = false;
            this.btnKatalogaEkle.Click += new System.EventHandler(this.btnKatalogaEkle_Click);
            // 
            // listViewGuncelle
            // 
            this.listViewGuncelle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewGuncelle.HideSelection = false;
            this.listViewGuncelle.Location = new System.Drawing.Point(368, 134);
            this.listViewGuncelle.Name = "listViewGuncelle";
            this.listViewGuncelle.Size = new System.Drawing.Size(379, 158);
            this.listViewGuncelle.TabIndex = 19;
            this.listViewGuncelle.UseCompatibleStateImageBehavior = false;
            this.listViewGuncelle.View = System.Windows.Forms.View.Details;
            this.listViewGuncelle.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewGuncelle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitap Adı";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Basım Yılı";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tur";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sayfa Sayısı";
            this.columnHeader5.Width = 82;
            // 
            // txtbxIdGuncelle
            // 
            this.txtbxIdGuncelle.Location = new System.Drawing.Point(209, 97);
            this.txtbxIdGuncelle.Name = "txtbxIdGuncelle";
            this.txtbxIdGuncelle.Size = new System.Drawing.Size(100, 20);
            this.txtbxIdGuncelle.TabIndex = 21;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblId.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(54, 98);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 19);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "Id:";
            // 
            // btnKitaplariGoruntule
            // 
            this.btnKitaplariGoruntule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKitaplariGoruntule.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitaplariGoruntule.Location = new System.Drawing.Point(41, 375);
            this.btnKitaplariGoruntule.Name = "btnKitaplariGoruntule";
            this.btnKitaplariGoruntule.Size = new System.Drawing.Size(190, 51);
            this.btnKitaplariGoruntule.TabIndex = 22;
            this.btnKitaplariGoruntule.Text = "Kitapları Görüntüle";
            this.btnKitaplariGoruntule.UseVisualStyleBackColor = false;
            this.btnKitaplariGoruntule.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBaslik.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(204, 34);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(382, 25);
            this.lblBaslik.TabIndex = 23;
            this.lblBaslik.Text = "KİTAP GÜNCELLEME EKRANI";
            // 
            // pictureBoxGeri
            // 
            this.pictureBoxGeri.Image = global::KütüphaneOtomasyon.Properties.Resources._10;
            this.pictureBoxGeri.Location = new System.Drawing.Point(41, 34);
            this.pictureBoxGeri.Name = "pictureBoxGeri";
            this.pictureBoxGeri.Size = new System.Drawing.Size(75, 38);
            this.pictureBoxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGeri.TabIndex = 24;
            this.pictureBoxGeri.TabStop = false;
            this.pictureBoxGeri.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxGeri);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnKitaplariGoruntule);
            this.Controls.Add(this.txtbxIdGuncelle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.listViewGuncelle);
            this.Controls.Add(this.btnKatalogaEkle);
            this.Controls.Add(this.txtxSayfaSayisiGuncelle);
            this.Controls.Add(this.txtbxTurGuncelle);
            this.Controls.Add(this.txtbxBasimYiliGuncelle);
            this.Controls.Add(this.txtbxKitapAdiGuncelle);
            this.Controls.Add(this.lblBasimYiliGuncelle);
            this.Controls.Add(this.lblTurGuncelle);
            this.Controls.Add(this.lblSayfaSayisiGuncelle);
            this.Controls.Add(this.lblKitapAdGuncelle);
            this.Name = "FrmGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGuncelle";
            this.Load += new System.EventHandler(this.FrmGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtxSayfaSayisiGuncelle;
        private System.Windows.Forms.TextBox txtbxTurGuncelle;
        private System.Windows.Forms.TextBox txtbxBasimYiliGuncelle;
        private System.Windows.Forms.TextBox txtbxKitapAdiGuncelle;
        private System.Windows.Forms.Label lblBasimYiliGuncelle;
        private System.Windows.Forms.Label lblTurGuncelle;
        private System.Windows.Forms.Label lblSayfaSayisiGuncelle;
        private System.Windows.Forms.Label lblKitapAdGuncelle;
        private System.Windows.Forms.Button btnKatalogaEkle;
        private System.Windows.Forms.ListView listViewGuncelle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtbxIdGuncelle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnKitaplariGoruntule;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.PictureBox pictureBoxGeri;
    }
}