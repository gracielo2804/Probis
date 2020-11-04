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
    public partial class ListFlight : Form
    {
        public ListFlight()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt = new DataTable();

        private void ListFlight_Load(object sender, EventArgs e)
        {
            conn.Open();
            da = new OracleDataAdapter("Select f.FLIGHT_ID as ID,m.maskapai_nama as Maskapai,f.FLIGHT_ASAL as Asal,f.FLIGHT_TUJUAN as Tujuan,to_char(f.flight_datetime,'DD - Month - YYYY') as Tanggal,to_char(f.flight_datetime,'HH24:MI')as Jam,f.Flight_harga as Harga  from flight f,maskapai m where f.flight_maskapai=m.maskapai_id", conn);
            ds = new DataSet();
            da.Fill(ds);
            da.Fill(dt);
            dgv_listflight.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_baru_Click(object sender, EventArgs e)
        {
            addFlight add = new addFlight();
            add.ShowDialog();
            this.Show();
            ListFlight_Load(sender,e);
            
        }
        public static string idpesawat="";
        private void dgv_listflight_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Masterdetail.pesawat == true)
            {
                if (e.RowIndex > -1)
                {
                    idpesawat = dgv_listflight.Rows[e.RowIndex].Cells[1].Value.ToString();
                    MessageBox.Show("Berhasil Memilih Pesawat");
                    Masterdetail.pesawat = false;
                }
            }
        }
    }
}
