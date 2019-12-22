namespace KütüphaneOtomasyon
{
    partial class FrmYayinevleri
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
            this.btnYayinEvleriniGoster = new System.Windows.Forms.Button();
            this.listViewYayinEvleri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblYayinEvlerimiz = new System.Windows.Forms.Label();
            this.pictureBoxGeriYayinEvleri = new System.Windows.Forms.PictureBox();
            this.pictureBoxYayinEvleri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeriYayinEvleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYayinEvleri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYayinEvleriniGoster
            // 
            this.btnYayinEvleriniGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYayinEvleriniGoster.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayinEvleriniGoster.Location = new System.Drawing.Point(421, 306);
            this.btnYayinEvleriniGoster.Name = "btnYayinEvleriniGoster";
            this.btnYayinEvleriniGoster.Size = new System.Drawing.Size(214, 81);
            this.btnYayinEvleriniGoster.TabIndex = 1;
            this.btnYayinEvleriniGoster.Text = "Yayınevlerini Görmek İçin Tıklayınız";
            this.btnYayinEvleriniGoster.UseVisualStyleBackColor = false;
            this.btnYayinEvleriniGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewYayinEvleri
            // 
            this.listViewYayinEvleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewYayinEvleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewYayinEvleri.HideSelection = false;
            this.listViewYayinEvleri.Location = new System.Drawing.Point(316, 132);
            this.listViewYayinEvleri.Name = "listViewYayinEvleri";
            this.listViewYayinEvleri.Size = new System.Drawing.Size(454, 168);
            this.listViewYayinEvleri.TabIndex = 2;
            this.listViewYayinEvleri.UseCompatibleStateImageBehavior = false;
            this.listViewYayinEvleri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "YayinEviId";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "YayinEviAdi";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adres";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 100;
            // 
            // lblYayinEvlerimiz
            // 
            this.lblYayinEvlerimiz.AutoSize = true;
            this.lblYayinEvlerimiz.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayinEvlerimiz.Location = new System.Drawing.Point(424, 71);
            this.lblYayinEvlerimiz.Name = "lblYayinEvlerimiz";
            this.lblYayinEvlerimiz.Size = new System.Drawing.Size(211, 39);
            this.lblYayinEvlerimiz.TabIndex = 4;
            this.lblYayinEvlerimiz.Text = "YayinEvlerimiz";
            // 
            // pictureBoxGeriYayinEvleri
            // 
            this.pictureBoxGeriYayinEvleri.Image = global::KütüphaneOtomasyon.Properties.Resources.undo_512;
            this.pictureBoxGeriYayinEvleri.Location = new System.Drawing.Point(12, 1);
            this.pictureBoxGeriYayinEvleri.Name = "pictureBoxGeriYayinEvleri";
            this.pictureBoxGeriYayinEvleri.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxGeriYayinEvleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGeriYayinEvleri.TabIndex = 5;
            this.pictureBoxGeriYayinEvleri.TabStop = false;
            this.pictureBoxGeriYayinEvleri.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxYayinEvleri
            // 
            this.pictureBoxYayinEvleri.Image = global::KütüphaneOtomasyon.Properties.Resources.apartman;
            this.pictureBoxYayinEvleri.Location = new System.Drawing.Point(12, 57);
            this.pictureBoxYayinEvleri.Name = "pictureBoxYayinEvleri";
            this.pictureBoxYayinEvleri.Size = new System.Drawing.Size(260, 361);
            this.pictureBoxYayinEvleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYayinEvleri.TabIndex = 3;
            this.pictureBoxYayinEvleri.TabStop = false;
            // 
            // FrmYayinevleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxGeriYayinEvleri);
            this.Controls.Add(this.lblYayinEvlerimiz);
            this.Controls.Add(this.pictureBoxYayinEvleri);
            this.Controls.Add(this.listViewYayinEvleri);
            this.Controls.Add(this.btnYayinEvleriniGoster);
            this.Name = "FrmYayinevleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYayinevleri";
            this.Load += new System.EventHandler(this.FrmYayinevleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeriYayinEvleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYayinEvleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYayinEvleriniGoster;
        private System.Windows.Forms.ListView listViewYayinEvleri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBoxYayinEvleri;
        private System.Windows.Forms.Label lblYayinEvlerimiz;
        private System.Windows.Forms.PictureBox pictureBoxGeriYayinEvleri;
    }
}