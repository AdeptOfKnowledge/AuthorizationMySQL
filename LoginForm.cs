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
        Point NP; bool Eye = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //DataBase db = new DataBase();
            //db.CheckConnection();
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
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * from users WHERE login = @UL AND pass = @UP", db.GetConnection());
            command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = Login.Text;
            command.Parameters.Add("@UP", SqlDbType.NVarChar).Value = PassHash.PWhash(Password.Text);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                PortalForm portal = new PortalForm();
                portal.userLogin = Login.Text;
                portal.Show();
                this.Hide();
            }

            else MessageBox.Show("Имя пользователя или пароль не совпадают");
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegForm f = new RegForm();
            f.Show();
            this.Hide();
        }

        private void PassShow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Password.UseSystemPasswordChar == true) { Password.UseSystemPasswordChar = false; Eye = true; }
                if (Eye == false) Password.UseSystemPasswordChar = true;
                Eye = false;
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) // Запрещаем ввод символов, отличных от букв, цифр и управляющих символов
            {
                e.Handled = true;
            }
        }

        private void Tests_button_Click(object sender, EventArgs e)
        {
            TestingForm tf = new TestingForm();
            tf.Show();
            this.Hide();
        }
    }
}
