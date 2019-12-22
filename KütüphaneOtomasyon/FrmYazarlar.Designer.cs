namespace KütüphaneOtomasyon
{
    partial class FrmYazarlar
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
            this.btnYazarlariGoruntule = new System.Windows.Forms.Button();
            this.listViewYazarlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxAnasayfaYazarlar = new System.Windows.Forms.PictureBox();
            this.pictureBoxYazarlar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnasayfaYazarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYazarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYazarlariGoruntule
            // 
            this.btnYazarlariGoruntule.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnYazarlariGoruntule.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarlariGoruntule.Location = new System.Drawing.Point(382, 312);
            this.btnYazarlariGoruntule.Name = "btnYazarlariGoruntule";
            this.btnYazarlariGoruntule.Size = new System.Drawing.Size(351, 63);
            this.btnYazarlariGoruntule.TabIndex = 0;
            this.btnYazarlariGoruntule.Text = "Yazarları Görüntüle";
            this.btnYazarlariGoruntule.UseVisualStyleBackColor = false;
            this.btnYazarlariGoruntule.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewYazarlar
            // 
            this.listViewYazarlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewYazarlar.HideSelection = false;
            this.listViewYazarlar.Location = new System.Drawing.Point(359, 77);
            this.listViewYazarlar.Name = "listViewYazarlar";
            this.listViewYazarlar.Size = new System.Drawing.Size(388, 203);
            this.listViewYazarlar.TabIndex = 1;
            this.listViewYazarlar.UseCompatibleStateImageBehavior = false;
            this.listViewYazarlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "YazarId";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "YazarAd";
            this.columnHeader2.Width = 148;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "YazarSoyad";
            this.columnHeader3.Width = 110;
            // 
            // pictureBoxAnasayfaYazarlar
            // 
            this.pictureBoxAnasayfaYazarlar.Image = global::KütüphaneOtomasyon.Properties.Resources.ğ;
            this.pictureBoxAnasayfaYazarlar.Location = new System.Drawing.Point(-3, 0);
            this.pictureBoxAnasayfaYazarlar.Name = "pictureBoxAnasayfaYazarlar";
            this.pictureBoxAnasayfaYazarlar.Size = new System.Drawing.Size(71, 65);
            this.pictureBoxAnasayfaYazarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnasayfaYazarlar.TabIndex = 3;
            this.pictureBoxAnasayfaYazarlar.TabStop = false;
            this.pictureBoxAnasayfaYazarlar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxYazarlar
            // 
            this.pictureBoxYazarlar.Image = global::KütüphaneOtomasyon.Properties.Resources.kisspng_businessperson_diagram_illustration_vector_white_collar_man_5aa5387ae5e0301;
            this.pictureBoxYazarlar.Location = new System.Drawing.Point(-3, 0);
            this.pictureBoxYazarlar.Name = "pictureBoxYazarlar";
            this.pictureBoxYazarlar.Size = new System.Drawing.Size(324, 451);
            this.pictureBoxYazarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYazarlar.TabIndex = 2;
            this.pictureBoxYazarlar.TabStop = false;
            // 
            // FrmYazarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxAnasayfaYazarlar);
            this.Controls.Add(this.pictureBoxYazarlar);
            this.Controls.Add(this.listViewYazarlar);
            this.Controls.Add(this.btnYazarlariGoruntule);
            this.Name = "FrmYazarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYazarlar";
            this.Load += new System.EventHandler(this.FrmYazarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnasayfaYazarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYazarlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYazarlariGoruntule;
        private System.Windows.Forms.ListView listViewYazarlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBoxYazarlar;
        private System.Windows.Forms.PictureBox pictureBoxAnasayfaYazarlar;
    }
}