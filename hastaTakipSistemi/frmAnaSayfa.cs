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

namespace hastaTakipSistemi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
            durumDoldur();
            bolumDoldur();
        }

        private void Listele()
        {
            SqlCommand komut = new SqlCommand("listele", bgl.baglan()); // Sorgu yerine direkt prosedür adını yazdık
            komut.CommandType = CommandType.StoredProcedure; // Bunun bir prosedür olduğunu C#'a belirttik

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; // Veriler ekrana listelenir

        }

        private void durumDoldur()
        {
            SqlCommand durum = new SqlCommand("durumDoldur", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(durum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtDurum.DataSource = dt;
            txtDurum.DisplayMember = "durumAd";
            txtDurum.ValueMember = "durumID";
        }

        private void bolumDoldur()
        {
            SqlCommand durum = new SqlCommand("bolumDoldur", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(durum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtBolum.DataSource = dt;
            txtBolum.DisplayMember = "bolumAd";
            txtBolum.ValueMember = "bolumID";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            txtTC.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            txtYas.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            txtCinsiyet.Text = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
            txtSikayet.Text = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[seçilen].Cells[8].Value.ToString();
            txtDurum.SelectedValue = dataGridView1.Rows[seçilen].Cells[9].Value.ToString();
            txtBolum.SelectedValue = dataGridView1.Rows[seçilen].Cells[10].Value.ToString();
            lblEx.Text = dataGridView1.Rows[seçilen].Cells[11].Value.ToString();
        }

        private void rbEvet_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEvet.Checked == true)
            {
                lblEx.Text = "true";
            }
            else
            {
                lblEx.Text = "false";
            }
        }

        private void lblEx_TextChanged(object sender, EventArgs e)
        {
            if (lblEx.Text == "true")
            {
                rbEvet.Checked = true;
            }
            else
            {
                rbHayir.Checked = true;
            }
        }

        private void rbHayir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTC.Text != "" && txtTelefon.Text != "" && txtYas.Text != "" && txtCinsiyet.Text != "" && txtSikayet.Text != "" && txtDurum.Text != "" && txtBolum.Text != "")
            {
                kaydet();
            }
            else
            {
                MessageBox.Show("Lütfen ilgili tüm alanları doldurunuz", "Kayıt başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kaydet()
        {
            SqlCommand komut = new SqlCommand("kaydet", bgl.baglan());
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
            komut.Parameters.AddWithValue("@yas", int.Parse(txtYas.Text));
            komut.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text);
            komut.Parameters.AddWithValue("@sikayet", txtSikayet.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now);
            komut.Parameters.AddWithValue("@durum", txtDurum.SelectedValue);
            komut.Parameters.AddWithValue("@bolum", txtBolum.SelectedValue);

            // Exmi durumu (Label'daki metne göre 1 veya 0 gönderilir)
            komut.Parameters.AddWithValue("@ex", lblEx.Text == "True" ? 1 : 0);


            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla Eklendi", "Kayıt başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglan().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void sil()
        {
            DialogResult dr = MessageBox.Show($"{txtID.Text} numaralı kayıt silinecek. Onaylıyor musunuz?", "Onay işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                SqlCommand sil = new SqlCommand("sil", bgl.baglan());
                sil.CommandType = CommandType.StoredProcedure;
                sil.Parameters.AddWithValue("id", int.Parse(txtID.Text));
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Silindi", "Kayıt Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{txtID.Text} numaralı kayıt güncellenecek. Onaylıyor musunuz?", "Onay işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                guncelle();
                Listele();
            }

        }

        private void guncelle()
        {
            SqlCommand guncelle = new SqlCommand("guncelle", bgl.baglan());
            guncelle.CommandType = CommandType.StoredProcedure;
            guncelle.Parameters.AddWithValue("id",txtID.Text);
            guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@tc", txtTC.Text);
            guncelle.Parameters.AddWithValue("@tel", txtTelefon.Text);
            guncelle.Parameters.AddWithValue("@yas", int.Parse(txtYas.Text));
            guncelle.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text);
            guncelle.Parameters.AddWithValue("@sikayet", txtSikayet.Text);
            guncelle.Parameters.AddWithValue("@tarih", DateTime.Now);
            guncelle.Parameters.AddWithValue("@durum", txtDurum.SelectedValue);
            guncelle.Parameters.AddWithValue("@bolum", txtBolum.SelectedValue);

            // Exmi durumu (Label'daki metne göre 1 veya 0 gönderilir)
            guncelle.Parameters.AddWithValue("@ex", lblEx.Text == "True" ? 1 : 0);


            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarıyla güncellendi", "Kayıt güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglan().Close();
        }

        private void temizle()
        {
            txtAd.Text = "";
            txtBolum.Text = "";
            txtCinsiyet.Text = "";
            txtDurum.Text = "";
            txtID.Text = "";
            txtSikayet.Text = "";
            txtSoyad.Text = "";
            txtTarih.Text = "";
            txtTC.Text = "";
            txtTelefon.Text = "";
            txtYas.Text = "";
            rbHayir.Checked = true;
            lblEx.Text = "false";
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistik fr= new frmIstatistik();
            fr.Show();
        }
    }
}