using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class TestingForm : Form
    {
        Point NP; Timer tm;
        int lastID, lastAdmID, userID, test = 0;
        string login, version;        

        public TestingForm()
        {
            InitializeComponent();            
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {
            OK_BD_Test.Visible = false; Failed_BD_test.Visible = false; TickBD.Visible = false; BDconnection.Value = 0;
            OkUserTest.Visible = false; FailedUserTest.Visible = false; TickUserCreation.Visible = false; PB_UserCr.Value = 0;
            OkEditTest.Visible = false; FailedEditTest.Visible = false; TickEditUser.Visible = false; PBEditUser.Value = 0;
            OkCascadeTest.Visible = false; FailedCascadeTest.Visible = false; TickCascade.Visible = false; PBCascade.Value = 0;
            OkDelUserTest.Visible = false; FailedDelUserTest.Visible = false; TickDelUser.Visible = false; PBDelUser.Value = 0; 
            GBModulTest.Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            BDconnection.Value = 0;
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void TestingText_MouseDown(object sender, MouseEventArgs e)
        {
            NP = new Point(e.X, e.Y);
        }

        private void TestingText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - NP.X;
                this.Top += e.Y - NP.Y;
            }
        }
        private void DBversion()
        {            
            DataBase db = new DataBase();
            SqlCommand command = new SqlCommand("SELECT @@version", db.GetConnection());

            db.OpenConnection(); //Открываем соединение
            SqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                version = (read.GetString(0).ToString()); //Добавляем данные в лист аитем
            }

            if (version.Contains(") - "))                                 // удаление двойных пробелов
            {
                int a = 0;
                for (int i = 0; i < version.Length; i++)
                {
                    if (a == 0) a = version.IndexOf(") - ", 0) + 4;                    
                }
                version = version.Remove(0, a);

                if (version.Contains("(X64)"))
                {
                    a = 0;
                    for (int i = 0; i < version.Length; i++)
                    {
                        if (a == 0) a = version.IndexOf("(X64)", 0) + 5;
                        version = version.Remove(a, version.Length - a);
                    }
                }
            }
        }

        private void CheckUserID()
        {
                DataBase db = new DataBase();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT id from users WHERE login = @UL", db.GetConnection());

                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = login;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                userID = Convert.ToInt32(table.Rows[0]["id"].ToString());
        }

        private int CheckLastUserID()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT id from users " +
                                               "ORDER BY id DESC", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            lastID = Convert.ToInt32(table.Rows[0]["id"].ToString());
            return lastID;
        }

        private int CheckLastAdminID()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT id from admins " +
                                               "ORDER BY id DESC", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            lastAdmID = Convert.ToInt32(table.Rows[0]["id"].ToString());
            return lastAdmID;
        }

        private void testBDconnection()
        {
            if (!Failed_BD_test.Visible && !Failed_BD_test.Visible)
            {
                BDconnection.Step = 1; BDconnection.Value = 0;                

                for (int i = 1; i < 25; i++) BDconnection.Value = i;
                DataBase db = new DataBase();
                for (int i = 25; i < 50; i++) BDconnection.Value = i;

                try
                {
                    db.OpenConnection();
                    for (int i = 50; i < 75; i++) BDconnection.Value = i;
                    db.CloseConnection();
                    for (int i = 75; i < 101; i++) BDconnection.Value = i;
                }
                catch
                {
                    tm?.Stop(); return;
                }
                finally
                {
                    if (BDconnection.Value == 100)
                    {
                        tm = new Timer();
                        tm.Interval = 1500;
                        tm.Start();
                        tm.Tick += MainTimer_Tick;
                        DBversion();
                    }
                    else { Failed_BD_test.Visible = true; test = 0; StartTestButton.Enabled = true; ChangeTypeButton.Enabled = true; }
                }                
            }
        }

        private void testUserCreation()
        {
            PB_UserCr.Step = 1; PB_UserCr.Value = 0;            

            for (int i = 1; i < 25; i++) PB_UserCr.Value = i;
                        
            login = "TestAccount";

            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                int value = rand.Next(0, 9);
                login = login + value;
            }

            try
            {
                CheckLastUserID();
                
                DataBase db = new DataBase();
                for (int i = 25; i < 50; i++) PB_UserCr.Value = i;

                SqlCommand command = new SqlCommand("INSERT INTO users (id, name, surname, login, pass) VALUES (@id, @name, @surname, @login, @pass)", db.GetConnection());
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = lastID + 1;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = "TestName";
                command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = "TestSurname";
                command.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
                command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = PassHash.PWhash("123");            

                db.OpenConnection();

                for (int i = 50; i < 75; i++) PB_UserCr.Value = i;
                if (command.ExecuteNonQuery() != 1) { tm?.Stop(); return; }

                db.CloseConnection();
                for (int i = 75; i < 101; i++) PB_UserCr.Value = i;                
            }
            catch
            {
                PB_UserCr.Value = 0; tm?.Stop(); return;
            }
            finally
            {
                if (PB_UserCr.Value != 100)
                { 
                    FailedUserTest.Visible = true; test = 0; StartTestButton.Enabled = true; ChangeTypeButton.Enabled = true;
                }
            }
        }

        private void editUser()
        {
            for (int i = 1; i < 25; i++) PBEditUser.Value = i;

            PBEditUser.Step = 1; PBEditUser.Value = 0;
            string newLogin;

            newLogin = "ChangedLogin";

            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                int value = rand.Next(0, 9);
                newLogin = newLogin + value;
            }

            try
            {
                for (int i = 25; i < 50; i++) PBEditUser.Value = i;

                DataBase db = new DataBase();     
                SqlCommand command = new SqlCommand();

                command = new SqlCommand("UPDATE users SET login = @NuL WHERE login = @UL", db.GetConnection());

                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = login;
                command.Parameters.Add("@NuL", SqlDbType.NVarChar).Value = newLogin;

                db.OpenConnection();
                command.ExecuteReader();
                db.CloseConnection(); //Закрываем соединение 

                for (int i = 50; i < 75; i++) PBEditUser.Value = i;

                login = newLogin;

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                command = new SqlCommand("SELECT * from users WHERE login = @UL", db.GetConnection());
                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = login;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    for (int i = 75; i < 101; i++) PBEditUser.Value = i;
                }
                else return;
            }
            catch
            {
                PBEditUser.Value = 0; tm?.Stop(); return;
            }
            finally
            {
                if (PBEditUser.Value != 100)
                {
                    FailedEditTest.Visible = true; test = 0; StartTestButton.Enabled = true; ChangeTypeButton.Enabled = true;
                }
            }
        }

        private void Cascade()
        {
            for (int i = 1; i < 25; i++) PBCascade.Value = i;

            PBCascade.Step = 1; PBCascade.Value = 0;
            string cascadeLogin;

            cascadeLogin = "TestedCascade";
             
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                int value = rand.Next(0, 9);
                cascadeLogin = cascadeLogin + value;
            }

            try
            {
                for (int i = 25; i < 50; i++) PBCascade.Value = i;

                CheckUserID(); CheckLastAdminID();
                
                DataBase db = new DataBase();
                SqlCommand command = new SqlCommand("INSERT INTO admins (id, user_id, user_login, permissions)" +
                                                        "VALUES (@id, @uID, @UL, 0) ", db.GetConnection());

                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = lastAdmID + 1;
                command.Parameters.Add("@uID", SqlDbType.NVarChar).Value = userID;
                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = login;

                db.OpenConnection();
                command.ExecuteReader();
                db.CloseConnection(); 

                CascadeUserField.Text = cascadeLogin;

                for (int i = 50; i < 75; i++) PBCascade.Value = i;

                command = new SqlCommand("UPDATE users SET login = @NuL WHERE login = @UL", db.GetConnection());

                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = login;
                command.Parameters.Add("@NuL", SqlDbType.NVarChar).Value = cascadeLogin;

                db.OpenConnection();
                command.ExecuteReader();
                db.CloseConnection();           

                login = cascadeLogin;

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                command = new SqlCommand("SELECT u.login as login from users u, admins a WHERE u.login = a.user_login and a.user_login = @UL", db.GetConnection());
                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = login;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (login == table.Rows[0]["login"].ToString())
                {                    
                    for (int i = 75; i < 101; i++) PBCascade.Value = i;
                }
                else return;

            }
            catch
            {
                PBCascade.Value = 0; tm?.Stop(); return;
            }
            finally
            {
                if (PBCascade.Value != 100)
                {
                    FailedCascadeTest.Visible = true; test = 0; StartTestButton.Enabled = true; ChangeTypeButton.Enabled = true;
                }
            }
        }

        private void removeUser()
        {
            for (int i = 1; i < 25; i++) PBDelUser.Value = i;

            PBDelUser.Step = 1; PBDelUser.Value = 0;

            try
            {
                for (int i = 25; i < 50; i++) PBDelUser.Value = i;

                DataBase db = new DataBase();
                SqlCommand command = new SqlCommand("DELETE FROM users WHERE login = @UL", db.GetConnection());
                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = login;

                db.OpenConnection();
                command.ExecuteReader();
                db.CloseConnection(); 

                for (int i = 50; i < 75; i++) PBDelUser.Value = i;

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                command = new SqlCommand("SELECT * from users WHERE login = @UL", db.GetConnection());
                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = login;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return; ;
                }
                else for (int i = 75; i < 101; i++) PBDelUser.Value = i;
            }
            catch
            {
                PBDelUser.Value = 0; tm?.Stop(); return;
            }
            finally
            {
                if (PBDelUser.Value != 100)
                {
                    FailedDelUserTest.Visible = true; test = 0; StartTestButton.Enabled = true; ChangeTypeButton.Enabled = true;
                }
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            test++;
            if (test == 1)
            {
                BD_label.BorderStyle = BorderStyle.Fixed3D; versionField.Text = version;
                OK_BD_Test.Visible = true; TickBD.Visible = true;
            }

            if (test == 2) testUserCreation();

            if (test == 3)
            {
                UserCrLabel.BorderStyle = BorderStyle.Fixed3D; UserField.Text = login;
                OkUserTest.Visible = true; TickUserCreation.Visible = true;                
            }

            if (test == 4) editUser();

            if (test == 5)
            {
                EditLabel.BorderStyle = BorderStyle.Fixed3D; ChangeLoginField.Text = login;
                OkEditTest.Visible = true; TickEditUser.Visible = true;                
            }

            if (test == 6) Cascade();

            if (test == 7)
            {
                CascadeLabel.BorderStyle = BorderStyle.Fixed3D; CascadeAdminField.Text = login;
                OkCascadeTest.Visible = true; TickCascade.Visible = true;                
            }

            if (test == 8) removeUser();

            if (test == 9)
            {
                DelUserLabel.BorderStyle = BorderStyle.Fixed3D; DeleteField.Text = "УЗ удалена!";
                OkDelUserTest.Visible = true; TickDelUser.Visible = true;
                StartTestButton.Enabled = true; ChangeTypeButton.Enabled = true;
            }

            if (Failed_BD_test.Visible || FailedUserTest.Visible)
            {
                tm?.Stop(); test = 0; StartTestButton.Enabled = true; ChangeTypeButton.Enabled = true;
            }
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            if (CrossLabel.ForeColor == Color.IndianRed)
            {
                StartTestButton.Enabled = false; ChangeTypeButton.Enabled = false;

                if (OK_BD_Test.Visible || Failed_BD_test.Visible || OkUserTest.Visible || FailedUserTest.Visible || OkEditTest.Visible || FailedEditTest.Visible ||
                    OkCascadeTest.Visible || FailedCascadeTest.Visible || OkDelUserTest.Visible || FailedDelUserTest.Visible)
                {
                    BD_label.BorderStyle = BorderStyle.None; BDconnection.Value = 0;
                    OK_BD_Test.Visible = false; Failed_BD_test.Visible = false; TickBD.Visible = false;
                    UserCrLabel.BorderStyle = BorderStyle.None; PB_UserCr.Value = 0;
                    OkUserTest.Visible = false; FailedUserTest.Visible = false; TickUserCreation.Visible = false;
                    EditLabel.BorderStyle = BorderStyle.None; PBEditUser.Value = 0;
                    OkEditTest.Visible = false; FailedEditTest.Visible = false; TickEditUser.Visible = false;
                    CascadeLabel.BorderStyle = BorderStyle.None; PBEditUser.Value = 0; PBCascade.Value = 0;
                    OkCascadeTest.Visible = false; FailedCascadeTest.Visible = false; TickCascade.Visible = false;
                    DelUserLabel.BorderStyle = BorderStyle.None; PBDelUser.Value = 0;
                    OkDelUserTest.Visible = false; FailedDelUserTest.Visible = false; TickDelUser.Visible = false;
                    tm?.Stop(); test = 0;
                }
                testBDconnection();
            }
        }

        private void ChangeTypeButton_Click(object sender, EventArgs e)
        {
            if (CrossLabel.ForeColor == Color.IndianRed)
            { CrossLabel.ForeColor = Color.Green; CrossLabel.Text = "Модульное"; GBModulTest.Visible = true; StartTestButton.Visible = false; }
            else { CrossLabel.ForeColor = Color.IndianRed; CrossLabel.Text = "Сквозное"; GBModulTest.Visible = false; StartTestButton.Visible = true; }
        }
    }
}
