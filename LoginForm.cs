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
    public partial class LoginForm : Form
    {
        Point NP;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void SignIn_Click(object sender, EventArgs e)
        {
            string UserLogin = Login.Text;
            string UserPass = Password.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * from users WHERE login = @UL AND pass = @UP", db.GetConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = UserLogin;
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = UserPass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) MessageBox.Show("Yes");
            else MessageBox.Show("No");
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegForm f = new RegForm();
            f.Show();
            this.Hide();
        }
    }
}
