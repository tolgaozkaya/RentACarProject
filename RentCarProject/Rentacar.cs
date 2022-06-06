using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarProject
{
    class Rentacar
    {
        MySqlConnection baglanti = new MySqlConnection("server=localhost;user id=root;database=rentacar;password=1234");
        DataTable tablo;
      
        public void ekle(MySqlCommand komut,string sorgu)
        { 
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public DataTable listele(MySqlDataAdapter adptr, string sorgu)
        {
            tablo = new DataTable();
            adptr = new MySqlDataAdapter(sorgu,baglanti);
            adptr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void bos_araclar(ComboBox combobox,string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu,baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combobox.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }
        public void tc_arama(TextBox tc, TextBox adsoyad,TextBox telefon, string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu,baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        public void araba_arama(ComboBox araclar,TextBox marka, TextBox seri, TextBox yil,TextBox renk, string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();
            }
            baglanti.Close();
        }

        public void kiratutar_hesap(ComboBox kirasekli, TextBox ucret, string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (kirasekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString() ;
                if (kirasekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.8).ToString() ;
                if (kirasekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.75).ToString() ;
            }
            baglanti.Close();
        }

        public void kiralama(TextBox textBox)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select SUM(tutar) from satis",baglanti);
            textBox.Text = "Toplam Tutar= " + komut.ExecuteScalar() + " TL";
            baglanti.Close();
        }
    }
}
