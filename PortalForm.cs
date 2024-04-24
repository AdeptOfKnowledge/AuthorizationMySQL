using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class PortalForm : Form
    {
        public string userLogin;

        public PortalForm()
        {
            InitializeComponent();            
        }

        private void PortalForm_Load(object sender, EventArgs e)
        {
            NickName.Text = userLogin;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void AdminPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm();
            af.adminLogin = userLogin;
            af.Show();
        }
    }
}
