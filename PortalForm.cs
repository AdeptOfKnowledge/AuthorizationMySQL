using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        bool adminPanel;
        Point NP;

        public PortalForm()
        {
            InitializeComponent();            
        }

        private void PortalForm_Load(object sender, EventArgs e)
        {
            NickName.Text = userLogin;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT a.permissions " +
                                                    "from users u " +
                                                    "LEFT JOIN admins a on a.user_login = u.login " +
                                                    "WHERE login = @UL", db.GetConnection());

            command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = userLogin;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            string p = table.Rows[0]["permissions"].ToString();
            if (p == "") AdminPanel.Visible = false;
            if (p == "0") { AdminPanel.Visible = true; adminPanel = false; }
            if (p == "1") { AdminPanel.Visible = true; adminPanel = true; }
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
            AdminForm af = new AdminForm();
            af.admPanel = adminPanel;
            af.adminLogin = userLogin;
            af.Show();
            this.Close();
        }

        private void AuthorizationText_MouseDown(object sender, MouseEventArgs e)
        {
            NP = new Point(e.X, e.Y);
        }

        private void AuthorizationText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - NP.X;
                this.Top += e.Y - NP.Y;
            }
        }
    }
}
