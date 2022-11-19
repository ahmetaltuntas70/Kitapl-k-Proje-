using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplik_Proje
{
    public partial class Kitaplik : Form
    {
        public Kitaplik()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Samsung\Desktop\kitaplik.mdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Kitaplar", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
        string durum = "" ;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand ("insert into Kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum,KitapBasim,KitapFiyat,KitapDil) values (@p1,@p2,@p3,@p4,@p5,@p7,@p8,@p9)", baglanti);
            komut1.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut1.Parameters.AddWithValue("@p2", TxtKitapYazar.Text);
            komut1.Parameters.AddWithValue("@p3", CmbTur.Text);
            komut1.Parameters.AddWithValue("@p4", TxtKitapSayfa.Text);
            komut1.Parameters.AddWithValue("@p5", durum);
            komut1.Parameters.AddWithValue("@p7", TxtKitapBasim.Text);
            komut1.Parameters.AddWithValue("@p8", CmbFiyat.Text);
            komut1.Parameters.AddWithValue("@p9", CmbDil.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtKitapid.Text =        dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKitapAd.Text =        dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtKitapYazar.Text =     dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbTur.Text =            dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtKitapSayfa.Text =     dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtKitapBasim.Text =     dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            CmbFiyat.Text =          dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            CmbDil.Text =            dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            if                      (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True") 
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete From Kitaplar Where Kitapid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Listeden Silindi", "BiLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Update kitaplar set KitapAd=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5,KitapBasim=@p7,KitapFiyat=@p8,KitapDil=@p9 Where Kitapid=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p3", CmbTur.Text);
            komut.Parameters.AddWithValue("@p4", TxtKitapSayfa.Text);
           
            if (radioButton1.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if(radioButton2.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p7", TxtKitapBasim.Text);
            komut.Parameters.AddWithValue("@p8", CmbFiyat.Text);
            komut.Parameters.AddWithValue("@p9", CmbDil.Text);
            komut.Parameters.AddWithValue("@p6", TxtKitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar Where KitapAd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKitapBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar Where KitapAd like '%" + TxtKitapBul.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

