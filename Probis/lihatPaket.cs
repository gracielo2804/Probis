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
    public partial class lihatPaket : Form
    {
        OracleConnection  conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        DataRow dr;
        public lihatPaket()
        {
            InitializeComponent();
        }

        void cbox()
        {
            comboBox1.Items.Clear();
            conn.Open();
            OracleCommand query = new OracleCommand("SELECT dhari FROM dpaket where tour_id ='"+Home.id+"'", conn);
            da = new OracleDataAdapter(query);
            ds = new DataSet();
            conn.Close();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            comboBox1.SelectedIndex=0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT ddari,ddtujuan,dkendaraan,dhotel_nama,tour_deskripsi from dpaket where tour_id ='" + Home.id + "' and dhari='" + comboBox1.SelectedItem.ToString() + "'", conn);
                da = new OracleDataAdapter(cmd);
                ds = new DataSet();
                conn.Close();
                da.Fill(ds);
                dr = ds.Tables[0].Rows[0];
                lbl_dari.Text = dr.ItemArray.GetValue(0).ToString();
                lbl_tujuan.Text = dr.ItemArray.GetValue(1).ToString();
                lbl_kendaraan.Text = dr.ItemArray.GetValue(2).ToString();
                lbl_hotel.Text = dr.ItemArray.GetValue(3).ToString();
                richTextBox1.Text = dr.ItemArray.GetValue(4).ToString();
            }
        }

        private void btn_detailHarga_Click(object sender, EventArgs e)
        {
            detailHarga d = new detailHarga();
            this.Hide();
            d.ShowDialog();
            this.Show();
        }

        private void lihatPaket_Load(object sender, EventArgs e)
        {
            cbox();
        }
    }
}
