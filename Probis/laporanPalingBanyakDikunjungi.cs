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
    public partial class laporanPalingBanyakDikunjungi : Form
    {
        public laporanPalingBanyakDikunjungi()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;
        private void btnTampil_Click(object sender, EventArgs e)
        {
            LaporanTransaksi rprtTransaksi = new LaporanTransaksi();
            try
            {
                rprtTransaksi.SetDatabaseLogon("probis", "probis");
            }
            catch (Exception)
            {

                throw;
            }
            string dtawal = dtAwal.Value.ToShortDateString();
            string dtakhir = dtAkhir.Value.ToShortDateString();
            OracleCommand query = new OracleCommand();
            query.Connection = conn;
            OracleDataAdapter adapter = new OracleDataAdapter(query);
            DataSet dataset = new DataSet();
            query.CommandText = "SELECT * FROM CUSTOMER";
            adapter.Fill(dataset, "CUSTOMER");
            query.CommandText = "SELECT * FROM DHOTEL";
            adapter.Fill(dataset, "DHOTEL");
            query.CommandText = "SELECT * FROM DPAKET";
            adapter.Fill(dataset, "DPAKET");
            query.CommandText = "SELECT * FROM DTRANS";
            adapter.Fill(dataset, "DTRANS");
            query.CommandText = "SELECT * FROM FLIGHT";
            adapter.Fill(dataset, "FLIGHT");
            query.CommandText = "SELECT * FROM HOTEL";
            adapter.Fill(dataset, "HOTEL");
            //query.CommandText = "SELECT * FROM HTRANS where TRANS_DATE>TO_DATE('"+dtawal+ "','dd mm yyyy') and TRANS_DATE<TO_DATE('" + dtakhir + "','dd mm yyyy') ; ";
            query.CommandText = "SELECT * FROM HTRANS where TRANS_DATE BETWEEN '"+dtawal+"' AND '"+dtakhir+"' ";
            
            adapter.Fill(dataset, "HTRANS");
            query.CommandText = "SELECT * FROM MASKAPAI";
            adapter.Fill(dataset, "MASKAPAI");
            query.CommandText = "SELECT * FROM PAKET_TOUR";
            adapter.Fill(dataset, "PAKET_TOUR");
            query.CommandText = "SELECT * FROM PEGAWAI";
            adapter.Fill(dataset, "PEGAWAI");
            query.CommandText = "SELECT * FROM TRAINS";
            adapter.Fill(dataset, "TRAINS");
            rprtTransaksi.SetDataSource(dataset);

            rprtTransaksi.SetParameterValue("tanggal_awal", dtAwal.Value);
            rprtTransaksi.SetParameterValue("tanggal_akhir", dtAkhir.Value);
            crystalReportViewer1.ReportSource = rprtTransaksi;
        }

        private void laporanPalingBanyakDikunjungi_Load(object sender, EventArgs e)
        {

        }
    }
}
