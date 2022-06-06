using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarProject
{
    public partial class frmAracListele : Form
    {
        Rentacar rentacar = new Rentacar();
        public frmAracListele()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtid.Text = satir.Cells["id"].Value.ToString();
            txtplaka.Text = satir.Cells["plaka"].Value.ToString();
            combomarka.Text= satir.Cells["marka"].Value.ToString();
            comboseri.Text = satir.Cells["seri"].Value.ToString();
            txtyil.Text = satir.Cells["yil"].Value.ToString();
            txtrenk.Text = satir.Cells["renk"].Value.ToString();
            txtkm.Text= satir.Cells["km"].Value.ToString();
            comboyakit.Text = satir.Cells["yakit"].Value.ToString();
            txtkira.Text = satir.Cells["kiraucreti"].Value.ToString();
            pictureBox1.ImageLocation = satir.Cells["resim"].Value.ToString();
        }

        private void frmAracListele_Load(object sender, EventArgs e)
        {
            YenileArabaListele();
        }

        private void YenileArabaListele()
        {
            string cumle = "select * from araba";
            MySqlDataAdapter adptr2 = new MySqlDataAdapter();
            dataGridView1.DataSource = rentacar.listele(adptr2, cumle);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string cumle = "update araba set plaka=@plaka,marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih where id=@id";
            MySqlCommand komut2 = new MySqlCommand();
            komut2.Parameters.AddWithValue("@plaka", txtplaka.Text);
            komut2.Parameters.AddWithValue("@marka", combomarka.Text);
            komut2.Parameters.AddWithValue("@seri", comboseri.Text);
            komut2.Parameters.AddWithValue("@yil", txtyil.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@km", txtkm.Text);
            komut2.Parameters.AddWithValue("@yakit", comboyakit.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", Convert.ToInt32(txtkira.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@id", txtid.Text);
            rentacar.ekle(komut2, cumle);
            comboseri.Items.Clear();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
            foreach (Control item in Controls)
            {
                if (item is ComboBox)
                    item.Text = "";
            }
            pictureBox1.Image = null;
            YenileArabaListele();
            MessageBox.Show("Araç Verisi Güncellendi..", "Uyarı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            MySqlCommand komut2 = new MySqlCommand();
            string cumle = "delete from araba where id=@id";
            komut2.Parameters.AddWithValue("@id", txtid.Text);
            rentacar.ekle(komut2, cumle);
            YenileArabaListele();
            MessageBox.Show("Araç Verisi Silindi..","Uyarı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
            foreach (Control item in Controls)
            {
                if (item is ComboBox)
                    item.Text = "";
            }
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cumle = "select * from araba where marka like '%" + textBox1.Text + "%'";
            MySqlDataAdapter adptr2 = new MySqlDataAdapter();
            dataGridView1.DataSource = rentacar.listele(adptr2, cumle);
        }

        private void combodurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combodurum.SelectedIndex == 0)
                {
                    YenileArabaListele();
                }
                else if (combodurum.SelectedIndex == 1)
                {
                    string cumle = "select * from araba where durumu='BOŞTA'";
                    MySqlDataAdapter adptr2 = new MySqlDataAdapter();
                    dataGridView1.DataSource = rentacar.listele(adptr2, cumle);
                }
                else if (combodurum.SelectedIndex == 2)
                {
                    string cumle = "select * from araba where durumu='DOLU'";
                    MySqlDataAdapter adptr2 = new MySqlDataAdapter();
                    dataGridView1.DataSource = rentacar.listele(adptr2, cumle);
                }

            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
