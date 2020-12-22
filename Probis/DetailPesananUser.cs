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
        int HargaJumlah, biaya, total;
        string idinput,pesawat = "FL0001", hotel = "HT0001";
        public DetailPesananUser()
        {
            InitializeComponent();
            loadnota();
            txt_notrans.Text = idinput;
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
             HargaJumlah = dgv_detail.Rows.Count-1;
             biaya = Convert.ToInt32(detailHarga.tax) + Home.harga+75000+954000;
             total = HargaJumlah * biaya;
            lbl_harga.Text ="Rp "+total.ToString("#,##0");
            
        }

        void loadnota()
        {
            conn.Close();
            conn.Open();
            da = new OracleDataAdapter("Select ID_ORDER as id from htrans", conn);
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
            int lastidangka = 0;
            if (ds.Tables[0].Rows.Count != 0)
            {
                lastidangka = int.Parse(lastid.Substring(2, 4));
            }
            int idangka = lastidangka + 1;
            idinput = "TN";
            if (idangka < 10) idinput += "000" + idangka;
            else if (idangka >= 10 && idangka < 100) idinput += "00" + idangka;
            else if (idangka >= 100 && idangka < 1000) idinput += "0" + idangka;
            else if (idangka >= 1000 && idangka < 10000) idinput += idangka;
        }
        private void btn_bayar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Yakin Sesuai ?", "Warning", MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {           
                conn.Close();
                conn.Open();
                OracleCommand cmd = new OracleCommand("INSERT INTO htrans VALUES('" + idinput + "','" + form_login.idpeg + "', to_date('" + DateTime.Now.ToString("dd MM yyyy") + "', 'dd MM yyyy'), " + total.ToString() + ")", conn);
                cmd.ExecuteNonQuery();
                for (int i = 0; i < dgv_detail.Rows.Count; i++)
                {
                    cmd = new OracleCommand("select customer_id from customer where customer_phone = "+dgv_detail.Rows[i].Cells[3].Value.ToString(),conn);
                    da = new OracleDataAdapter(cmd);
                    ds= new DataSet();
                    da.Fill(ds);
                    OracleCommand cmdin = new OracleCommand("insert into dtrans values('"+idinput+"','"+ds.Tables[0].Rows[0][0].ToString()+"','"+pesawat+"','"+hotel+"','"+Home.id.ToString()+"',"+biaya.ToString()+")", conn);
                    //MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
                    //MessageBox.Show(idinput);
                    //MessageBox.Show(pesawat);
                    //MessageBox.Show(Home.id.ToString());
                    cmdin.ExecuteNonQuery();
                    
                }
                conn.Close();
                pesananBerhasil p = new pesananBerhasil();
                this.Hide();
                p.ShowDialog();
                this.Show();
            }

        }
    }
}
