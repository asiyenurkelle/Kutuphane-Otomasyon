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
    public partial class FrmYazarlar : Form
    {
        public FrmYazarlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDb;Integrated Security=True");

        private void yazarlarigoster()
        {
            listViewYazarlar.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yazar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["YazarId"].ToString();
                ekle.SubItems.Add(oku["YazarAd"].ToString());
                ekle.SubItems.Add(oku["YazarSoyad"].ToString());

                listViewYazarlar.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yazarlarigoster();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmKitapKatalogu anasayfa = new FrmKitapKatalogu();
            anasayfa.Show();
            this.Hide();
        }

        private void FrmYazarlar_Load(object sender, EventArgs e)
        {

        }
    }
}

