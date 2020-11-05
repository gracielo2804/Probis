using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Probis
{
    public partial class Booking_Flight : Form
    {
        OracleConnection conn = form_login.conn;

        OracleDataAdapter transAdapter;
        DataTable transTable;
        public Booking_Flight()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Apakah Data Sesuai ?", "Warning", MessageBoxButtons.YesNo);
            if (d==DialogResult.Yes)
            {
                DetailPesananUser b = new DetailPesananUser();
                this.Hide();
                b.ShowDialog();
                this.Show();
            }
        }

        private void Booking_Flight_Load(object sender, EventArgs e)
        {
            transAdapter = new OracleDataAdapter($"select customer_id as Id,customer_name as Nama,customer_email as Email,customer_alamat as Alamat,customer_phone as Telefon,CUSTOMER_PASSPORT as Passport from customer where 1 = 2", conn);

            OracleCommandBuilder builder = new OracleCommandBuilder(transAdapter);
            transAdapter.InsertCommand = builder.GetInsertCommand();
            transTable = new DataTable();
            transAdapter.Fill(transTable);
            dgv_pesanan.DataSource = transTable;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Yakin Membatalkan Proses Ini?", "Warning", MessageBoxButtons.YesNo);
            if(d== DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            DataRow dr = transTable.NewRow();
            dr["Nama"] = tbnama.Text;
            dr["Email"] = tbemail.Text;
            dr["Alamat"] = tbalamat.Text;
            dr["Telefon"] = tbtelfon.Text;
            dr["Passport"] = tbpassport.Text;
            transTable.Rows.Add(dr);
            tbnama.Text = "";
            tbemail.Text = "";
            tbalamat.Text = "";
            tbtelfon.Text = "";
            tbpassport.Text = "";
        }
    }
}
