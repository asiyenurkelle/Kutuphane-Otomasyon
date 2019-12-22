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
    public partial class FrmGuncelle : Form
    {
        public FrmGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDb;Integrated Security=True");
        int id = 0;
        private void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM  Tbl_Kitap", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["KitapId"].ToString();
                ekle.SubItems.Add(oku["KitapAdi"].ToString());
                ekle.SubItems.Add(oku["BasimYili"].ToString());
                ekle.SubItems.Add(oku["Tur"].ToString());
                ekle.SubItems.Add(oku["SayfaSayisi"].ToString());
                listViewGuncelle.Items.Add(ekle);
                //veritabanından verileri çekerek,listview'e yazdırır.//
            }
            baglanti.Close();
        }

        private void btnKatalogaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Kitap SET KitapId='" + txtbxIdGuncelle.Text.ToString() +"',KitapAdi='"+txtbxKitapAdiGuncelle.Text.ToString()+"',BasimYili='"+txtbxBasimYiliGuncelle.Text.ToString()+"',Tur='"+txtbxTurGuncelle.Text.ToString()+"',SayfaSayisi='"+txtxSayfaSayisiGuncelle.Text.ToString()+ "' WHERE KitapId= " + id+"", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void txtxSayfaSayisiGuncelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxTurGuncelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxBasimYiliGuncelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxKitapAdiGuncelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBasimYiliGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void lblTurGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void lblSayfaSayisiGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void lblKitapAdGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listViewGuncelle.SelectedItems[0].SubItems[0].Text);
            txtbxIdGuncelle.Text = listViewGuncelle.SelectedItems[0].SubItems[0].Text;
            txtbxKitapAdiGuncelle.Text=listViewGuncelle.SelectedItems[0].SubItems[1].Text;
            txtbxBasimYiliGuncelle.Text=listViewGuncelle.SelectedItems[0].SubItems[2].Text;
            txtbxTurGuncelle.Text= listViewGuncelle.SelectedItems[0].SubItems[3].Text;
            txtxSayfaSayisiGuncelle.Text=listViewGuncelle.SelectedItems[0].SubItems[4].Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmKitapKatalogu katalogagecis = new FrmKitapKatalogu();
            katalogagecis.Show();
            this.Hide();
        }
    }
}
