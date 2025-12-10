using System;
using System.Windows.Forms;

namespace SmartCampusDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string u = txtUser.Text.Trim();
            string p = txtPass.Text;

            if (Db.TryValidateAdmin(u, p))
            {
                DashboardForm d = new DashboardForm(u);
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login.");
            }
        }
    }
}
