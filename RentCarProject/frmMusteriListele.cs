using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace RentCarProject
{
    public partial class frmMusteriListele : Form
    {
        Rentacar rentacar1 = new Rentacar();
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cumle = "select * from musteri";
            MySqlDataAdapter adptr2 = new MySqlDataAdapter();
            dataGridView1.DataSource = rentacar1.listele(adptr2, cumle);
        }



        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Text = satir.Cells[0].Value.ToString();
            txttc.Text = satir.Cells[1].Value.ToString();
            txtadsoyad.Text = satir.Cells[2].Value.ToString();
            txttelefon.Text = satir.Cells[3].Value.ToString();
            txtadres.Text = satir.Cells[4].Value.ToString();
            txtmail.Text = satir.Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cumle = "update musteri set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where id=@id";
            MySqlCommand komut2 = new MySqlCommand();
            komut2.Parameters.AddWithValue("@tc", txttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtadres.Text);
            komut2.Parameters.AddWithValue("@email", txtmail.Text);
            komut2.Parameters.AddWithValue("@id", textBox2.Text);
            rentacar1.ekle(komut2, cumle);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
      
            YenileListele();
            MessageBox.Show("Müşteri Bilgileri Güncellendi..", "Uyarı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from musteri where id=@id";
            MySqlCommand komut2 = new MySqlCommand();
            komut2.Parameters.AddWithValue("@id", textBox2.Text);
            rentacar1.ekle(komut2, cumle);
            YenileListele();
            MessageBox.Show("Müşteri Bilgileri Silindi..", "Uyarı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdaGoreListele();
        }

        private void AdaGoreListele()
        {
            string cumle = "select * from musteri where adsoyad like '%"+ textBox1.Text +"%'";
            MySqlDataAdapter adptr2 = new MySqlDataAdapter();
            dataGridView1.DataSource = rentacar1.listele(adptr2, cumle);
        }
    }
}
