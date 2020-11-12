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
            OracleCommand query = new OracleCommand("SELECT tour_nama,tour_id,tour_status FROM paket_tour", conn);
            da= new OracleDataAdapter(query);
            ds = new DataSet();
            conn.Close();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                comboBox3.Items.Add(ds.Tables[0].Rows[i][2].ToString());
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                if (ds.Tables[0].Rows[i][2].ToString().Equals("0"))
                {
                    comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString()+" **Tidak Aktif**");
                }else comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " **Aktif**");
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
            if (comboBox3.Items[comboBox1.SelectedIndex].ToString().Equals("0"))
            {
                btn_delete.ButtonText = "Aktifkan";
            }
            else btn_delete.ButtonText = "Nonaktifkan";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (comboBox3.Items[comboBox1.SelectedIndex].Equals("1")){
                DialogResult dialogResult = MessageBox.Show("Nonaktifkan Item Paket " + comboBox1.SelectedItem.ToString() + " ?", "Nonatkifkan Item Paket", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conn.Open();
                    OracleCommand query1 = new OracleCommand("update paket_tour set tour_status ='0' where tour_id='" + comboBox2.Items[comboBox1.SelectedIndex].ToString() + "'", conn);
                    query1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil Menonaktifkan" + comboBox1.SelectedItem.ToString());
                    cb();
                    comboBox1.SelectedIndex = -1;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Aktifkan Item Paket " + comboBox1.SelectedItem.ToString() + " ?", "Atkifkan Item Paket", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conn.Open();
                    OracleCommand query1 = new OracleCommand("update paket_tour set tour_status ='1' where tour_id='" + comboBox2.Items[comboBox1.SelectedIndex].ToString() + "'", conn);
                    query1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil Mengaktifkan" + comboBox1.SelectedItem.ToString());
                    cb();
                    comboBox1.SelectedIndex = -1;
                }
            }
        }
    }
}
