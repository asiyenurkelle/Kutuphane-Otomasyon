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
    public partial class FrmYayinevleri : Form
    {
        public FrmYayinevleri()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti= new SqlConnection("Data Source =.; Initial Catalog = KutuphaneDb; Integrated Security = True");

        private void yayinevlerinigoster()
        {
            listViewYayinEvleri.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("yayinevleriniGoster", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["YayinEviId"].ToString();
                ekle.SubItems.Add(oku["YayinEviAdi"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
               

                listViewYayinEvleri.Items.Add(ekle);
            }
            baglanti.Close();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            yayinevlerinigoster();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmKitapKatalogu anasayfa = new FrmKitapKatalogu();
            anasayfa.Show();
            this.Hide();
        }

        private void FrmYayinevleri_Load(object sender, EventArgs e)
        {

        }
    }
}
