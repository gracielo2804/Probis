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
    public partial class PilihLaporan : Form
    {
        public PilihLaporan()
        {
            InitializeComponent();
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            laporanPalingBanyakDikunjungi laporanPalingBanyakDikunjungi = new laporanPalingBanyakDikunjungi();
            this.Hide();
            laporanPalingBanyakDikunjungi.ShowDialog();
            this.Show();
        }

        private void btnLapPenjualan_Click(object sender, EventArgs e)
        {
            LaporanPenjualan laporanPenjualan = new LaporanPenjualan();
            this.Hide();
            laporanPenjualan.ShowDialog();
            this.Show();
        }

        private void btn_hotel_Click(object sender, EventArgs e)
        {
            FormlaporanKegiatan formlaporanKegiatan = new FormlaporanKegiatan();
            this.Hide();
            formlaporanKegiatan.ShowDialog();
            this.Show();
        }
    }
}
