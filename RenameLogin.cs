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
    public partial class RenameLogin : Form
    {
        public string UN; 
        Point NP;

        public RenameLogin()
        {
            InitializeComponent();
        }

        private void RenameLogin_Load(object sender, EventArgs e)
        {
            loginField.Text = UN;
            NewLogin.ForeColor = Color.Gray; NewLogin.Text = "Введите новый логин";            
        }
        private void NewLogin_Enter(object sender, EventArgs e)
        {
            if (NewLogin.Text == "Введите новый логин") { NewLogin.Text = ""; NewLogin.ForeColor = Color.Black; }
        }
        private void NewLogin_Leave(object sender, EventArgs e)
        {
            if (NewLogin.Text == "") { NewLogin.Text = "Введите новый логин"; NewLogin.ForeColor = Color.Gray; }
        }
        private void NewLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) // Запрещаем ввод символов, отличных от букв, цифр и управляющих символов
            {
                e.Handled = true;
            }
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

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (NewLogin.Text != "" && NewLogin.Text != "Введите новый логин")
            {
                DialogResult = DialogResult.OK;
                UN = NewLogin.Text;
            }
            else return;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
