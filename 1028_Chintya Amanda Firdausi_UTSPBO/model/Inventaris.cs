using System;
using Npgsql;
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
    public partial class Inventaris : Form
    {
        public Inventaris()
        {
            InitializeComponent();
        }

        public static class DatabaseHelper
        {
            public static NpgsqlConnection GetConnection()
            {
                string connString = "Host=localhost;Port=5432;Username=postgres;Password=cececomel;Database=manajemen";
                return new NpgsqlConnection(connString);
            }
        }


        private void Inventaris_Load(object sender, EventArgs e)
        {
            dataGridView1 = new DataGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
