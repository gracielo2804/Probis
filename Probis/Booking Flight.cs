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
    public partial class Booking_Flight : Form
    {
        DataTable transTable;
        public Booking_Flight()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Book_Hotel b = new Book_Hotel();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void Booking_Flight_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Yakin Membatalkan Proses Ini?", "Perhatian", MessageBoxButtons.YesNo);
            if(d== DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            DataRow tmp = transTable.NewRow();
            dgv_pesanan.Rows.Add("");
        }
    }
}
