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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriEkle form = new frmMusteriEkle();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriListele form2 = new frmMusteriListele();
            form2.Size= new Size(1045, 563);
            form2.ShowDialog();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            frmAracKayit form1 = new frmAracKayit();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAracListele form2 = new frmAracListele();
            form2.Size = new Size(1045, 675);
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSozlesme form3 = new frmSozlesme();
            form3.Size = new Size(1045, 763);
            form3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSatis form4 = new frmSatis(); 
            form4.Size = new Size(1045, 755);
            form4.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
