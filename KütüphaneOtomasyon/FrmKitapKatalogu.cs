using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon
{
    public partial class FrmKitapKatalogu : Form
    {
        public FrmKitapKatalogu()
        {
            InitializeComponent();
        }

        private void kİTAPLARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kİTAPİSLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kİTAPİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitaplar kitaplaragecis = new FrmKitaplar();
            kitaplaragecis.Show();
            this.Hide();
          
        }

        private void kİTAPLARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmKitapDetay kitapdetayagecis = new FrmKitapDetay();
            kitapdetayagecis.Show();
            this.Hide();
        }

        private void tESLİMALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kİTAPVERToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void yAYINEVLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYayinevleri yayinevlerinegecis = new FrmYayinevleri();
            yayinevlerinegecis.Show();
            this.Hide();
        }

        private void kİTAPEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void kİTAPİSMİNEGÖREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitapAra kitaparamayagecis = new FrmKitapAra();
            kitaparamayagecis.Show();
            this.Hide();
        }

        private void kİTAPTÜRÜNEGÖREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitapAra kitaparagecis = new FrmKitapAra();
            kitaparagecis.Show();
            this.Hide();
        }

        private void yAZARLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void yAZARLARIGÖRÜNTÜLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYazarlar yazarlaragecis = new FrmYazarlar();
            yazarlaragecis.Show();
            this.Hide();
        }

        private void yAZARARAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void yAZARADAGÖREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYazarArama yazararamagecisad = new FrmYazarArama();
            yazararamagecisad.Show();
            this.Hide();
        }

        private void yAZARSOYADAGÖREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYazarArama yazararamagecissoyad = new FrmYazarArama();
            yazararamagecissoyad.Show();
            this.Hide();
        }

        private void FrmKitapKatalogu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmKullaniciGirisi cikis = new FrmKullaniciGirisi();
            cikis.Show();
            this.Hide();
        }

        private void kİTAPİSLEMLERİToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStripKitapKatalogu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kİTAPEKLEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmKitapEkle kitapekleyegecis = new FrmKitapEkle();
            kitapekleyegecis.Show();
            this.Hide();
        }

        private void kİTAPGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGuncelle guncellemeyegecis = new FrmGuncelle();
            guncellemeyegecis.Show();
            this.Hide();
        }
    }
}
