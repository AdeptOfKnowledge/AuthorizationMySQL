using MySqlX.XDevAPI.Relational;
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
        int lastID, lastAdmID, userID, enterID, test;
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
            GBModulTest.Visible = false; tm?.Stop(); test = 0; BD_label.BorderStyle = BorderStyle.None; UserCrLabel.BorderStyle = BorderStyle.None;
            EditLabel.BorderStyle = BorderStyle.None; CascadeLabel.BorderStyle = BorderStyle.None; DelUserLabel.BorderStyle = BorderStyle.None;
            versionField.Clear(); UserField.Clear(); ChangeLoginField.Clear(); CascadeUserField.Clear(); CascadeAdminField.Clear(); DeleteField.Clear();
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

        private void StartTest_Click(object sender, EventArgs e)            //запуск СКВОЗНОГО тестирования системы
        {
            if (CrossLabel.ForeColor == Color.IndianRed)
            {
                versionField.Clear(); UserField.Clear(); ChangeLoginField.Clear(); CascadeUserField.Clear(); CascadeAdminField.Clear(); DeleteField.Clear();
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

        private void ChangeTypeButton_Click(object sender, EventArgs e)     //смена типа тестирования - сквозное/модульное
        {
            if (CrossLabel.ForeColor == Color.IndianRed)
            {
                tm?.Stop(); test = 0;
                CrossLabel.ForeColor = Color.Green; CrossLabel.Text = "Модульное"; GBModulTest.Visible = true; GB_TextSpelling.Visible = false; GB_HashTest.Visible = false; StartTestButton.Visible = false;
                FindInfoButton.Enabled = false; infoID_label.ForeColor = Color.Gray; lastUID_label.ForeColor = Color.Gray; lastAID_label.ForeColor = Color.Gray;
                IDUsrLabel.ForeColor = Color.Gray; NameUsrLabel.ForeColor = Color.Gray; SurnameUsrLabel.ForeColor = Color.Gray; StatusUsrLabel.ForeColor = Color.Gray;
            }
            else 
            { 
                CrossLabel.ForeColor = Color.IndianRed; CrossLabel.Text = "Сквозное"; TestingForm_Load(this, EventArgs.Empty); StartTestButton.Visible = true;
                Users.Items.Clear(); TB_lastUserID.Clear(); TB_lastAdmID.Clear(); TB_login.Clear(); IDField.Clear(); nameField.Clear(); surnameField.Clear(); statusField.Clear(); TB_insertID.Clear();
            }
        }

        private void IDStartButton_Click(object sender, EventArgs e)        //ПЕРВЫЙ МОДУЛЬНЫЙ ТЕСТ - корректность работы модулей ID
        {
            GB_IDtest.Visible = true; GB_TextSpelling.Visible = false; GB_HashTest.Visible = false; TB_Spelling.Clear();
            FindInfoButton.Enabled = true; infoID_label.ForeColor = Color.Black; lastUID_label.ForeColor = Color.Black; lastAID_label.ForeColor = Color.Black; FindInfoButton.ForeColor = Color.Black;
            IDUsrLabel.ForeColor = Color.Black; NameUsrLabel.ForeColor = Color.Black; SurnameUsrLabel.ForeColor = Color.Black; StatusUsrLabel.ForeColor = Color.Black;
            Users.Items.Clear(); TB_lastUserID.Clear(); TB_lastAdmID.Clear(); TB_login.Clear(); IDField.Clear(); nameField.Clear(); surnameField.Clear(); statusField.Clear(); TB_insertID.Clear();
            CheckLastUserID(); TB_lastUserID.Text = lastID.ToString();
            CheckLastAdminID(); TB_lastAdmID.Text = lastAdmID.ToString();
            UsersList();
        }

        private void FindInfoButton_Click(object sender, EventArgs e)
        {            
            if (TB_insertID.Text != null && TB_insertID.Text != "" && TB_insertID.Text != "0" && Convert.ToInt32(TB_insertID.Text) <= lastID)
            {
                enterID = Int32.Parse(TB_insertID.Text);
                DataBase db = new DataBase();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT login from users WHERE id = @ID", db.GetConnection());

                command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = enterID;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                
                TB_login.ForeColor = Color.Blue;                
                TB_login.Text = table.Rows[0]["login"].ToString();
            }
            else { TB_login.ForeColor = Color.Red; TB_login.Text = "Пользователя нет!"; }
        }

        private void TB_insertID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))  // Запрещаем ввод символов, отличных от цифр (0-9)
            {
                e.Handled = true;
            }
        }

        private void UsersList()
        {
            DataBase db = new DataBase();
            SqlCommand command = new SqlCommand("SELECT login from users", db.GetConnection());

            db.OpenConnection();                                //Открываем соединение
            SqlDataReader read = command.ExecuteReader();       //Считываем и извлекаем данные
            while (read.Read())                                 //Читаем пока есть данные
            {
                Users.Items.Add(read.GetValue(0).ToString());   //Добавляем данные в лист аитем
            }
            db.CloseConnection();                               //Закрываем соединение             
        }

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Users.SelectedItem != null)
            {
                DataBase db = new DataBase();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("SELECT u.id as id, u.name name, u.surname surname, a.permissions adm " +
                                                    "from users u " +
                                                    "LEFT JOIN admins a on a.user_login = u.login " +
                                                    "where u.login = @UL ", db.GetConnection());

                command.Parameters.Add("@UL", SqlDbType.NVarChar).Value = Users.SelectedItem.ToString();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                IDField.Text = table.Rows[0]["id"].ToString();
                nameField.Text = table.Rows[0]["name"].ToString();
                surnameField.Text = table.Rows[0]["surname"].ToString();
                statusField.Text = table.Rows[0]["adm"].ToString();

                StatusInfo();
            }
        }

        private void StatusInfo()
        {
            if (statusField.Text == "") { statusField.Text = "user"; statusField.ForeColor = Color.Green; }
            if (statusField.Text == "0") { statusField.Text = "admin"; statusField.ForeColor = Color.Blue; }
            if (statusField.Text == "1") { statusField.Text = "superadmin"; statusField.ForeColor = Color.DarkOrchid; }
        }

        private void SpellingStartButton_Click(object sender, EventArgs e)          //ВТОРОЙ МОДУЛЬНЫЙ ТЕСТ - корректность работы модулей ввода разрешенных символов
        {
            GB_TextSpelling.Visible = true; GB_HashTest.Visible = false; TB_Spelling.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TB_Spelling.Clear(); TB_Spelling.Select();
        }

        private void TB_Spelling_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) && TB_Spelling.Text.Length == 0)         // блок пробела, если введен первым символом
            {
                e.Handled = true;
                return;
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar)) // Запрещаем ввод символов,
            {                                                                                                                         // отличных от букв, цифр,
                e.Handled = true;                                                                                                     // управляющих символов, пробелов
            }

            TB_Spelling.Text = TB_Spelling.Text.TrimStart(new Char[] { ' ' });   // удаление пробела, если стоит перед словом            
        }

        private void TB_Spelling_KeyUp(object sender, KeyEventArgs e)            // разрешает добавление нижнего подчеркивания
        {
            if (ModifierKeys == Keys.Shift)         //проверка нажатой кнопки;
            {
                if (e.KeyCode == Keys.OemMinus)     //проверка нажатой кнопки;
                {
                    {
                        TB_Spelling.SelectedText = "_";
                    }
                }
            }

            TB_Spelling.Text = TB_Spelling.Text.TrimStart(new Char[] { ' ' });   // удаление пробела, если стоит перед словом
            if (TB_Spelling.Text.Contains("  "))                                 // удаление двойных пробелов
            {
                int a = 0;
                for (int i = 0; i < TB_Spelling.TextLength; i++)
                {
                    if (a == 0) a = TB_Spelling.Text.IndexOf("  ", 0) + 1;
                    TB_Spelling.Text = TB_Spelling.Text.Replace("  ", " ");      // заменяет два пробела - одним
                    TB_Spelling.SelectionStart = a;                              // установка курсора в конце замененных пробелов
                }
            }

            if (TB_Spelling.Text.Contains("__"))                                 // удаление двойных подчеркиваний
            {
                int a = 0;
                for (int i = 0; i < TB_Spelling.TextLength; i++)
                {
                    if (a == 0) a = TB_Spelling.Text.IndexOf("__", 0) + 1;
                    TB_Spelling.Text = TB_Spelling.Text.Replace("__", "_");      // заменяет два подчеркивания - одним
                    TB_Spelling.SelectionStart = a;                              // установка курсора в конце замененных подчеркиваний
                }
            }

            if (TB_Spelling.Text.Contains("_ "))                                 // удаление подчеркивания с пробелом
            {
                int a = 0;
                for (int i = 0; i < TB_Spelling.TextLength; i++)
                {
                    if (a == 0) a = TB_Spelling.Text.IndexOf("_ ", 0) + 1;
                    TB_Spelling.Text = TB_Spelling.Text.Replace("_ ", "_");      // заменяет на подчеркивание
                    TB_Spelling.SelectionStart = a;                              // установка курсора в конце замененных символов
                }
            }

            if (TB_Spelling.Text.Contains(" _"))                                 // удаление пробела с подчеркиванием
            {
                int a = 0;
                for (int i = 0; i < TB_Spelling.TextLength; i++)
                {
                    if (a == 0) a = TB_Spelling.Text.IndexOf(" _", 0) + 1;
                    TB_Spelling.Text = TB_Spelling.Text.Replace(" _", "_");      // заменяет на подчеркивание
                    TB_Spelling.SelectionStart = a;                              // установка курсора в конце замененных символов
                }
            }
        }

        private void HashStartButton_Click(object sender, EventArgs e)          //ТРЕТИЙ МОДУЛЬНЫЙ ТЕСТ - корректность работы модуля хэш-функции
        {
            GB_TextSpelling.Visible = true; GB_HashTest.Visible = true; TB_InsertPass.Clear(); TB_HashOutput.Clear();
        }

        private void ConvertToHash_Click(object sender, EventArgs e)
        {
            TB_InsertPass.Text = TB_InsertPass.Text.TrimEnd(new Char[] { ' ' });        // удаление пробела, если стоит после текста
            if (TB_InsertPass.Text != "")
                TB_HashOutput.Text = PassHash.PWhash(TB_InsertPass.Text);
            else TB_HashOutput.Clear();
        }

        private void TB_InsertPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))                                  // блок пробела, если введен первым символом
            {
                e.Handled = true;
                return;
            }
        }
    }    
}
