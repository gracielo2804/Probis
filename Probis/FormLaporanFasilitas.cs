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
    public partial class FormLaporanFasilitas : Form
    {
        public FormLaporanFasilitas()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;
        OracleDataAdapter adapter = new OracleDataAdapter();
        DataSet ds = new DataSet();

        private void btnTampil_Click(object sender, EventArgs e)
        {
            LaporanFasilitas rprtFasilitas = new LaporanFasilitas();
            try
            {
                rprtFasilitas.SetDatabaseLogon("probis", "probis");
            }
            catch (Exception)
            {

                throw;
            }
            OracleCommand query = new OracleCommand();
            query.Connection = conn;
            OracleDataAdapter adapter = new OracleDataAdapter(query);
            DataSet dataset = new DataSet();
            query.CommandText = "SELECT * FROM CUSTOMER";
            adapter.Fill(dataset, "CUSTOMER");
            query.CommandText = "SELECT * FROM DHOTEL";
            adapter.Fill(dataset, "DHOTEL");
            query.CommandText = "SELECT DISTINCT replace(dkendaraan,'BIS',null)as DKENDARAAN,replace(dhotel_nama,'DALAM PERJALANAN',null) as DHOTEL_NAMA FROM DPAKET where tour_id='" + comboBox1.SelectedValue.ToString() + "'and dkendaraan != 'BIS' or dhotel_nama!='DALAM PERJALANAN order by 1' ";
            adapter.Fill(dataset, "DPAKET");
            query.CommandText = "SELECT * FROM DTRANS";
            adapter.Fill(dataset, "DTRANS");
            query.CommandText = "SELECT * FROM FLIGHT";
            adapter.Fill(dataset, "FLIGHT");
            query.CommandText = "SELECT * FROM HOTEL";
            adapter.Fill(dataset, "HOTEL");
            query.CommandText = "SELECT * FROM HTRANS; ";
            adapter.Fill(dataset, "HTRANS");
            query.CommandText = "SELECT * FROM MASKAPAI";
            adapter.Fill(dataset, "MASKAPAI");
            query.CommandText = "SELECT * FROM PAKET_TOUR";
            adapter.Fill(dataset, "PAKET_TOUR");
            query.CommandText = "SELECT * FROM PEGAWAI";
            adapter.Fill(dataset, "PEGAWAI");
            query.CommandText = "SELECT * FROM TRAINS";
            adapter.Fill(dataset, "TRAINS");
            rprtFasilitas.SetDataSource(dataset);
            //rprtTransaksi.SetParameterValue("tanggal_awal", dtAwal.Value);
            //rprtTransaksi.SetParameterValue("tanggal_akhir", dtAkhir.Value);
            crystalReportViewer1.ReportSource = rprtFasilitas;
        }

        private void FormLaporanFasilitas_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            comboBox1.Items.Clear();
            string query = "SELECT tour_nama,tour_id,tour_status FROM paket_tour";
            adapter = new OracleDataAdapter(query, conn);
            adapter.Fill(ds);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "tour_id";
            comboBox1.DisplayMember = "tour_nama";
        }
    }
}
