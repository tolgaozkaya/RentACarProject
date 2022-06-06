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
    public partial class frmSatis : Form
    {
        Rentacar rentacar = new Rentacar();
        public frmSatis()
        {
            InitializeComponent();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from satis";
            MySqlDataAdapter adptr = new MySqlDataAdapter();
            dataGridView1.DataSource = rentacar.listele(adptr,sorgu);
            rentacar.kiralama(txtkiratutari);
        }
    }
}
