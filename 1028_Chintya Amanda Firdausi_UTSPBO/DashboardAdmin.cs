using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1028_Chintya_Amanda_Firdausi_UTSPBO
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();

        }

        private void k_SelectedIndexChanged(object sender, EventArgs e)
        {
            k.Items.Add("Pupuk");
            k.Items.Add("Bakal Biji");
            k.Items.Add("Peralatan Tanam");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
