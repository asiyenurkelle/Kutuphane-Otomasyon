namespace KütüphaneOtomasyon
{
    partial class FrmKitaplar
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
            this.listViewKitaplar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKitaplariListele = new System.Windows.Forms.Button();
            this.pictureBoxAnasayfaTusu = new System.Windows.Forms.PictureBox();
            this.pictureBoxKitaplar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnasayfaTusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewKitaplar
            // 
            this.listViewKitaplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listViewKitaplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewKitaplar.HideSelection = false;
            this.listViewKitaplar.Location = new System.Drawing.Point(451, 43);
            this.listViewKitaplar.Name = "listViewKitaplar";
            this.listViewKitaplar.Size = new System.Drawing.Size(275, 313);
            this.listViewKitaplar.TabIndex = 0;
            this.listViewKitaplar.UseCompatibleStateImageBehavior = false;
            this.listViewKitaplar.View = System.Windows.Forms.View.Details;
            this.listViewKitaplar.SelectedIndexChanged += new System.EventHandler(this.listViewkitaplar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KitapId";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KitapAdi";
            this.columnHeader2.Width = 150;
            // 
            // btnKitaplariListele
            // 
            this.btnKitaplariListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnKitaplariListele.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitaplariListele.Location = new System.Drawing.Point(505, 362);
            this.btnKitaplariListele.Name = "btnKitaplariListele";
            this.btnKitaplariListele.Size = new System.Drawing.Size(151, 55);
            this.btnKitaplariListele.TabIndex = 1;
            this.btnKitaplariListele.Text = "Kitaplari Listele ";
            this.btnKitaplariListele.UseVisualStyleBackColor = false;
            this.btnKitaplariListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxAnasayfaTusu
            // 
            this.pictureBoxAnasayfaTusu.Image = global::KütüphaneOtomasyon.Properties.Resources._248627;
            this.pictureBoxAnasayfaTusu.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAnasayfaTusu.Name = "pictureBoxAnasayfaTusu";
            this.pictureBoxAnasayfaTusu.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxAnasayfaTusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnasayfaTusu.TabIndex = 3;
            this.pictureBoxAnasayfaTusu.TabStop = false;
            this.pictureBoxAnasayfaTusu.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxKitaplar
            // 
            this.pictureBoxKitaplar.Image = global::KütüphaneOtomasyon.Properties.Resources._2;
            this.pictureBoxKitaplar.Location = new System.Drawing.Point(31, 34);
            this.pictureBoxKitaplar.Name = "pictureBoxKitaplar";
            this.pictureBoxKitaplar.Size = new System.Drawing.Size(382, 377);
            this.pictureBoxKitaplar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKitaplar.TabIndex = 2;
            this.pictureBoxKitaplar.TabStop = false;
            // 
            // FrmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxAnasayfaTusu);
            this.Controls.Add(this.pictureBoxKitaplar);
            this.Controls.Add(this.btnKitaplariListele);
            this.Controls.Add(this.listViewKitaplar);
            this.DoubleBuffered = true;
            this.Name = "FrmKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitaplar";
            this.Load += new System.EventHandler(this.FrmKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnasayfaTusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewKitaplar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnKitaplariListele;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBoxKitaplar;
        private System.Windows.Forms.PictureBox pictureBoxAnasayfaTusu;
    }
}