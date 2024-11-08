using _1028_Chintya_Amanda_Firdausi_UTSPBO.model;

namespace _1028_Chintya_Amanda_Firdausi_UTSPBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sp.Items.Add("Halaman Inventaris");
            sp.Items.Add("Halaman Pendaftaran Pengguna");
            sp.Items.Add("Halaman Login");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sp.Text == "Halaman Inventaris")
            {
                Inventaris daftarBarangInventaris = new Inventaris();
                daftarBarangInventaris.Show();
                this.Hide();
            }
            else if (sp.Text == "Halaman Login")
            {
                    HalamanLogin login = new HalamanLogin();
                    login.Show();
                    this.Hide();
                
            }
            else if (sp.Text == "Halaman Pendaftaran Pengguna")
            {
                pendaftaranpengguna daftar = new pendaftaranpengguna();
                daftar.Show();
                this.Hide();

            }
        }
    }
}
