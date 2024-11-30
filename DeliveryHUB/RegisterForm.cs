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
        private BD db = new BD(); // Подключение к базе данных

        public RegisterForm()
        {
            InitializeComponent();
            lbMessError.Visible = false; // Скрыть сообщение об ошибке при загрузке формы
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightGreen200, TextShade.WHITE);

        }

        // Функция проверки, что строка состоит только из латинских символов
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

            // Скрыть сообщение перед проверкой
            lbMessError.Visible = false;

            // Проверка, что все поля заполнены
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Пожалуйста, заполните все поля.");
                return;
            }

            // Проверка логина
            if (!IsValidLogin(login))
            {
                ShowErrorMessage("Логин должен быть на латинице, содержать хотя бы\n одну цифру и быть длиной не менее 5 символов.");
                return;
            }

            // Проверка email
            if (!IsLatin(email))
            {
                ShowErrorMessage("Email должен содержать только латинские буквы,\n цифры и допустимые символы (@, ., _).");
                return;
            }

            // Проверка пароля
            if (!IsValidPassword(password))
            {
                ShowErrorMessage("Пароль должен содержать только латинские\n символы, быть длиной не менее 8 символов.");
                return;
            }

            // Проверка телефона
            if (!IsValidPhone(phone))
            {
                ShowErrorMessage("Введите корректный номер телефона\n (например, +79874562378).");
                return;
            }

            // Проверка существующего логина
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

                // Регистрация нового пользователя
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
                    lbMessError.Visible = true; // Показать сообщение об успехе

                    // Очистка полей
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

        // Функция для показа сообщения об ошибке
        private void ShowErrorMessage(string message)
        {
            lbMessError.Text = message;
            lbMessError.ForeColor = System.Drawing.Color.Red;
            lbMessError.Visible = true;
        }

        // Функция проверки телефона
        private bool IsValidPhone(string phone)
        {
            // Разрешаем формат телефона с + в начале и длиной от 10 до 15 цифр
            return Regex.IsMatch(phone, @"^\+?\d{10,15}$");
        }

        // Функция проверки логина
        private bool IsValidLogin(string login)
        {
            return login.Length >= 5 && Regex.IsMatch(login, @"^[a-zA-Z0-9]+$") && Regex.IsMatch(login, @"\d");
        }

        // Функция проверки пароля: только латиница, минимум 8 символов
        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 && Regex.IsMatch(password, @"^[a-zA-Z0-9]+$");
        }

 

 
    }
}
