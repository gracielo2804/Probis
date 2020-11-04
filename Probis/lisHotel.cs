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
    public partial class lisHotel : Form
    {
        public lisHotel()
        {
            InitializeComponent();

        }
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds;  OracleDataAdapter da1;
        DataSet ds1;
        DataTable dt = new DataTable();
        string idhotel = "";
        int indexdgvhotel = -1;


        private void lisHotel_Load(object sender, EventArgs e)
        {
            conn.Open();

            da = new OracleDataAdapter("Select h.hotel_id as id,h.hotel_name as nama,h.hotel_kota as kota,h.hotel_negara as negara,count(d.hotel_id) as jumlah_jenis from hotel h,dhotel d where h.hotel_id=d.hotel_id group by h.hotel_id,h.hotel_name, h.hotel_kota,h.hotel_negara", conn);
            ds = new DataSet();
            da.Fill(ds);
            da = new OracleDataAdapter("Select * from hotel",conn);
            DataSet dstemp = new DataSet();
            da.Fill(dstemp);
            foreach (DataRow rows in dstemp.Tables[0].Rows)
            {
                Boolean cekhotel = true;
                foreach (DataRow row in ds.Tables[0].Rows) 
                {
                    //MessageBox.Show(row["id"].ToString() +" - "+ rows["HOTEL_ID"].ToString());
                    if (row["id"].ToString() == rows["HOTEL_ID"].ToString()) 
                    {
                        cekhotel = false;
                    }
                    //MessageBox.Show(cekhotel.ToString());
                }
                if (cekhotel) 
                {
                    DataRow newrow = ds.Tables[0].NewRow();
                    newrow["id"] = rows["HOTEL_ID"];
                    newrow["nama"] = rows["HOTEL_NAME"];
                    newrow["kota"] = rows["HOTEL_KOTA"];
                    newrow["negara"] = rows["HOTEL_NEGARA"];
                    newrow["jumlah_jenis"] = 0;

                    ds.Tables[0].Rows.Add(newrow);
                }
            }
            
            dgv_listHotel.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_baru_Click(object sender, EventArgs e)
        {
            addHotel add = new addHotel();
            add.ShowDialog();
            this.Show();
            lisHotel_Load(sender, e);
        }

        private void dgv_listHotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) {
                indexdgvhotel = e.RowIndex;
                string id = dgv_listHotel.Rows[e.RowIndex].Cells[0].Value.ToString();
                da1 = new OracleDataAdapter("select CONCAT(KAPASITAS,' Orang')as Kapasitas,JENIS_KAMAR AS \"Jenis Kamar\",Hotel_harga As Harga,breakfast,Keterangan as Keterangan from dhotel where Hotel_id='"+id+"'", conn);
                ds1 = new DataSet();
                da1.Fill(ds1);
                foreach (DataTable dt in ds1.Tables) {
                    foreach (DataRow rows in dt.Rows) {
                        if (rows["BREAKFAST"].ToString() == "0")
                        {
                            rows["BREAKFAST"] = "Tidak Tersedia";
                        }
                        else rows["BREAKFAST"] = "Tersedia";
                    }
                }
                dgv_detailHotel.DataSource = ds1.Tables[0];
                idhotel = dgv_listHotel.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            
            else
            {
                dgv_detailHotel.DataSource = null;
                idhotel = "";

            }

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            dgv_detailHotel.DataSource = null;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if ( idhotel == "")
            {
                MessageBox.Show("Harap Pilih Hotel Terlebih dahulu");
            }
            else {
                add_dhotel adhotel = new add_dhotel();
                adhotel.idhotel = this.idhotel;
                this.Hide();
                adhotel.ShowDialog();
                this.Show();
                lisHotel_Load(sender, e);

            }
        }
        public static string namahotel="";
        private void dgv_detailHotel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Masterdetail.hotel == true)
            {
                if (e.RowIndex > -1)
                {
                    namahotel = dgv_listHotel.Rows[e.RowIndex].Cells[1].Value.ToString();
                    MessageBox.Show("Hotel Berhasil Terpilih");
                }
            }
        }
    }
}
