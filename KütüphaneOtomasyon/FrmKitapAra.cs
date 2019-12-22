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
    public partial class FrmKitapAra : Form
    {
        public FrmKitapAra()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDb;Integrated Security=True");

        private void listViewAyrinti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                listViewKitapAyrintilari.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kitap WHERE KitapAdi LIKE '%"+ txtbxAranacakKitapIsmi.Text+ "%'",baglanti);
            //Kitap tablosundan WHERE komutu kullanakarak isme göre sorgu yazdık.//
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["KitapId"].ToString();
                    ekle.SubItems.Add(oku["KitapAdi"].ToString());
                    ekle.SubItems.Add(oku["BasimYili"].ToString());
                    ekle.SubItems.Add(oku["Tur"].ToString());
                    ekle.SubItems.Add(oku["SayfaSayisi"].ToString());

                    listViewKitapAyrintilari.Items.Add(ekle);
                }
                txtbxAranacakKitapIsmi.Clear();
                baglanti.Close();
            }
        //Veritabanındaki kolonları tek tek listview'e eklettik.//
        private void FrmKitapAra_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            listViewKitapAyrintilari.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kitap WHERE Tur LIKE '%" + txtbxKitapTuru.Text + "%'", baglanti);
            //Kitap tablosundan WHERE komutu kullanakarak türe göre sorgu yazdık.//
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["KitapId"].ToString();
                ekle.SubItems.Add(oku["KitapAdi"].ToString());
                ekle.SubItems.Add(oku["BasimYili"].ToString());
                ekle.SubItems.Add(oku["Tur"].ToString());
                ekle.SubItems.Add(oku["SayfaSayisi"].ToString());

                listViewKitapAyrintilari.Items.Add(ekle);
            }
            txtbxKitapTuru.Clear();
            baglanti.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmKitapKatalogu anasayfa = new FrmKitapKatalogu();
            anasayfa.Show();
            this.Hide();
        }
    }
    }

