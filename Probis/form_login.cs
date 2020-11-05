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
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }
        public static OracleConnection conn = new OracleConnection("Data Source=xe;User ID=david27;Password=david27");
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        OracleDataAdapter adapter = new OracleDataAdapter();
        OracleCommand cmd;

        public static string idpeg = "";
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_pass.Text == "") MessageBox.Show("Harap Isi Semua Field ! ");
            else {
                if (txt_username.Text == "admin" && txt_pass.Text == "admin")
                {
                    HomeAdmin homeAdmin = new HomeAdmin();
                    this.Hide();
                    homeAdmin.ShowDialog();
                    this.Show();
                    txt_username.Text = "";
                    txt_pass.Text = "";
                }
                else
                {
                    setupdata();
                    bool cekuser=false, cekpass=false;
                    string jabatan="";
                    //string user = "";
                    foreach (DataTable table in ds.Tables)
                    {
                        foreach(DataRow row in table.Rows)
                        {
                            //user += row["uname"].ToString();
                            if (row["uname"].ToString() == txt_username.Text) 
                            {
                                cekuser = true;
                                if (row["pass"].ToString() == txt_pass.Text) {
                                    cekpass = true;
                                    jabatan = row["jabatan"].ToString();
                                    idpeg = row["id"].ToString();
                                }
                            }                                
                        }
                    }
                    //MessageBox.Show(user);
                    if(cekuser && cekpass) {
                        Home h = new Home();
                        this.Hide();
                        h.ShowDialog();
                        this.Show();
                    }
                    else {
                        if (!cekuser) { MessageBox.Show("Username Tidak Ditemukan !"); }
                        else if(!cekpass) { MessageBox.Show("Password Salah !"); }
                    }
                }
            }
        }
        private void setupdata(){
            conn.Open();
            string query = "Select PEGAWAI_USERNAME as uname,PEGAWAI_PASSWORD as pass,PEGAWAI_JABATAN as jabatan,pegawai_id as id FROM pegawai ";
            adapter = new OracleDataAdapter(query, conn);
            adapter.Fill(ds);
            conn.Close();
            conn.Close();

        }
    }
}
