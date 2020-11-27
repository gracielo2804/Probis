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
    public partial class DetailPesananUser : Form
    {
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        OracleDataAdapter transAdapter;
        public DetailPesananUser()
        {
            InitializeComponent();
            conn.Close();
            conn.Open();
            dgv_detail.DataSource = Booking_Flight.transTable;
            OracleCommand query = new OracleCommand("SELECT TOUR_DATE_AWAL,TOUR_DATE_AKHIR,TOUR_NAMA FROM paket_tour where TOUR_ID ='" + Home.id.ToString()+"'", conn);
            da = new OracleDataAdapter(query);
            ds = new DataSet();
            conn.Close();
            da.Fill(ds);
            DateTime time1 = Convert.ToDateTime(ds.Tables[0].Rows[0][0].ToString());
            DateTime time2 = Convert.ToDateTime(ds.Tables[0].Rows[0][1].ToString());
            txt_namapaket.Text = ds.Tables[0].Rows[0][2].ToString();
            bunifuCustomLabel4.Text = time1.ToString("dd - MMMM - yyyy") +" - "+ time2.ToString("dd - MMMM - yyyy");
            conn.Close();
            conn.Open();
            dgv_detail.DataSource = Booking_Flight.transTable;
             query = new OracleCommand("SELECT dhari FROM dpaket where TOUR_ID ='" + Home.id.ToString() + "'", conn);
            da = new OracleDataAdapter(query);
            ds = new DataSet();
            conn.Close();
            da.Fill(ds);
            bunifuCustomLabel3.Text = ds.Tables[0].Rows.Count.ToString()+" Hari";
            int HargaJumlah = dgv_detail.Rows.Count;
            MessageBox.Show(HargaJumlah.ToString());
            int biaya = Convert.ToInt32(detailHarga.tax) + Home.harga+75000+954000;
            int total = HargaJumlah * biaya;
            lbl_harga.Text ="Rp "+total.ToString("#,##0");
        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Yakin Sesuai ?", "Warning", MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                pesananBerhasil p = new pesananBerhasil();
                this.Hide();
                p.ShowDialog();
                this.Show();
            }
        }
    }
}
