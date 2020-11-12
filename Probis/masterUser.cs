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
    public partial class masterUser : Form
    {
        public masterUser()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;
        OracleCommand cmd;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        string idselected = "";

        private void masterUser_Load(object sender, EventArgs e)
        {
            dgv();

        }
        void dgv()
        {
            ds.Clear();
            conn.Close();
            conn.Open();
            da = new OracleDataAdapter("Select * from pegawai", conn);
            ds = new DataSet();
            da.Fill(ds);
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["PEGAWAI_STATUS"].ToString() == "0")
                    {
                        row["PEGAWAI_STATUS"] = "Tidak Aktif";
                    }
                    else row["PEGAWAI_STATUS"] = "Aktif";
                }
            }
            dgv_listUser.DataSource = ds.Tables[0];
            conn.Close();

        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_baru_Click(object sender, EventArgs e)
        {
            add_user add = new add_user();
            add.ShowDialog();
            Loaddata();
            this.Show();
        }
        void Loaddata() 
        {
            conn.Open();
            da = new OracleDataAdapter("Select * from pegawai", conn);
            ds = new DataSet();
            da.Fill(ds);
            dgv_listUser.DataSource = ds.Tables[0];
            conn.Close();
        }
        string mode = "";
        private void dgv_listUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idselected = dgv_listUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (dgv_listUser.Rows[e.RowIndex].Cells[6].Value.ToString().Equals("Aktif"))
                {
                    mode = "non";
                    btn_hapus.ButtonText = "Nonaktifkan";
                }
                else if (dgv_listUser.Rows[e.RowIndex].Cells[6].Value.ToString().Equals("Tidak Aktif")) {
                    mode = "aktif";
                    btn_hapus.ButtonText = "Aktifkan"; 
                }
            }
            else idselected = "";
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (idselected == "") { MessageBox.Show("Harap Pilih User Terlebih Dahulu"); }
            else
            {
                conn.Close();
                conn.Open();
                if (mode == "non")
                {
                    cmd = new OracleCommand("Update Pegawai set pegawai_status='0' where pegawai_id='" + idselected + "'", conn);
                    btn_hapus.ButtonText = "Aktifkan";
                }
                else if (mode=="aktif") {
                    cmd = new OracleCommand("Update Pegawai set pegawai_status='1' where pegawai_id='" + idselected + "'", conn);
                    btn_hapus.ButtonText = "Nonaktifkan";
                }
                cmd.ExecuteNonQuery();
                masterUser_Load(sender, e);
                conn.Close();
                dgv();
            }
        }
    }
}
