using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DeliveryHUB
{
    public partial class RegisterForm : MaterialForm
    {
        private BD db = new BD();

        public RegisterForm()
        {
            InitializeComponent();
            lbMessError.Visible = false; 
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightGreen200, TextShade.WHITE);

        }

        private bool IsLatin(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9@._]+$");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            lbMessError.Visible = false;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Пожалуйста, заполните все поля.");
                return;
            }

            if (!IsValidLogin(login))
            {
                ShowErrorMessage("Логин должен быть на латинице, содержать хотя бы\n одну цифру и быть длиной не менее 5 символов.");
                return;
            }

            if (!IsLatin(email))
            {
                ShowErrorMessage("Email должен содержать только латинские буквы,\n цифры и допустимые символы (@, ., _).");
                return;
            }

            if (!IsValidPassword(password))
            {
                ShowErrorMessage("Пароль должен содержать только латинские\n символы, быть длиной не менее 8 символов.");
                return;
            }

            if (!IsValidPhone(phone))
            {
                ShowErrorMessage("Введите корректный номер телефона\n (например, +79874562378).");
                return;
            }

            try
            {
                db.openConnection();

                string checkQuery = "SELECT COUNT(1) FROM Customers WHERE Login = @login";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, db.GetSqlConnection()))
                {
                    checkCmd.Parameters.AddWithValue("@login", login);
                    int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userExists > 0)
                    {
                        ShowErrorMessage("Пользователь с таким логином уже существует.");
                        return;
                    }
                }

                string query = @"
                INSERT INTO Customers (FirstName, LastName, Phone, Email, Login, Password)
                VALUES (@firstName, @lastName, @phone, @email, @login, @password)";
                using (SqlCommand command = new SqlCommand(query, db.GetSqlConnection()))
                {
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);

                    command.ExecuteNonQuery();

                    lbMessError.Text = "Регистрация прошла успешно!";
                    lbMessError.ForeColor = System.Drawing.Color.Green;
                    lbMessError.Visible = true; 

                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();
                    txtEmail.Clear();
                    txtLogin.Clear();
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Ошибка при регистрации: {ex.Message}");
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void ShowErrorMessage(string message)
        {
            lbMessError.Text = message;
            lbMessError.ForeColor = System.Drawing.Color.Red;
            lbMessError.Visible = true;
        }

        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\+?\d{10,15}$");
        }

        private bool IsValidLogin(string login)
        {
            return login.Length >= 5 && Regex.IsMatch(login, @"^[a-zA-Z0-9]+$") && Regex.IsMatch(login, @"\d");
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 && Regex.IsMatch(password, @"^[a-zA-Z0-9]+$");
        }

 

 
    }
}
