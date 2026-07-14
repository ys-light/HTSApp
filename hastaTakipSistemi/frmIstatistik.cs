using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastaTakipSistemi
{
    public partial class frmIstatistik : Form
    {
        public frmIstatistik()
        {
            InitializeComponent();
        }
        frmSqlBaglanti bgl= new frmSqlBaglanti();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmIstatistik_Load(object sender, EventArgs e)
        {
            toplamHasta();
            yasOrtalama();
            erkekSayi();
            KadınSayi();
            ExSayisi();
        }

        private void toplamHasta()
        {
            SqlCommand toplam = new SqlCommand("select count(*) from tbl_HastaBilgi",bgl.baglan());
            SqlDataReader dr= toplam.ExecuteReader();
            while(dr.Read())
            {
                lblToplamHasta.Text = dr[0].ToString();
            }
           
        }

        private void yasOrtalama()
        {
            SqlCommand ortalama = new SqlCommand("select AVG(hYas) from tbl_HastaBilgi", bgl.baglan());
            SqlDataReader dr = ortalama.ExecuteReader();
            while (dr.Read())
            {
                lblYasOrtalama.Text = dr[0].ToString();
            }

        }
        private void erkekSayi()
        {
            SqlCommand erkekSayi = new SqlCommand("select count(*) from tbl_HastaBilgi where hCinsiyet='Erkek'", bgl.baglan());
            SqlDataReader dr = erkekSayi.ExecuteReader();
            while (dr.Read())
            {
                lblErkekHasta.Text = dr[0].ToString();
            }

        }
        private void KadınSayi()
        {
            SqlCommand kadinSayi = new SqlCommand("select count(*) from tbl_HastaBilgi where hCinsiyet='Kadın'", bgl.baglan());
            SqlDataReader dr = kadinSayi.ExecuteReader();
            while (dr.Read())
            {
                lblKadınHasta.Text = dr[0].ToString();
            }

        }

        private void ExSayisi()
        {
            SqlCommand exSayisi = new SqlCommand("select count (*) from tbl_HastaBilgi where hExMi= 1", bgl.baglan());
            SqlDataReader dr = exSayisi.ExecuteReader();
            while (dr.Read())
            {
                lblExSayısı.Text = dr[0].ToString();
            }

        }


    }
}
