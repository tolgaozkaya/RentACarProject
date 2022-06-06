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
    public partial class frmAracKayit : Form
    {
        Rentacar rentacar1 = new Rentacar();
        public frmAracKayit()
        {
            InitializeComponent();
        }

        private void frmAracKayit_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into araba(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,durumu,tarih) values (@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@durumu,@tarih)";
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
            komut2.Parameters.AddWithValue("@durumu", "BOŞTA");
            rentacar1.ekle(komut2, cumle);
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
            MessageBox.Show("Yeni Araç Eklendi..", "Uyarı");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboseri.Items.Clear();
                if (combomarka.SelectedIndex == 0)
                {
                    comboseri.Items.Add("A3");
                    comboseri.Items.Add("A4");
                    comboseri.Items.Add("A5");
                    comboseri.Items.Add("A6");
                    comboseri.Items.Add("A7");
                    comboseri.Items.Add("Q3");
                    comboseri.Items.Add("Q5");
                    comboseri.Items.Add("Q7");
                    comboseri.Items.Add("Q8");
                }
                else if (combomarka.SelectedIndex == 1)
                {
                    comboseri.Items.Add("M3");
                    comboseri.Items.Add("M4");
                    comboseri.Items.Add("M5");
                }
                else if (combomarka.SelectedIndex == 2)
                {
                    comboseri.Items.Add("Civic");
                    comboseri.Items.Add("CR-Z");
                    comboseri.Items.Add("Jazz");
                }
                else if (combomarka.SelectedIndex == 3)
                {
                    comboseri.Items.Add("Astra");
                    comboseri.Items.Add("Corsa");
                    comboseri.Items.Add("Mokka");
                }
                else if (combomarka.SelectedIndex == 4)
                {
                    comboseri.Items.Add("C Serisi");
                    comboseri.Items.Add("G Serisi");
                    comboseri.Items.Add("E Serisi");
                }
                else if (combomarka.SelectedIndex == 5)
                {
                    comboseri.Items.Add("Golf");
                    comboseri.Items.Add("Polo");
                    comboseri.Items.Add("T-Roc");
                }
                
            }
            catch
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
