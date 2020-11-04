using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Probis
{
    public partial class Home : Form
    {
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        public Home()
        {
            InitializeComponent();
            dgv();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void dgv()
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand("SELECT tour_id as ID tour_nama as Nama_Tour,tour_date_awal as Tanggal_Tour,tour_harga as Harga from paket_tour", conn);
            da = new OracleDataAdapter(cmd);
            ds = new DataSet();
            conn.Close();
            da.Fill(ds, "paket");
            dgv_list.DataSource = ds;
            dgv_list.DataMember = "paket";
        }
        public static string id="";
        private void dgv_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                lihatPaket l = new lihatPaket();
                this.Hide();
                l.ShowDialog();
                this.Show();
                id = dgv_list.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
