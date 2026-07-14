using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace hastaTakipSistemi
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        frmSqlBaglanti bgl = new frmSqlBaglanti();

        //private void txtKAdi_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnKayitOl(object sender, EventArgs e)
        //{

        //}

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmKayit_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtKAdi1.Text != "" && txtSifre1.Text != "")
            {

                SqlCommand kayit = new SqlCommand("kayitol", bgl.baglan());
                kayit.CommandType = CommandType.StoredProcedure;
                kayit.Parameters.AddWithValue("kulAdi", txtKAdi1.Text);
                kayit.Parameters.AddWithValue("sifre", txtSifre1.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);

;
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
