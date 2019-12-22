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
    public partial class FrmKitaplar : Form
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDb;Integrated Security=True");
        //Veritabani yolumuzu baglantı degiskenine atadık.//

        private void kitaplarigoster()
        {
            listViewKitaplar.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("kitaplariGoster", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())  
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["KitapId"].ToString();
                ekle.SubItems.Add(oku["KitapAdi"].ToString());
                ekle.SubItems.Add(oku["KitapId"].ToString());


                listViewKitaplar.Items.Add(ekle);
                //Kitap tablosundaki kolonları listview'a eklettirdik.//
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitaplarigoster();
        }

        private void listViewkitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmKitaplar_Load(object sender, EventArgs e)
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
