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
    public partial class FrmKullaniciGirisi : Form
    {
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =.; Initial Catalog = KutuphaneDb; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                String sql = "SELECT * FROM Tbl_Kullanicilar WHERE Ad=@adi AND Sifre = @sifresi";
                SqlParameter prm1 = new SqlParameter("adi", txtbxKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtbxSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    FrmKitapKatalogu gecis = new FrmKitapKatalogu();
                    gecis.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatali Giris");
                throw;
                baglanti.Close();
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmKullaniciGirisi_Load(object sender, EventArgs e)
        {

        }

        private void FrmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult giriskapanis = MessageBox.Show("Programı kapatmak istediğinizden eminmisiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (giriskapanis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }
    }
}
