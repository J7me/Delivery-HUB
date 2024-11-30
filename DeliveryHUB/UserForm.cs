using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DeliveryHUB
{
    public partial class UserForm : MaterialForm
    {
        private BD db = new BD(); // Экземпляр подключения к базе данных
        private DataTable ordersTable; // Таблица для хранения данных
        private string currentSortColumn = ""; // Текущая колонка для сортировки
        private string currentSortOrder = "ASC"; // Текущий порядок сортировки
        private bool isExitButtonClicked = false;
        public static class ThemeManager
        {
            public enum Theme
            {
                Light, Dark
            }

            private static Theme currentTheme = Theme.Light;

            public static void ApplyTheme(Form form)
            {
                ApplyThemeToControls(form.Controls);

                var materialSkinManager = MaterialSkinManager.Instance;
                if (currentTheme == Theme.Dark)
                {
                    form.BackColor = Color.FromArgb(45, 45, 45);
                    form.ForeColor = Color.White;
                    materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                }
                else
                {
                    form.BackColor = Color.FromArgb(233, 233, 233);
                    form.ForeColor = Color.FromArgb(50, 50, 50);
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                }
            }

            public static void ToggleTheme(Form form)
            {
                currentTheme = currentTheme == Theme.Light ? Theme.Dark : Theme.Light;
                ApplyTheme(form);
            }

            private static void ApplyThemeToControls(Control.ControlCollection controls)
            {
                foreach (Control control in controls)
                {
                    switch (control)
                    {
                        case Button button:
                            ApplyThemeToButton(button);
                            break;
                        case TextBox textBox:
                            ApplyThemeToTextBox(textBox);
                            break;
                        case DataGridView dataGridView:
                            ApplyThemeToDataGridView(dataGridView);
                            break;
                        case MenuStrip menuStrip:
                            ApplyThemeToMenuStrip(menuStrip);
                            break;
 
                        case MaterialComboBox materialComboBox:
                            ApplyThemeToMaterialComboBox(materialComboBox);
                            break;
                        case Panel panel:
                            panel.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(55, 55, 55) : Color.FromArgb(245, 245, 245);
                            break;
                        case GroupBox groupBox:
                            groupBox.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.FromArgb(50, 50, 50);
                            break;
                    }

                    if (control.Controls.Count > 0)
                    {
                        ApplyThemeToControls(control.Controls);
                    }
                }
            }
            private static void ApplyThemeToMaterialComboBox(MaterialComboBox materialComboBox)
            {
                var materialSkinManager = MaterialSkinManager.Instance;

                if (currentTheme == Theme.Dark)
                {
                    materialComboBox.BackColor = Color.FromArgb(50, 50, 50);
                    materialComboBox.ForeColor = Color.White;
                }
                else
                {
                    materialComboBox.BackColor = Color.White;
                    materialComboBox.ForeColor = Color.Black;
                }

                // Принудительное обновление стиля
                materialComboBox.Invalidate(); // Помечаем элемент для перерисовки
                materialComboBox.Refresh();    // Принудительно обновляем отображение
            }


            private static void ApplyThemeToButton(Button button)
            {
                button.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.DarkCyan;
                button.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }

            private static void ApplyThemeToTextBox(TextBox textBox)
            {
                textBox.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.White;
                textBox.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.FromArgb(50, 50, 50);
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }

            public static void ApplyThemeToDataGridView(DataGridView dataGridView)
            {
                dataGridView.BackgroundColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.FromArgb(242, 242, 242);
                dataGridView.DefaultCellStyle.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.White;
                dataGridView.DefaultCellStyle.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.Black;
                dataGridView.DefaultCellStyle.SelectionBackColor = currentTheme == Theme.Dark ? Color.FromArgb(100, 100, 100) : Color.LightBlue;
                dataGridView.DefaultCellStyle.SelectionForeColor = currentTheme == Theme.Dark ? Color.White : Color.Black;
                // Устанавливаем размер шрифта заголовков всех колонок
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.HeaderCell.Style.Font = new System.Drawing.Font("Mongolian Baiti", 14, System.Drawing.FontStyle.Italic); // Устанавливаем размер шрифта для заголовка
                   // column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Автоматическая ширина в зависимости от содержимого
                }
                // Настройка заголовков столбцов
                var headerStyle = new DataGridViewCellStyle
                {
                    BackColor = currentTheme == Theme.Dark ? Color.FromArgb(30, 30, 30) : Color.DarkCyan,
                    ForeColor = Color.White,
                    Font = new Font("Mongolian Baiti", 20, FontStyle.Italic),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                };
                dataGridView.ColumnHeadersDefaultCellStyle = headerStyle;

                // Настройка заголовков строк
                var rowHeaderStyle = new DataGridViewCellStyle
                {
                    BackColor = currentTheme == Theme.Dark ? Color.FromArgb(30, 30, 30) : Color.DarkCyan,
                    ForeColor = Color.White,
                    Font = new Font("Mongolian Baiti", 20, FontStyle.Italic),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                };
                dataGridView.RowHeadersDefaultCellStyle = rowHeaderStyle;

                dataGridView.EnableHeadersVisualStyles = false; // Отключаем стили по умолчанию
            }

            private static void ApplyThemeToMenuStrip(MenuStrip menuStrip)
            {
                menuStrip.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(45, 45, 45) : Color.FromArgb(233, 233, 233);
                menuStrip.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.Black;

                foreach (ToolStripMenuItem menuItem in menuStrip.Items)
                {
                    ApplyThemeToMenuItem(menuItem);
                }
            }

            private static void ApplyThemeToMenuItem(ToolStripMenuItem menuItem)
            {
                menuItem.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(45, 45, 45) : Color.FromArgb(233, 233, 233);
                menuItem.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.Black;

                foreach (ToolStripItem subItem in menuItem.DropDownItems)
                {
                    if (subItem is ToolStripMenuItem dropDownItem)
                    {
                        ApplyThemeToMenuItem(dropDownItem);
                    }
                }
            }
        }


        public UserForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightGreen200, TextShade.WHITE);

            ThemeManager.ApplyTheme(this); // Применяем тему при инициализации
        }


        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders(); // Загружаем данные при загрузке формы
            LoadPickupPoints(); // Загружаем пункты выдачи
            LoadStatusOrders(); // Загружаем статусы заказов
            PopulateSortColumns(); // Загружаем названия колонок для сортировки
        }
        private void LoadPickupPoints()
        {
            try
            {
                db.openConnection();

                string query = "SELECT Address FROM PickupPoints";
                SqlCommand command = new SqlCommand(query, db.GetSqlConnection());
                SqlDataReader reader = command.ExecuteReader();

                cmbPickupPoints.Items.Clear();
                cmbPickupPoints.Items.Add("Выберите пункт"); // Пункт по умолчанию

                while (reader.Read())
                {
                    cmbPickupPoints.Items.Add(reader["Address"].ToString());
                }

                cmbPickupPoints.SelectedIndex = 0; // Устанавливаем пункт по умолчанию
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки пунктов выдачи: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void LoadStatusOrders()
        {
            try
            {
                db.openConnection();

                string query = "SELECT StatusDescription FROM OrderStatus";
                SqlCommand command = new SqlCommand(query, db.GetSqlConnection());
                SqlDataReader reader = command.ExecuteReader();

                cmbStatusOrders.Items.Clear();
                cmbStatusOrders.Items.Add("Выберите статус"); // Пункт по умолчанию

                while (reader.Read())
                {
                    cmbStatusOrders.Items.Add(reader["StatusDescription"].ToString());
                }

                cmbStatusOrders.SelectedIndex = 0; // Устанавливаем пункт по умолчанию
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статусов заказов: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }

        private int currentCustomerId; // ID авторизованного клиента

        public UserForm(int customerId)
        {
            InitializeComponent();
            currentCustomerId = customerId; // Сохраняем ID клиента
        }

        private void LoadOrders()
        {
            try
            {
                db.openConnection();

                string query = @"
SELECT 
    o.OrderID AS НомерЗаказа, 
    os.StatusDescription AS Статус,
    pm.PaymentMethod AS Оплата,
    pp.Address AS ПунктВыдачи,
    pr.Name AS Товар,
    o.OrderDate AS Дата,
    o.TotalAmount AS Цена
FROM Orders o
LEFT JOIN OrderStatus os ON o.Status = os.StatusID
LEFT JOIN Payments p ON o.PaymentID = p.PaymentID
LEFT JOIN PaymentMethods pm ON p.PaymentMethodID = pm.PaymentMethodID
LEFT JOIN PickupPoints pp ON o.PickupPointID = pp.PickupPointID
LEFT JOIN OrderItems oi ON o.OrderID = oi.OrderID
LEFT JOIN Products pr ON oi.ProductID = pr.ProductID
WHERE o.CustomerID = @CustomerID";

                SqlCommand command = new SqlCommand(query, db.GetSqlConnection());
                command.Parameters.AddWithValue("@CustomerID", currentCustomerId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                ordersTable = new DataTable();
                adapter.Fill(ordersTable);

                dataGridViewOrders.DataSource = ordersTable;

                // Применяем стили к DataGridView
                ThemeManager.ApplyThemeToDataGridView(dataGridViewOrders);

                // Остальная настройка DataGridView
                dataGridViewOrders.AutoGenerateColumns = true;
                dataGridViewOrders.ReadOnly = true;
                dataGridViewOrders.AllowUserToAddRows = false;
                dataGridViewOrders.AllowUserToDeleteRows = false;
                dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewOrders.MultiSelect = false;

                ApplyFiltersAndSorting();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных из таблицы Orders: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }





        private void PopulateSortColumns()
        {
            cmbSortTable.Items.Clear();
            cmbSortTable.Items.Add("Выберите колонку для сортировки"); // Пункт по умолчанию

            // Добавляем названия колонок из DataTable
            foreach (DataColumn column in ordersTable.Columns)
            {
                cmbSortTable.Items.Add(column.ColumnName);
            }

            cmbSortTable.SelectedIndex = 0; // Устанавливаем пункт по умолчанию
        }

        private void cmbSortTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortTable.SelectedIndex == 0) // Если выбран пункт по умолчанию
            {
                currentSortColumn = ""; // Сбрасываем сортировку
                ApplyFiltersAndSorting();
                return;
            }

            currentSortColumn = cmbSortTable.SelectedItem.ToString(); // Получаем выбранную колонку
            currentSortOrder = "ASC"; // Устанавливаем сортировку по возрастанию
            ApplyFiltersAndSorting();
        }


        private void ApplyFiltersAndSorting()
        {
            try
            {
                string selectedAddress = cmbPickupPoints.SelectedItem?.ToString();
                string selectedStatus = cmbStatusOrders.SelectedItem?.ToString();

                string filterExpression = "";

                // Фильтр по пункту выдачи
                if (!string.IsNullOrEmpty(selectedAddress) && selectedAddress != "Выберите пункт")
                {
                    filterExpression += $"[ПунктВыдачи] = '{selectedAddress}'"; // Используйте отображаемое имя столбца
                }

                // Фильтр по статусу заказа
                if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "Выберите статус")
                {
                    if (!string.IsNullOrEmpty(filterExpression))
                    {
                        filterExpression += " AND ";
                    }
                    filterExpression += $"[Статус] = '{selectedStatus}'"; // Используйте отображаемое имя столбца
                }

                // Применяем фильтр
                ordersTable.DefaultView.RowFilter = filterExpression;

                // Применяем сортировку
                if (!string.IsNullOrEmpty(currentSortColumn))
                {
                    ordersTable.DefaultView.Sort = $"{currentSortColumn} {currentSortOrder}";
                }

                // Обновляем DataGridView напрямую из DefaultView
                dataGridViewOrders.DataSource = ordersTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при применении фильтров или сортировки: {ex.Message}", "Ошибка");
            }
        }


        private void cmbPickupPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFiltersAndSorting(); // Применяем фильтры и сортировку при изменении пункта
        }

 
        private void cmbStatusOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFiltersAndSorting(); // Применяем фильтры и сортировку при изменении статуса
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExitButtonClicked) // Если форма закрывается не через кнопку "Выход"
            {
                // Завершаем процесс приложения
                Application.Exit();
            }
        }


 


 

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 200,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
                Button confirmation = new Button() { Text = "ОК", Left = 280, Width = 80, Top = 90 };

                confirmation.Click += (sender, e) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;
                
                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Сбрасываем фильтры и сортировку
            cmbPickupPoints.SelectedIndex = 0;
            cmbStatusOrders.SelectedIndex = 0;
            cmbSortTable.SelectedIndex = 0;
            currentSortColumn = "";
            currentSortOrder = "ASC";

            // Перезагружаем данные
            LoadOrders();
            MessageBox.Show("Данные успешно обновлены.", "Обновить");
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Устанавливаем флаг, что выход был инициирован кнопкой "Выход"
            isExitButtonClicked = true;

            // Открываем форму авторизации
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Закрываем текущую форму
            this.Close();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем окно для ввода строки поиска
            string searchQuery = Prompt.ShowDialog("Введите текст для поиска:", "Поиск");

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                string filterExpression = "";

                // Проверяем, является ли введенное значение числом или датой
                bool isNumeric = decimal.TryParse(searchQuery, out decimal numericValue);
                bool isDate = DateTime.TryParse(searchQuery, out DateTime dateValue);

                // Формируем выражение для фильтрации
                foreach (DataColumn column in ordersTable.Columns)
                {
                    if (column.DataType == typeof(string)) // Поиск по текстовым столбцам
                    {
                        if (!string.IsNullOrEmpty(filterExpression))
                            filterExpression += " OR ";

                        filterExpression += $"{column.ColumnName} LIKE '%{searchQuery}%'";
                    }
                    else if (column.DataType == typeof(decimal) && isNumeric) // Поиск по столбцам с ценой
                    {
                        if (!string.IsNullOrEmpty(filterExpression))
                            filterExpression += " OR ";

                        // Конвертируем число в строку и используем фильтр
                        filterExpression += $"CONVERT([{column.ColumnName}], 'System.String') LIKE '%{searchQuery}%'";
                    }
                    else if (column.DataType == typeof(DateTime)) // Поиск по столбцам с датами
                    {
                        if (!string.IsNullOrEmpty(filterExpression))
                            filterExpression += " OR ";

                        // Конвертируем дату в строку и ищем частичное совпадение
                        filterExpression += $"CONVERT([{column.ColumnName}], 'System.String') LIKE '%{searchQuery}%'";
                    }
                }

                if (!string.IsNullOrEmpty(filterExpression))
                {
                    try
                    {
                        // Применяем фильтр
                        ordersTable.DefaultView.RowFilter = filterExpression;

                        // Проверяем, есть ли результаты
                        if (ordersTable.DefaultView.Count == 0)
                        {
                            MessageBox.Show("Записи, соответствующие поисковому запросу, не найдены.", "Поиск");
                        }
                        else
                        {
                            // Обновляем DataGridView
                            dataGridViewOrders.DataSource = ordersTable.DefaultView.ToTable();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при выполнении поиска: {ex.Message}", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно выполнить поиск. Нет доступных столбцов для поиска.", "Поиск");
                }
            }
            else
            {
                MessageBox.Show("Введите строку для поиска.", "Поиск");
            }
        }



        private void ThemeSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            // Переключаем тему на основе состояния переключателя
            if (ThemeSwitcher.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            ThemeManager.ToggleTheme(this); // Применяем тему ко всем элементам

            // Принудительно обновляем все элементы
            foreach (Control control in this.Controls)
            {
                control.Invalidate(); // Помечаем элементы для перерисовки
                control.Refresh();    // Принудительно обновляем отображение
            }
        }


    }
}
