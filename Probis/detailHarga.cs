using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probis
{
    public partial class detailHarga : Form
    {
        public static double tax;
        public detailHarga()
        {
            InitializeComponent();
        }

        private void detailHarga_Load(object sender, EventArgs e)
        {
            lbl_harga.Text = Home.harga.ToString("###,###");
            tax = Convert.ToDouble(Home.harga) * 0.1;
            lbl_tax.Text = tax.ToString("###,###");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_pesan_Click(object sender, EventArgs e)
        {
            Booking_Flight d = new Booking_Flight();
            this.Hide();
            d.ShowDialog();
            this.Hide();
        }
    }
}
