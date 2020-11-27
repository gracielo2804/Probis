using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Probis
{
    public partial class Booking_Flight : Form
    {
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        OracleDataAdapter transAdapter;
        public static DataTable transTable;
        string NoTelefon,NoPassport;
        bool ketemutelfon = false, KetemuPassport = false,updatepassport = false,updatetelfon=false;
        public Booking_Flight()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Apakah Data Sesuai ?", "Warning", MessageBoxButtons.YesNo);
            if (d==DialogResult.Yes)
            {
                DetailPesananUser b = new DetailPesananUser();
                this.Hide();
                b.ShowDialog();
                this.Show();
            }
        }

        private void Booking_Flight_Load(object sender, EventArgs e)
        {
            transAdapter = new OracleDataAdapter($"select customer_name as Nama,customer_email as Email,customer_alamat as Alamat,customer_phone as Telefon,CUSTOMER_PASSPORT as Passport from customer where 1 = 2", conn);

            OracleCommandBuilder builder = new OracleCommandBuilder(transAdapter);
            transAdapter.InsertCommand = builder.GetInsertCommand();
            transTable = new DataTable();
            transAdapter.Fill(transTable);
            dgv_pesanan.DataSource = transTable;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Yakin Membatalkan Proses Ini?", "Warning", MessageBoxButtons.YesNo);
            if(d== DialogResult.Yes)
            {
                this.Hide();
            }
            conn.Close();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                da = new OracleDataAdapter("Select customer_id as id from customer", conn);
                string lastid = "";
                da.Fill(ds);
                if (ds.Tables.Count != 0)
                {
                    foreach (DataTable dt in ds.Tables)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            lastid = row["id"].ToString();
                        }
                    }
                }
                int lastidangka=0;
                if (ds.Tables[0].Rows.Count != 0)
                {
                    lastidangka = int.Parse(lastid.Substring(2, 4));
                }
                int idangka = lastidangka + 1;
                string idinput = "CU";
                if (idangka < 10) idinput += "000" + idangka;
                else if (idangka >= 10 && idangka < 100) idinput += "00" + idangka;
                else if (idangka >= 100 && idangka < 1000) idinput += "0" + idangka;
                else if (idangka >= 1000 && idangka < 10000) idinput += idangka;
                OracleCommand cmd = new OracleCommand("INSERT INTO customer VALUES('" + idinput + "','" + tbnama.Text + "','" + tbemail.Text+ "','" + tbalamat.Text+ "','"+tbtelfon.Text+"','"+tbpassport.Text+"')", conn);
                cmd.ExecuteNonQuery();
                DataRow dr = transTable.NewRow();
                dr["Nama"] = tbnama.Text;
                dr["Email"] = tbemail.Text;
                dr["Alamat"] = tbalamat.Text;
                dr["Telefon"] = tbtelfon.Text;
                dr["Passport"] = tbpassport.Text;
                transTable.Rows.Add(dr);
                tbnama.Text = "";
                tbemail.Text = "";
                tbalamat.Text = "";
                tbtelfon.Text = "";
                tbpassport.Text = "";
            }
            catch (Exception)
            {
                conn.Close();
                conn.Open();
                OracleCommand query = new OracleCommand("SELECT customer_phone FROM customer where customer_phone = '" + tbtelfon.Text + "'", conn);
                da = new OracleDataAdapter(query);
                ds = new DataSet();
                da.Fill(ds);
                conn.Close();
                if (ds.Tables[0].Rows.Count == 0)
                {
                    conn.Close();
                    conn.Open();
                    query = new OracleCommand("SELECT customer_passport FROM customer where customer_passport LIKE '%" + tbpassport.Text + "%'", conn);
                    da = new OracleDataAdapter(query);
                    ds = new DataSet();
                    da.Fill(ds);
                    conn.Close();
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        DialogResult d = MessageBox.Show("Terdapat Customer Dengan No Paspport sama,Update data customer?", "Warning", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            conn.Open();
                            OracleCommand cmdId = new OracleCommand("select customer_id from customer where customer_passport ='"+tbpassport.Text+"'",conn);
                            da = new OracleDataAdapter(cmdId);
                            ds = new DataSet();
                            da.Fill(ds);
                            OracleCommand cmd = new OracleCommand("update customer set customer_name = '" + tbnama.Text + "',customer_email = '" + tbemail.Text + "',customer_alamat ='" + tbalamat.Text + "',customer_phone = '" + tbtelfon.Text + "' where customer_id ='"+ds.Tables[0].Rows[0][0].ToString()+"'", conn);
                            try
                            {   cmd.ExecuteNonQuery();
                                DataRow dr = transTable.NewRow();
                                dr["Nama"] = tbnama.Text;
                                dr["Email"] = tbemail.Text;
                                dr["Alamat"] = tbalamat.Text;
                                dr["Telefon"] = tbtelfon.Text;
                                dr["Passport"] = tbpassport.Text;
                                transTable.Rows.Add(dr);
                                tbnama.Text = "";
                                tbemail.Text = "";
                                tbalamat.Text = "";
                                tbtelfon.Text = "";
                                tbpassport.Text = "";
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("No Telfon Kembar Silahkan Ganti !!!");
                            }

                            conn.Close();
                        }
                        else MessageBox.Show("Batal Menambahkan Customer !!!");
                    }
                }
                else if (ds.Tables[0].Rows.Count != 0)
                {
                    DialogResult d = MessageBox.Show("Terdapat Customer Dengan No telfon sama,Update data customer ?", "Warning", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        conn.Open();
                        OracleCommand cmdId = new OracleCommand("select customer_id from customer where customer_phone ='" + tbtelfon.Text + "'", conn);
                        OracleDataAdapter das = new OracleDataAdapter(cmdId);
                        DataSet dset = new DataSet();
                        das.Fill(dset);
                        OracleCommand cmd = new OracleCommand("update customer set customer_name = '" + tbnama.Text + "',customer_email = '" + tbemail.Text + "',customer_alamat ='" + tbalamat + "',custmer_passport='"+tbpassport.Text+"' where customer_id = '" + ds.Tables[0].Rows[0][0].ToString()+ "'", conn);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            DataRow dr = transTable.NewRow();
                            dr["Nama"] = tbnama.Text;
                            dr["Email"] = tbemail.Text;
                            dr["Alamat"] = tbalamat.Text;
                            dr["Telefon"] = tbtelfon.Text;
                            dr["Passport"] = tbpassport.Text;
                            transTable.Rows.Add(dr);
                            tbnama.Text = "";
                            tbemail.Text = "";
                            tbalamat.Text = "";
                            tbtelfon.Text = "";
                            tbpassport.Text = "";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("No Passport Kembar Silahkan Ganti !!!");
                        }
                        conn.Close();
                    }
                    else MessageBox.Show("Batal Menambahkan Customer !!!");
                }
            }
        }

        void update(OracleCommand cmd)
        {
         
        }

        private void tbtelfon_TextChanged(object sender, EventArgs e)
        {
         /*   OracleCommand query = new OracleCommand("SELECT customer_name,customer_email,CUSTOMER_ALAMAT,CUSTOMER_PHONE,CUSTOMER_PASSPORT FROM customer where customer_phone LIKE '%" + tbtelfon.Text+"%'", conn);
            da = new OracleDataAdapter(query);
            ds = new DataSet();
            conn.Close();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                tbnama.Text = ds.Tables[0].Rows[0][0].ToString();
                tbemail.Text = ds.Tables[0].Rows[0][1].ToString();
                tbalamat.Text = ds.Tables[0].Rows[0][2].ToString();
                NoTelefon = ds.Tables[0].Rows[0][3].ToString();
                tbpassport.Text = ds.Tables[0].Rows[0][4].ToString();
                ketemutelfon = true;
            }*/
        }

        private void tbtelfon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(ketemutelfon == true)
            {
                tbtelfon.Text = NoTelefon;
                ketemutelfon = false;
            }
        }

        private void tbpassport_MouseClick(object sender, MouseEventArgs e)
        {
/*            caritelfon = false;
            caripassport = true;*/
        }

        private void tbtelfon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= (char)(47)) || (e.KeyChar >= (char)(58)))
            {
                if (e.KeyChar == (char)Keys.Back)
                {

                }
                else
                {
                    e.KeyChar = (Char)(0);
                }
            }
            else
            {
            }
        }

        private void tbpassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= (char)(47)) || (e.KeyChar >= (char)(58)))
            {
                if (e.KeyChar == (char)Keys.Back)
                {

                }
                else
                {
                    e.KeyChar = (Char)(0);
                }
            }
            else
            {
            }
        }

        private void tbtelfon_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tbtelfon_MouseClick(object sender, MouseEventArgs e)
        {
         /*   caritelfon = true;
                caripassport = false;*/
        }

        private void tbpassport_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(KetemuPassport== true)
            {
                tbpassport.Text = NoPassport;
                KetemuPassport = false;
            }
        }

        private void tbpassport_TextChanged(object sender, EventArgs e)
        {
          /*  if (caripassport == true)
            {
                OracleCommand query = new OracleCommand("SELECT customer_name,customer_email,customer_alamat,customer_phone,customer_passport FROM customer where customer_phone  LIKE'%" + tbtelfon.Text + "%'", conn);
                da = new OracleDataAdapter(query);
                ds = new DataSet();
                conn.Close();
                da.Fill(ds);
                if (ds.Tables.Count != 0)
                {
                    tbnama.Text = ds.Tables[0].Rows[0][0].ToString();
                    tbemail.Text = ds.Tables[0].Rows[0][1].ToString();
                    tbalamat.Text = ds.Tables[0].Rows[0][2].ToString();
                    tbtelfon.Text = ds.Tables[0].Rows[0][3].ToString();
                    NoPassport = ds.Tables[0].Rows[0][4].ToString();
                    ketemutelfon = true;
                }
            }*/
        }
    }
}
