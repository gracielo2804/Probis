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
    public partial class pesananBerhasil : Form
    {
        public pesananBerhasil()
        {
            InitializeComponent();
        }

        private void pesananBerhasil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }
    }
}
