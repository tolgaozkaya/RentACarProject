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
    public partial class frmMusteriEkle : Form
    {
        Rentacar rentacar = new Rentacar();

        public frmMusteriEkle()
        {
            InitializeComponent();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into musteri(tc,adsoyad,telefon,adres,email) values(@tc, @adsoyad, @telefon, @adres, @email)";
            MySqlCommand komut2 = new MySqlCommand();
            komut2.Parameters.AddWithValue("@tc", txttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtadres.Text);
            komut2.Parameters.AddWithValue("@email", txtmail.Text);
            rentacar.ekle(komut2, cumle);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }

            MessageBox.Show("Müşteri Başarıyla Kaydedilmiştir..","Uyarı");
            
        }
    }
}
