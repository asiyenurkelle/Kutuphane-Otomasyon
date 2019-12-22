namespace KütüphaneOtomasyon
{
    partial class FrmKitapDetay
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
            this.listViewKitapDetay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKitapAyrinti = new System.Windows.Forms.Button();
            this.lblKitapDetay = new System.Windows.Forms.Label();
            this.pictureBoxGeriTus = new System.Windows.Forms.PictureBox();
            this.pictureBoxKitapDetay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeriTus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitapDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewKitapDetay
            // 
            this.listViewKitapDetay.BackColor = System.Drawing.Color.White;
            this.listViewKitapDetay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewKitapDetay.HideSelection = false;
            this.listViewKitapDetay.Location = new System.Drawing.Point(165, 100);
            this.listViewKitapDetay.Name = "listViewKitapDetay";
            this.listViewKitapDetay.Size = new System.Drawing.Size(623, 214);
            this.listViewKitapDetay.TabIndex = 0;
            this.listViewKitapDetay.UseCompatibleStateImageBehavior = false;
            this.listViewKitapDetay.View = System.Windows.Forms.View.Details;
            this.listViewKitapDetay.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KitapId";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KitapAdi";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "BasimYili";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tur";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SayfaSayisi";
            this.columnHeader5.Width = 99;
            // 
            // btnKitapAyrinti
            // 
            this.btnKitapAyrinti.BackColor = System.Drawing.Color.White;
            this.btnKitapAyrinti.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAyrinti.Location = new System.Drawing.Point(213, 330);
            this.btnKitapAyrinti.Name = "btnKitapAyrinti";
            this.btnKitapAyrinti.Size = new System.Drawing.Size(341, 59);
            this.btnKitapAyrinti.TabIndex = 1;
            this.btnKitapAyrinti.Text = "Kitap Ayrıntılarını Göster";
            this.btnKitapAyrinti.UseVisualStyleBackColor = false;
            this.btnKitapAyrinti.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKitapDetay
            // 
            this.lblKitapDetay.AutoSize = true;
            this.lblKitapDetay.BackColor = System.Drawing.Color.White;
            this.lblKitapDetay.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapDetay.Location = new System.Drawing.Point(287, 35);
            this.lblKitapDetay.Name = "lblKitapDetay";
            this.lblKitapDetay.Size = new System.Drawing.Size(154, 36);
            this.lblKitapDetay.TabIndex = 3;
            this.lblKitapDetay.Text = "KİTAPLAR";
            // 
            // pictureBoxGeriTus
            // 
            this.pictureBoxGeriTus.Image = global::KütüphaneOtomasyon.Properties.Resources._10;
            this.pictureBoxGeriTus.Location = new System.Drawing.Point(12, 21);
            this.pictureBoxGeriTus.Name = "pictureBoxGeriTus";
            this.pictureBoxGeriTus.Size = new System.Drawing.Size(89, 73);
            this.pictureBoxGeriTus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGeriTus.TabIndex = 5;
            this.pictureBoxGeriTus.TabStop = false;
            this.pictureBoxGeriTus.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxKitapDetay
            // 
            this.pictureBoxKitapDetay.Image = global::KütüphaneOtomasyon.Properties.Resources.comic_book_cartoon_cartoon_books;
            this.pictureBoxKitapDetay.Location = new System.Drawing.Point(-4, 100);
            this.pictureBoxKitapDetay.Name = "pictureBoxKitapDetay";
            this.pictureBoxKitapDetay.Size = new System.Drawing.Size(163, 214);
            this.pictureBoxKitapDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKitapDetay.TabIndex = 4;
            this.pictureBoxKitapDetay.TabStop = false;
            // 
            // FrmKitapDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxGeriTus);
            this.Controls.Add(this.pictureBoxKitapDetay);
            this.Controls.Add(this.lblKitapDetay);
            this.Controls.Add(this.btnKitapAyrinti);
            this.Controls.Add(this.listViewKitapDetay);
            this.DoubleBuffered = true;
            this.Name = "FrmKitapDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitapDetay";
            this.Load += new System.EventHandler(this.FrmKitapDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeriTus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitapDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewKitapDetay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnKitapAyrinti;
        private System.Windows.Forms.Label lblKitapDetay;
        private System.Windows.Forms.PictureBox pictureBoxKitapDetay;
        private System.Windows.Forms.PictureBox pictureBoxGeriTus;
    }
}