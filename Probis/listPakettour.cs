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
    public partial class listPakettour : Form
    {
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        public listPakettour()
        {
            InitializeComponent();
            cb();
        }
        void cb()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            conn.Open();
            OracleCommand query = new OracleCommand("SELECT tour_nama,tour_id FROM paket_tour", conn);
            da= new OracleDataAdapter(query);
            ds = new DataSet();
            conn.Close();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                comboBox2.Items.Add(ds.Tables[0].Rows[i][1].ToString());
        }
        void dgv()
        {
            conn.Open();
            /*  MessageBox.Show(cbPaket.SelectedItem.ToString());*/
            OracleCommand query = new OracleCommand("SELECT dhari as Hari,ddari as Dari ,ddtujuan as Tujuan ,dkendaraan as Kendaraan,dhotel_nama as Hotel,tour_deskripsi as Deskripsi" +
                "                    FROM dpaket " +
                "                       where tour_id= '" + comboBox2.Items[comboBox1.SelectedIndex].ToString()+ "'", conn);
            da= new OracleDataAdapter(query);
            ds= new DataSet();
            conn.Close();
            da.Fill(ds, "paket");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "paket";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Masterdetail m = new Masterdetail();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Item Paket "+comboBox1.SelectedItem.ToString()+" ?", "Delete Item Paket", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                /*  MessageBox.Show(cbPaket.SelectedItem.ToString());*/
                OracleCommand query = new OracleCommand("delete dpaket where tour_id='" + comboBox2.Items[comboBox1.SelectedIndex].ToString() + "'", conn);
                query.ExecuteNonQuery();
                OracleCommand query1 = new OracleCommand("delete paket_tour where tour_id ='" + comboBox2.Items[comboBox1.SelectedIndex].ToString() + "'",conn);
                query1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Berhasil Delete"+comboBox1.SelectedItem.ToString());
                cb();
                comboBox1.SelectedIndex = -1;
            }
        }
    }
}
