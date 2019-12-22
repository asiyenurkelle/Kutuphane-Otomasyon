namespace KütüphaneOtomasyon
{
    partial class FrmYazarArama
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
            this.lblYazarAd = new System.Windows.Forms.Label();
            this.txtbxYazarAd = new System.Windows.Forms.TextBox();
            this.btnYazarAdAra = new System.Windows.Forms.Button();
            this.listViewYazarAra = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblYazarSoyad = new System.Windows.Forms.Label();
            this.txtbxYazarSoyad = new System.Windows.Forms.TextBox();
            this.btnYazarSoyadAra = new System.Windows.Forms.Button();
            this.pictureBoxGeriYazarArama = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeriYazarArama)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYazarAd
            // 
            this.lblYazarAd.AutoSize = true;
            this.lblYazarAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblYazarAd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarAd.Location = new System.Drawing.Point(23, 104);
            this.lblYazarAd.Name = "lblYazarAd";
            this.lblYazarAd.Size = new System.Drawing.Size(175, 22);
            this.lblYazarAd.TabIndex = 5;
            this.lblYazarAd.Text = "Aranacak yazar ismi:";
            // 
            // txtbxYazarAd
            // 
            this.txtbxYazarAd.Location = new System.Drawing.Point(235, 107);
            this.txtbxYazarAd.Name = "txtbxYazarAd";
            this.txtbxYazarAd.Size = new System.Drawing.Size(100, 20);
            this.txtbxYazarAd.TabIndex = 4;
            // 
            // btnYazarAdAra
            // 
            this.btnYazarAdAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnYazarAdAra.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarAdAra.Location = new System.Drawing.Point(114, 169);
            this.btnYazarAdAra.Name = "btnYazarAdAra";
            this.btnYazarAdAra.Size = new System.Drawing.Size(134, 39);
            this.btnYazarAdAra.TabIndex = 3;
            this.btnYazarAdAra.Text = "ARA";
            this.btnYazarAdAra.UseVisualStyleBackColor = false;
            this.btnYazarAdAra.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewYazarAra
            // 
            this.listViewYazarAra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewYazarAra.HideSelection = false;
            this.listViewYazarAra.Location = new System.Drawing.Point(166, 255);
            this.listViewYazarAra.Name = "listViewYazarAra";
            this.listViewYazarAra.Size = new System.Drawing.Size(443, 183);
            this.listViewYazarAra.TabIndex = 6;
            this.listViewYazarAra.UseCompatibleStateImageBehavior = false;
            this.listViewYazarAra.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "YazarId";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "YazarAd";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "YazarSoyad";
            this.columnHeader3.Width = 112;
            // 
            // lblYazarSoyad
            // 
            this.lblYazarSoyad.AutoSize = true;
            this.lblYazarSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblYazarSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarSoyad.Location = new System.Drawing.Point(415, 104);
            this.lblYazarSoyad.Name = "lblYazarSoyad";
            this.lblYazarSoyad.Size = new System.Drawing.Size(194, 22);
            this.lblYazarSoyad.TabIndex = 11;
            this.lblYazarSoyad.Text = "Aranacak yazar soyadı:";
            // 
            // txtbxYazarSoyad
            // 
            this.txtbxYazarSoyad.Location = new System.Drawing.Point(627, 107);
            this.txtbxYazarSoyad.Name = "txtbxYazarSoyad";
            this.txtbxYazarSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtbxYazarSoyad.TabIndex = 10;
            // 
            // btnYazarSoyadAra
            // 
            this.btnYazarSoyadAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnYazarSoyadAra.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarSoyadAra.Location = new System.Drawing.Point(519, 169);
            this.btnYazarSoyadAra.Name = "btnYazarSoyadAra";
            this.btnYazarSoyadAra.Size = new System.Drawing.Size(134, 39);
            this.btnYazarSoyadAra.TabIndex = 9;
            this.btnYazarSoyadAra.Text = "ARA";
            this.btnYazarSoyadAra.UseVisualStyleBackColor = false;
            this.btnYazarSoyadAra.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxGeriYazarArama
            // 
            this.pictureBoxGeriYazarArama.Image = global::KütüphaneOtomasyon.Properties.Resources.arrow_35248_960_720;
            this.pictureBoxGeriYazarArama.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxGeriYazarArama.Name = "pictureBoxGeriYazarArama";
            this.pictureBoxGeriYazarArama.Size = new System.Drawing.Size(77, 60);
            this.pictureBoxGeriYazarArama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGeriYazarArama.TabIndex = 12;
            this.pictureBoxGeriYazarArama.TabStop = false;
            this.pictureBoxGeriYazarArama.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmYazarArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KütüphaneOtomasyon.Properties.Resources.icon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxGeriYazarArama);
            this.Controls.Add(this.lblYazarSoyad);
            this.Controls.Add(this.txtbxYazarSoyad);
            this.Controls.Add(this.btnYazarSoyadAra);
            this.Controls.Add(this.listViewYazarAra);
            this.Controls.Add(this.lblYazarAd);
            this.Controls.Add(this.txtbxYazarAd);
            this.Controls.Add(this.btnYazarAdAra);
            this.Name = "FrmYazarArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYazarArama";
            this.Load += new System.EventHandler(this.FrmYazarArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeriYazarArama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYazarAd;
        private System.Windows.Forms.TextBox txtbxYazarAd;
        private System.Windows.Forms.Button btnYazarAdAra;
        private System.Windows.Forms.ListView listViewYazarAra;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblYazarSoyad;
        private System.Windows.Forms.TextBox txtbxYazarSoyad;
        private System.Windows.Forms.Button btnYazarSoyadAra;
        private System.Windows.Forms.PictureBox pictureBoxGeriYazarArama;
    }
}