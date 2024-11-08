using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1028_Chintya_Amanda_Firdausi_UTSPBO.model
{
    public partial class HalamanLogin : Form
    {
        public HalamanLogin()
        {
            InitializeComponent();
        }

        private void u_TextChanged(object sender, EventArgs e)
        {
        }

        private void selesai_Click(object sender, EventArgs e)
        {
            DashboardAdmin dashboardAdmin = new DashboardAdmin();
            dashboardAdmin.Show();
            this.Hide();
        }
    }
}
