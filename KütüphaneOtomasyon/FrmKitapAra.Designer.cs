namespace KütüphaneOtomasyon
{
    partial class FrmKitapAra
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
            this.btnIsimAra = new System.Windows.Forms.Button();
            this.txtbxAranacakKitapIsmi = new System.Windows.Forms.TextBox();
            this.lblAranacakKitapIsmi = new System.Windows.Forms.Label();
            this.listViewKitapAyrintilari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblİIsmeGoreAra = new System.Windows.Forms.Label();
            this.lblTureGoreAra = new System.Windows.Forms.Label();
            this.lblAranacakKitapTuru = new System.Windows.Forms.Label();
            this.txtbxKitapTuru = new System.Windows.Forms.TextBox();
            this.btnTurAra = new System.Windows.Forms.Button();
            this.pictureBoxGeri = new System.Windows.Forms.PictureBox();
            this.pictureBoxKitapAra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitapAra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIsimAra
            // 
            this.btnIsimAra.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsimAra.Location = new System.Drawing.Point(135, 266);
            this.btnIsimAra.Name = "btnIsimAra";
            this.btnIsimAra.Size = new System.Drawing.Size(134, 39);
            this.btnIsimAra.TabIndex = 0;
            this.btnIsimAra.Text = "ARA";
            this.btnIsimAra.UseVisualStyleBackColor = true;
            this.btnIsimAra.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbxAranacakKitapIsmi
            // 
            this.txtbxAranacakKitapIsmi.Location = new System.Drawing.Point(245, 219);
            this.txtbxAranacakKitapIsmi.Name = "txtbxAranacakKitapIsmi";
            this.txtbxAranacakKitapIsmi.Size = new System.Drawing.Size(100, 20);
            this.txtbxAranacakKitapIsmi.TabIndex = 1;
            // 
            // lblAranacakKitapIsmi
            // 
            this.lblAranacakKitapIsmi.AutoSize = true;
            this.lblAranacakKitapIsmi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAranacakKitapIsmi.Location = new System.Drawing.Point(33, 216);
            this.lblAranacakKitapIsmi.Name = "lblAranacakKitapIsmi";
            this.lblAranacakKitapIsmi.Size = new System.Drawing.Size(175, 22);
            this.lblAranacakKitapIsmi.TabIndex = 2;
            this.lblAranacakKitapIsmi.Text = "Aranacak kitap ismi:";
            // 
            // listViewKitapAyrintilari
            // 
            this.listViewKitapAyrintilari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewKitapAyrintilari.HideSelection = false;
            this.listViewKitapAyrintilari.Location = new System.Drawing.Point(71, 326);
            this.listViewKitapAyrintilari.Name = "listViewKitapAyrintilari";
            this.listViewKitapAyrintilari.Size = new System.Drawing.Size(633, 150);
            this.listViewKitapAyrintilari.TabIndex = 3;
            this.listViewKitapAyrintilari.UseCompatibleStateImageBehavior = false;
            this.listViewKitapAyrintilari.View = System.Windows.Forms.View.Details;
            this.listViewKitapAyrintilari.SelectedIndexChanged += new System.EventHandler(this.listViewAyrinti_SelectedIndexChanged);
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
            // lblİIsmeGoreAra
            // 
            this.lblİIsmeGoreAra.AutoSize = true;
            this.lblİIsmeGoreAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblİIsmeGoreAra.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİIsmeGoreAra.Location = new System.Drawing.Point(83, 164);
            this.lblİIsmeGoreAra.Name = "lblİIsmeGoreAra";
            this.lblİIsmeGoreAra.Size = new System.Drawing.Size(263, 34);
            this.lblİIsmeGoreAra.TabIndex = 4;
            this.lblİIsmeGoreAra.Text = "İSİME GÖRE ARAMA;";
            // 
            // lblTureGoreAra
            // 
            this.lblTureGoreAra.AutoSize = true;
            this.lblTureGoreAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTureGoreAra.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTureGoreAra.Location = new System.Drawing.Point(449, 162);
            this.lblTureGoreAra.Name = "lblTureGoreAra";
            this.lblTureGoreAra.Size = new System.Drawing.Size(264, 34);
            this.lblTureGoreAra.TabIndex = 8;
            this.lblTureGoreAra.Text = "TÜRE GÖRE ARAMA;";
            // 
            // lblAranacakKitapTuru
            // 
            this.lblAranacakKitapTuru.AutoSize = true;
            this.lblAranacakKitapTuru.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAranacakKitapTuru.Location = new System.Drawing.Point(410, 219);
            this.lblAranacakKitapTuru.Name = "lblAranacakKitapTuru";
            this.lblAranacakKitapTuru.Size = new System.Drawing.Size(195, 25);
            this.lblAranacakKitapTuru.TabIndex = 7;
            this.lblAranacakKitapTuru.Text = "Aranacak kitap türü:";
            // 
            // txtbxKitapTuru
            // 
            this.txtbxKitapTuru.Location = new System.Drawing.Point(625, 224);
            this.txtbxKitapTuru.Name = "txtbxKitapTuru";
            this.txtbxKitapTuru.Size = new System.Drawing.Size(106, 20);
            this.txtbxKitapTuru.TabIndex = 6;
            // 
            // btnTurAra
            // 
            this.btnTurAra.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurAra.Location = new System.Drawing.Point(510, 266);
            this.btnTurAra.Name = "btnTurAra";
            this.btnTurAra.Size = new System.Drawing.Size(134, 39);
            this.btnTurAra.TabIndex = 5;
            this.btnTurAra.Text = "ARA";
            this.btnTurAra.UseVisualStyleBackColor = true;
            this.btnTurAra.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxGeri
            // 
            this.pictureBoxGeri.Image = global::KütüphaneOtomasyon.Properties.Resources._52_527760_computer_back_icon_left_right_arrow_cartoon_left_arrow_orange;
            this.pictureBoxGeri.Location = new System.Drawing.Point(12, 23);
            this.pictureBoxGeri.Name = "pictureBoxGeri";
            this.pictureBoxGeri.Size = new System.Drawing.Size(122, 49);
            this.pictureBoxGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGeri.TabIndex = 10;
            this.pictureBoxGeri.TabStop = false;
            this.pictureBoxGeri.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxKitapAra
            // 
            this.pictureBoxKitapAra.Image = global::KütüphaneOtomasyon.Properties.Resources.kitapara;
            this.pictureBoxKitapAra.Location = new System.Drawing.Point(289, 23);
            this.pictureBoxKitapAra.Name = "pictureBoxKitapAra";
            this.pictureBoxKitapAra.Size = new System.Drawing.Size(197, 125);
            this.pictureBoxKitapAra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKitapAra.TabIndex = 9;
            this.pictureBoxKitapAra.TabStop = false;
            // 
            // FrmKitapAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(782, 488);
            this.Controls.Add(this.pictureBoxGeri);
            this.Controls.Add(this.pictureBoxKitapAra);
            this.Controls.Add(this.lblTureGoreAra);
            this.Controls.Add(this.lblAranacakKitapTuru);
            this.Controls.Add(this.txtbxKitapTuru);
            this.Controls.Add(this.btnTurAra);
            this.Controls.Add(this.lblİIsmeGoreAra);
            this.Controls.Add(this.listViewKitapAyrintilari);
            this.Controls.Add(this.lblAranacakKitapIsmi);
            this.Controls.Add(this.txtbxAranacakKitapIsmi);
            this.Controls.Add(this.btnIsimAra);
            this.Name = "FrmKitapAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ara";
            this.Load += new System.EventHandler(this.FrmKitapAra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKitapAra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsimAra;
        private System.Windows.Forms.TextBox txtbxAranacakKitapIsmi;
        private System.Windows.Forms.Label lblAranacakKitapIsmi;
        private System.Windows.Forms.ListView listViewKitapAyrintilari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblİIsmeGoreAra;
        private System.Windows.Forms.Label lblTureGoreAra;
        private System.Windows.Forms.Label lblAranacakKitapTuru;
        private System.Windows.Forms.TextBox txtbxKitapTuru;
        private System.Windows.Forms.Button btnTurAra;
        private System.Windows.Forms.PictureBox pictureBoxKitapAra;
        private System.Windows.Forms.PictureBox pictureBoxGeri;
    }
}