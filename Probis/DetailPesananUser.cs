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
    public partial class DetailPesananUser : Form
    {
        public DetailPesananUser()
        {
            InitializeComponent();
        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Yakin Sesuai ?", "Warning", MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                pesananBerhasil p = new pesananBerhasil();
                this.Hide();
                p.ShowDialog();
                this.Show();
            }
        }
    }
}
