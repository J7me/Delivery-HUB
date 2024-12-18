﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DeliveryHUB
{
    public partial class LoginForm : MaterialForm

    {
        public LoginForm()
        {
            InitializeComponent();
            lbMessError.Visible = false; 
            var materialSkinManager = MaterialSkinManager.Instance;
           materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightGreen200, TextShade.WHITE);

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            BD db = new BD();

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            lbMessError.Visible = false;

            if (!IsValidLogin(username))
            {
                ShowErrorMessage("Логин должен быть на латинице\n и быть длиной не менее 5 символов.");
                return;
            }

            if (!IsValidPassword(password))
            {
                ShowErrorMessage("Пароль должен содержать только латинские\n символы, быть длиной не менее 8 символов.");
                return;
            }

            db.openConnection();

            try
            {
                string queryAdmin = "SELECT COUNT(1) FROM Administrators WHERE Login = @username AND Password = @password";
                using (SqlCommand commandAdmin = new SqlCommand(queryAdmin, db.GetSqlConnection()))
                {
                    commandAdmin.Parameters.AddWithValue("@username", username);
                    commandAdmin.Parameters.AddWithValue("@password", password);

                    int adminCount = Convert.ToInt32(commandAdmin.ExecuteScalar());
                    if (adminCount == 1)
                    {
                        MessageBox.Show("Вы успешно вошли как администратор!", "Авторизация");

                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                        return;
                    }
                }

                string queryCustomer = "SELECT CustomerID FROM Customers WHERE Login = @username AND Password = @password";
                using (SqlCommand commandCustomer = new SqlCommand(queryCustomer, db.GetSqlConnection()))
                {
                    commandCustomer.Parameters.AddWithValue("@username", username);
                    commandCustomer.Parameters.AddWithValue("@password", password);

                    object customerIdObj = commandCustomer.ExecuteScalar();
                    if (customerIdObj != null)
                    {
                        int customerId = Convert.ToInt32(customerIdObj); 
                        MessageBox.Show("Вы успешно вошли как клиент!", "Авторизация");

                        UserForm ordersForm = new UserForm(customerId); 
                        ordersForm.Show();
                        this.Hide();
                        return;
                    }
                }


                ShowErrorMessage("Неверные имя пользователя или пароль.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Ошибка подключения к базе данных: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private bool IsValidLogin(string login)
        {
            return login.Length >= 5 && Regex.IsMatch(login, @"^[a-zA-Z0-9]+$");
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 && Regex.IsMatch(password, @"^[a-zA-Z0-9]+$");
        }

        private void ShowErrorMessage(string message)
        {
            lbMessError.Text = message;
            lbMessError.ForeColor = System.Drawing.Color.Red;
            lbMessError.Visible = true;
        }


       

    }
}
