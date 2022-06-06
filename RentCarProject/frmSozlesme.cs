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
    public partial class frmSozlesme : Form
    {
        Rentacar rentacar = new Rentacar();
        public frmSozlesme()
        {
            InitializeComponent();
        }

        private void frmSozlesme_Load(object sender, EventArgs e)
        {
            Bos_Araclar();
            Yenile_Sozlesme();

        }

        private void Bos_Araclar()
        {
            string sorgu2 = "select *from araba where durumu='BOŞTA'";
            rentacar.bos_araclar(comboaraclar, sorgu2);
        }

        private void Yenile_Sozlesme()
        {
            MySqlDataAdapter adptr = new MySqlDataAdapter();
            string sorgu = "select * from sozlesme";
            dataGridView1.DataSource = rentacar.listele(adptr, sorgu);
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            if (txttc.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
            }
            string sorgu = "select * from musteri where tc like'"+ txttc.Text +"'";
            rentacar.tc_arama(txttc, txtadsoyad, txttelefon, sorgu);
        }

        private void comboaraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from araba where plaka like'" + comboaraclar.SelectedItem + "'";
            rentacar.araba_arama(comboaraclar, txtmarka, txtseri, txtyil, txtrenk, sorgu);

        }

        private void combokira_sekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from araba where plaka like'" + comboaraclar.SelectedItem + "'";
            rentacar.kiratutar_hesap(combokira_sekli, txtkira_ucreti, sorgu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dtarih.Text) - DateTime.Parse(ctarih.Text);
            int gun2 = gun.Days;
            txtgun.Text = gun2.ToString();
            txttutar.Text = (gun2 * int.Parse(txtkira_ucreti.Text)).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            ctarih.Text = DateTime.Now.ToShortDateString();
            dtarih.Text = DateTime.Now.ToShortDateString();
            combokira_sekli.Text = "";
            txtkira_ucreti.Text = "";
            txtgun.Text = "";
            txttutar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into sozlesme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,ctarih,dtarih) values (@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            MySqlCommand komut2 = new MySqlCommand();
            komut2.Parameters.AddWithValue("@tc", txttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtehliyet_no.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtehliyet_tarih.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtehliyet_yer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboaraclar.Text);
            komut2.Parameters.AddWithValue("@marka", txtmarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtseri.Text);
            komut2.Parameters.AddWithValue("@yil", txtyil.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", combokira_sekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", Convert.ToInt32(txtkira_ucreti.Text));
            komut2.Parameters.AddWithValue("@gun", Convert.ToInt32(txtgun.Text));
            komut2.Parameters.AddWithValue("@tutar", Convert.ToInt32(txttutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", ctarih.Text);
            komut2.Parameters.AddWithValue("@dtarih", dtarih.Text);
            rentacar.ekle(komut2, sorgu);
            string sorgu3 = "update araba set durumu='DOLU' where plaka='" + comboaraclar.Text + "'";
            MySqlCommand komut3 = new MySqlCommand();
            rentacar.ekle(komut3, sorgu3);
            comboaraclar.Items.Clear();
            Bos_Araclar();
            Yenile_Sozlesme();
            comboaraclar.Text = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
            Sil();
            MessageBox.Show("Sözleşme Başarıyla Eklenmiştir..","Uyarı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "update sozlesme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,e_tarih=@e_tarih,e_yer=@e_yer,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kirasekli=@kirasekli,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,ctarih=@ctarih,dtarih=@dtarih where plaka=@plaka";
            MySqlCommand komut2 = new MySqlCommand();
            komut2.Parameters.AddWithValue("@tc", txttc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtehliyet_no.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtehliyet_tarih.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtehliyet_yer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboaraclar.Text);
            komut2.Parameters.AddWithValue("@marka", txtmarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtseri.Text);
            komut2.Parameters.AddWithValue("@yil", txtyil.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", combokira_sekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", Convert.ToInt32(txtkira_ucreti.Text));
            komut2.Parameters.AddWithValue("@gun", Convert.ToInt32(txtgun.Text));
            komut2.Parameters.AddWithValue("@tutar", Convert.ToInt32(txttutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", ctarih.Text);
            komut2.Parameters.AddWithValue("@dtarih", dtarih.Text);
            rentacar.ekle(komut2, sorgu);
            comboaraclar.Items.Clear();
            Bos_Araclar();
            Yenile_Sozlesme();
            comboaraclar.Text = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
            Sil();
            MessageBox.Show("Sözleşme Verileri Güncellendi..","Uyarı");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txttc.Text = satir.Cells[0].Value.ToString();
            txtadsoyad.Text = satir.Cells[1].Value.ToString();
            txttelefon.Text = satir.Cells[2].Value.ToString();
            txtehliyet_no.Text = satir.Cells[3].Value.ToString();
            txtehliyet_tarih.Text = satir.Cells[4].Value.ToString();
            txtehliyet_yer.Text = satir.Cells[5].Value.ToString();
            comboaraclar.Text = satir.Cells[6].Value.ToString();
            txtmarka.Text = satir.Cells[7].Value.ToString();
            txtseri.Text= satir.Cells[8].Value.ToString();
            txtyil.Text = satir.Cells[9].Value.ToString();
            txtrenk.Text = satir.Cells[10].Value.ToString();
            combokira_sekli.Text= satir.Cells[11].Value.ToString();
            txtkira_ucreti.Text = satir.Cells[12].Value.ToString();
            txtgun.Text = satir.Cells[13].Value.ToString();
            txttutar.Text= satir.Cells[14].Value.ToString();
            ctarih.Text = satir.Cells[15].Value.ToString();
            dtarih.Text = satir.Cells[16].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            // Gün Farki Hesapla
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dönüs = DateTime.Parse(satir.Cells["dtarih"].Value.ToString());
            int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarki = bugün - dönüs;
            int _gunfarki = gunfarki.Days;
            int ucretfarki;
            // Ücret Farki Hesapla
            ucretfarki= (_gunfarki +1) * ucret;
            txtpara.Text = ucretfarki.ToString();
            // Toplam Tutar Hesapla
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtpara.Text) >= 0 || int.Parse(txtpara.Text) < 0)
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satir.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satir.Cells["tutar"].Value.ToString());
                DateTime çıkış = DateTime.Parse(satir.Cells["ctarih"].Value.ToString());
                TimeSpan gun = bugün - çıkış;
                int _gun = gun.Days;
                int toplamtutar = (_gun+1) * ucret;
                ///Toplamtutar, gun ve ucret satış tablosuna aktarılacak
                string sorgu1 = "delete from sozlesme where plaka='" + satir.Cells["plaka"].Value.ToString()+"'";
                MySqlCommand komut = new MySqlCommand();
                rentacar.ekle(komut, sorgu1);
                string sorgu2 = "update araba set durumu='BOŞTA' where plaka='" + satir.Cells["plaka"].Value.ToString()+"'";
                MySqlCommand komut3 = new MySqlCommand();
                rentacar.ekle(komut3, sorgu2);

                string sorgu3 = "insert into satis(tc,adsoyad,plaka,marka,seri,yil,renk,gun,tutar,tarih1,tarih2,fiyat) values (@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@tutar,@tarih1,@tarih2,@fiyat)";
                MySqlCommand komut2 = new MySqlCommand();
                komut2.Parameters.AddWithValue("@tc", satir.Cells["tc"].Value.ToString()) ;
                komut2.Parameters.AddWithValue("@adsoyad", satir.Cells["adsoyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@plaka", satir.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", satir.Cells["marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@seri", satir.Cells["seri"].Value.ToString());
                komut2.Parameters.AddWithValue("@yil", satir.Cells["yil"].Value.ToString());
                komut2.Parameters.AddWithValue("@renk", satir.Cells["renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@gun", _gun);
                komut2.Parameters.AddWithValue("@tutar", toplamtutar);
                komut2.Parameters.AddWithValue("@tarih1", satir.Cells["ctarih"].Value.ToString());
                komut2.Parameters.AddWithValue("@tarih2", DateTime.Now.ToString());
                komut2.Parameters.AddWithValue("@fiyat", ucret);
                rentacar.ekle(komut2,sorgu3);
                txtpara.Text = "";
                comboaraclar.Items.Clear();
                Bos_Araclar();
                Yenile_Sozlesme();
                comboaraclar.Text = "";
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
                Sil();
                MessageBox.Show("Araba Teslim Edilmiştir..", "Uyarı");
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız", "Uyarı");
            }
        } 
    }
}
