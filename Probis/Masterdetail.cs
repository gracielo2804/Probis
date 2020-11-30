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
    public partial class Masterdetail : Form
    {
        OracleConnection conn = form_login.conn;
        OracleDataAdapter da;
        DataSet ds = new DataSet();
        int max, start = 1;
        string idinput;
        public Masterdetail()
        {
            InitializeComponent();
        }

        private void gb_detail_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        public static bool pesawat = false;
        private void btn_pilih_Click(object sender, EventArgs e)
        {
            if (cmb_jenis.SelectedItem.Equals("Pesawat"))
            {
                pesawat = true;
                ListFlight l = new ListFlight();
                this.Hide();
                l.ShowDialog();
                this.Show();
            }
        }
        public static bool hotel = false;
        private void btn_pilihHotel_Click(object sender, EventArgs e)
        {
            hotel = true;
            lisHotel h = new lisHotel();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }
        void dgv()
        {
            conn.Open();
            OracleCommand cmd= new OracleCommand("SELECT dhari as Hari,ddari as Dari,ddtujuan as Tujuan,dkendaraan as Kendaraan,dhotel_nama as Hotel,tour_deskripsi as Deskripsi from dpaket where tour_id='"+idinput+"'", conn);
            da= new OracleDataAdapter(cmd);
            ds= new DataSet();
            conn.Close();
            da.Fill(ds, "paket");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "paket";
        }
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            btn_pilih.Visible = false;
            if (start == max+1)
            {
                gb_namaP.Enabled = true;
                gb_detail.Visible = false;
            }
            else if (start == 1)
            {
                conn.Close();
                conn.Open();
                string tanggal = dateTimePicker1.Value.ToString("dd MM yyyy");
                DateTime akhir = dateTimePicker1.Value.AddDays(Convert.ToInt32(nud_lama.Value));
                string tglakhir = akhir.ToString("dd MM yyyy");
                OracleCommand cmd = new OracleCommand("INSERT INTO paket_tour VALUES('" + idinput + "','" + txt_nPaket.Text+ "',1," + tb_harga.Text+ ",to_date('" + tanggal+ "','DD MM YYYY'),"+"to_date('"+akhir+"','DD MM YYYY'),"+kuota.Value+")", conn);
                cmd.ExecuteNonQuery();
                string kendaraan;
                if (cmb_jenis.SelectedItem.Equals("Bis"))
                {
                    kendaraan = "Bis";
                }
                else kendaraan = ListFlight.idpesawat;
                string hotelname = "";
                if (lisHotel.namahotel == "")
                {
                    hotelname = "Dalam Perjalanan";
                }
                else hotelname = lisHotel.namahotel;
                cmd = new OracleCommand("INSERT INTO dpaket VALUES('" + idinput + "','" +lbl_hari.Text+"','"+ dari.Text + "','"+tujuan.Text+"','" + kendaraan+ "','" + hotelname + "','"+txt_catat.Text+"')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sukes Input Data Paket");
                conn.Close();
            }
            else if(start<=max)
            {
                conn.Open();
                string kendaraan;
                if (cmb_jenis.SelectedItem.Equals("Bis"))
                {
                    kendaraan = "Bis";
                }
                else kendaraan = ListFlight.idpesawat;
                string hotelname = "";
                if (lisHotel.namahotel == "")
                {
                    hotelname = "Dalam Perjalanan";
                }
                else hotelname = lisHotel.namahotel;
                OracleCommand cmd = new OracleCommand("INSERT INTO dpaket VALUES('" + idinput + "','" + lbl_hari.Text + "','" + dari.Text + "','" + tujuan.Text + "','" + kendaraan + "','" + hotelname + "','" + txt_catat + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sukes Input Data Paket");
                conn.Close();
            }
            dgv();  
            dari.Text = "";
            tujuan.Text = "";
            txt_catat.Text = "";
            start++;
            lbl_hari.Text = start.ToString();
        }

        private void cmb_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_jenis.SelectedItem.ToString().Equals("Pesawat"))
            {
                btn_pilih.Visible = true;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (kuota.Value>1&&nud_lama.Value > 1 && tb_harga.Text != "" && txt_nPaket.Text != "")
            {
                gb_detail.Visible = true;
                gb_namaP.Enabled = false;
                lbl_hari.Text = start.ToString();
                max = Convert.ToInt32(nud_lama.Value);
                conn.Close();
                conn.Open();
                da = new OracleDataAdapter("Select tour_id as id from paket_tour", conn);

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
                int lastidangka = int.Parse(lastid.Substring(2, 4));
                int idangka = lastidangka + 1;
                idinput = "PT";
                if (idangka < 10) idinput += "000" + idangka;
                else if (idangka >= 10 && idangka < 100) idinput += "00" + idangka;
                else if (idangka >= 100 && idangka < 1000) idinput += "0" + idangka;
                else if (idangka >= 1000 && idangka < 10000) idinput += idangka;
            }
            else MessageBox.Show("Terdapat Field Kosong / Lama Tour harus lebih dari 1");
        }
    }
}
