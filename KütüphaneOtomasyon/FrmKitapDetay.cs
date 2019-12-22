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
    public partial class FrmKitapDetay : Form
    {
        public FrmKitapDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDb;Integrated Security=True");


        private void verilerigoster()
        {
            listViewKitapDetay.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kitap", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["KitapId"].ToString();
                ekle.SubItems.Add(oku["KitapAdi"].ToString());
                ekle.SubItems.Add(oku["BasimYili"].ToString());
                ekle.SubItems.Add(oku["Tur"].ToString());
                ekle.SubItems.Add(oku["SayfaSayisi"].ToString());

                listViewKitapDetay.Items.Add(ekle);
             //Tbl_Kitap tablosundaki bütün kolonları listview'a ekledik.//
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmKitapDetay_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmKitapKatalogu anasayfa = new FrmKitapKatalogu();
            anasayfa.Show();
            this.Hide();
        }
    }
}
