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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }
        OracleConnection conn = form_login.conn;

        private void btnUser_Click(object sender, EventArgs e)
        {
            masterUser masterUser = new masterUser();
            this.Hide();
            masterUser.ShowDialog();
            this.Show();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            lbl_user.Text = "Admin";
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tour_Click(object sender, EventArgs e)
        {
            listPakettour m = new listPakettour();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void btn_hotel_Click(object sender, EventArgs e)
        {
            lisHotel lisHotel = new lisHotel();
            this.Hide();
            lisHotel.ShowDialog();
            this.Show();
        }

        private void btn_flight_Click(object sender, EventArgs e)
        {
            ListFlight listFlight = new ListFlight();
            this.Hide();
            listFlight.ShowDialog();
            this.Show();
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            PilihLaporan pilihLaporan = new PilihLaporan();
            this.Hide();
            pilihLaporan.ShowDialog();
            this.Show();
        }
    }
}
