using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KütüphaneOtomasyon
{
    public partial class FrmYazarArama : Form
    {
        public FrmYazarArama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDb;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            listViewYazarAra.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yazar WHERE YazarAd LIKE '%" + txtbxYazarAd.Text + "%'", baglanti);
            //Yazarlar tablosundan yazaradı girilen textboxtaki değerle eşleşen kayıtları getirmesini istedik.//
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["YazarId"].ToString();
                ekle.SubItems.Add(oku["YazarAd"].ToString());
                ekle.SubItems.Add(oku["YazarSoyad"].ToString());
               
                listViewYazarAra.Items.Add(ekle);
            }
            txtbxYazarAd.Clear();
            baglanti.Close();
        }

        private void FrmYazarArama_Load(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            listViewYazarAra.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yazar WHERE YazarSoyad LIKE '%" + txtbxYazarSoyad.Text + "%'", baglanti);
            //Yazarlar tablosundan yazarsoyadı girilen textboxtaki değerle eşleşen kayıtları getirmesini istedik.//
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["YazarId"].ToString();
                ekle.SubItems.Add(oku["YazarAd"].ToString());
                ekle.SubItems.Add(oku["YazarSoyad"].ToString());

                listViewYazarAra.Items.Add(ekle);
            }
            txtbxYazarSoyad.Clear();
            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmKitapKatalogu anasayfa = new FrmKitapKatalogu();
            anasayfa.Show();
            this.Hide();
        }
    }
}
