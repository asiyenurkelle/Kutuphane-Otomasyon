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
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDb;Integrated Security=True");
        //Baglanti yolumuzu baglanti degiskenine atadık.//

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kitap (KitapAdi,BasimYili,Tur,SayfaSayisi) VALUES ('" + txtbxKitapAdi.Text.ToString() + "','" + txtbxBasimYili.Text.ToString() + "','" + txtbxTur.Text.ToString() + "','" + txtxSayfaSayisi.Text.ToString() + "')", baglanti);
            //INSERT INTO komutu kullanarak ilgili textboxlara girilen bilgileri veritabanındaki ilgili satırlara eklettirdik.//
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit Basariyla Eklendi..");
            txtbxKitapAdi.Clear();
            txtbxBasimYili.Clear();
            txtbxTur.Clear();
            txtxSayfaSayisi.Clear();


        }

        private void FrmKitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmKitapKatalogu anasayfa = new FrmKitapKatalogu();
            anasayfa.Show();
            this.Hide();
        }
    }
}
