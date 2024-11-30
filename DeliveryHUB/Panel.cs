 
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static DeliveryHUB.MainForm;

namespace DeliveryHUB
{
    public partial class MainForm : MaterialForm
    {
        private BD db = new BD(); // Экземпляр подключения к базе данных
        public static class ThemeManager
        {
            public enum Theme
            {
                Light, Dark
            }
            private static Theme currentTheme = Theme.Light;
            public static void ApplyTheme(Form form)
            {
                // Применяем тему к контролам
                ApplyThemeToControls(form.Controls);

                // Обновляем тему MaterialSkin
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

                // Применяем тему
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
                        //case Label label:
                        //    ApplyThemeToLabel(label); break;
                        case TextBox textBox:
                            ApplyThemeToTextBox(textBox); break;
                        case DataGridView dataGridView:
                            ApplyThemeToDataGridView(dataGridView); break;
                        //case ComboBox comboBox:
                        //    ApplyThemeToComboBox(comboBox); break;
                        case Panel panel:
                            panel.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(55, 55, 55) : Color.FromArgb(245, 245, 245); break;
                        case GroupBox groupBox:
                            groupBox.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.FromArgb(50, 50, 50); break;
                    }
                    if (control.Controls.Count > 0)
                    {
                        ApplyThemeToControls(control.Controls);
                    }
                }
            }
            private static void ApplyThemeToButton(Button button)
            {
                button.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.DarkCyan;
                button.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.White; button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
            private static void ApplyThemeToTextBox(TextBox textBox)
            {
                textBox.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.White; textBox.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.FromArgb(50, 50, 50);
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }
            private static void ApplyThemeToDataGridView(DataGridView dataGridView)
            {
                dataGridView.BackgroundColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.FromArgb(242, 242, 242);
                dataGridView.DefaultCellStyle.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.White; dataGridView.DefaultCellStyle.ForeColor = currentTheme == Theme.Dark ? Color.FromArgb(242, 242, 242) : Color.FromArgb(50, 50, 50);
                dataGridView.DefaultCellStyle.SelectionBackColor = currentTheme == Theme.Dark ? Color.FromArgb(100, 100, 100) : Color.FromArgb(176, 224, 230); dataGridView.DefaultCellStyle.SelectionForeColor = currentTheme == Theme.Dark ? Color.FromArgb(242, 242, 242) : Color.FromArgb(50, 50, 50);
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.DarkCyan;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = currentTheme == Theme.Dark ? Color.FromArgb(242, 242, 242) : Color.FromArgb(242, 242, 242);
                dataGridView.GridColor = currentTheme == Theme.Dark ? Color.Gray : Color.LightGray;
            }
            private static void ApplyThemeToComboBox(ComboBox comboBox)
            {
                //comboBox.BackColor = currentTheme == Theme.Dark ? Color.FromArgb(50, 50, 50) : Color.White;
                //comboBox.ForeColor = currentTheme == Theme.Dark ? Color.White : Color.Black;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            dataGridViewMain.DataError += dataGridViewMain_DataError; // Подключаем обработчик
            ThemeManager.ApplyTheme(this);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightGreen200, TextShade.WHITE);


        }
        private void dataGridViewMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Определяем тип ошибки
            if (e.Exception != null && e.Exception is NoNullAllowedException)
            {
                // Получаем имя колонки, вызвавшей ошибку
                string columnName = dataGridViewMain.Columns[e.ColumnIndex].HeaderText;
                MessageBox.Show($"Ошибка: поле '{columnName}' не может быть пустым. Пожалуйста, заполните его.", "Ошибка");
            }
            else if (e.Exception != null && e.Exception is FormatException)
            {
                // Получаем имя колонки, вызвавшей ошибку
                string columnName = dataGridViewMain.Columns[e.ColumnIndex].HeaderText;
                MessageBox.Show($"Ошибка: введены некорректные данные для столбца '{columnName}'. Проверьте формат данных.", "Ошибка");
            }
            else
            {
                // Общая обработка ошибок
                MessageBox.Show($"Произошла ошибка: {e.Exception?.Message}", "Ошибка");
            }

            // Устанавливаем флаг, чтобы предотвратить выброс стандартной ошибки DataGridView
            e.ThrowException = false;
        }
        private void UpdateFilterVisibility()
        {
            // Проверяем, выбрана ли таблица Orders
            bool isOrdersTable = SwitchingTablesBox.SelectedItem?.ToString() == "Orders";

            // Управляем видимостью элементов фильтрации
            cmbPickupPoints.Visible = isOrdersTable;
            cmbStatusOrders.Visible = isOrdersTable;
            FilterLabel.Visible = isOrdersTable;

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deliveryHUBDataSet.Orders". При необходимости она может быть перемещена или удалена.
            //  this.ordersTableAdapter.Fill(this.deliveryHUBDataSet.Orders);
            PopulateTableList(); // Заполняем список таблиц в ComboBox
            LoadPickupPoints();  // Загружаем адреса из PickupPoints в ComboBox
            LoadStatusOrders();  // Загружаем статусы заказов в ComboBox
            UpdateFilterVisibility();   // Устанавливаем видимость фильтров в зависимости от выбранной таблицы
        }
        private string currentSortColumn = null; // Имя текущего столбца сортировки
        private void ApplySorting()
        {
            if (!string.IsNullOrEmpty(currentSortColumn) && dataGridViewMain.DataSource is DataTable currentTable)
            {
                currentTable.DefaultView.Sort = $"{currentSortColumn} ASC"; // Сортировка по возрастанию
                currentTable = currentTable.DefaultView.ToTable(); // Применяем сортировку
                dataGridViewMain.DataSource = currentTable; // Обновляем отображение
            }
        }
        private void PopulateTableList()
        {
            try
            {
                db.openConnection();
                DataTable schema = db.GetSqlConnection().GetSchema("Tables");

                SwitchingTablesBox.Items.Clear();
                foreach (DataRow row in schema.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    // Исключаем таблицу sysdiagrams
                    if (!string.Equals(tableName, "sysdiagrams", StringComparison.OrdinalIgnoreCase))
                    {
                        SwitchingTablesBox.Items.Add(tableName);
                    }
                }

                if (SwitchingTablesBox.Items.Count > 0)
                    SwitchingTablesBox.SelectedIndex = 5; // Выбираем пятую таблицу по умолчанию
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка таблиц: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }
        private void LoadData(string tableName)
        {
            try
            {
                db.openConnection();

                // Переменная для запроса
                string query;

                // Проверяем, если таблица Orders, то выполняем запрос с JOIN для замены ID
                if (tableName == "Orders")
                {
                    query = @"
                SELECT 
                    o.OrderID,
                    o.OrderDate, -- Добавим остальные столбцы из Orders
                    o.TotalAmount, -- Пример дополнительных столбцов
                    p.Status AS PaymentStatus, -- Заменяем PaymentID на Status из Payments
                    c.FirstName + ' ' + c.LastName AS CustomerName, -- Заменяем CustomerID на имя клиента
                    pp.Address + ', ' + pp.City AS PickupPointAddress -- Заменяем PickupPointID на адрес пункта
                FROM 
                    Orders o
                LEFT JOIN 
                    Payments p ON o.PaymentID = p.PaymentID
                LEFT JOIN 
                    Customers c ON o.CustomerID = c.CustomerID
                LEFT JOIN 
                    PickupPoints pp ON o.PickupPointID = pp.PickupPointID";
                }
                else if (tableName == "Administrators")
                {
                    query = @"
                SELECT 
                    a.AdministratorID,
                    a.FirstName,
                    a.LastName,
                    a.Login,
                    a.Password,
                    pp.Address + ', ' + pp.City AS PickupPointAddress -- Заменяем PickupPointID на адрес из PickupPoints
                FROM 
                    Administrators a
                LEFT JOIN 
                    PickupPoints pp ON a.PickupPointID = pp.PickupPointID";
                }
                else if (tableName == "Delivery")
{
    query = @"
        SELECT 
            d.DeliveryID,
            d.DeliveryDate,
            sd.StatusDelivery AS Status,  -- Подменяем Status на StatusDelivery
            pp.Address + ', ' + pp.City AS PickupPointAddress  -- Подменяем PickupPointID на Address и City
        FROM 
            Delivery d
        LEFT JOIN 
            PickupPoints pp ON d.PickupPointID = pp.PickupPointID
        LEFT JOIN 
            StatusesDelivery sd ON d.Status = sd.DeliveryStatusID";  // Подключаем таблицу StatusesDelivery для подмены статуса
}

                else if (tableName == "OrderIssues")
                {
                    query = @"
        SELECT 
            oi.IssueID,
            oi.OrderID,
            oi.Description,
            oi.IssueDate,
            oi.ResolvedDate,
            ists.Status AS IssueStatus
        FROM 
            OrderIssues oi
        LEFT JOIN 
            IssueStatuses ists ON oi.IssueStatusID = ists.IssueStatusID";
                }

                else if (tableName == "OrderItems")
                {
                    query = @"
        SELECT 
            oi.OrderItemID,
            oi.OrderID,
            p.Name AS ProductName, -- Заменяем ProductID на Name из таблицы Products
            oi.Quantity
        FROM 
            OrderItems oi
        LEFT JOIN 
            Products p ON oi.ProductID = p.ProductID";
                }
                else if (tableName == "Payments")
                {
                    query = @"
        SELECT 
            p.PaymentID,
            p.PaymentDate,
            p.Amount,
            p.Status,
            pm.PaymentMethod -- Заменяем PaymentMethodID на PaymentMethod из таблицы PaymentMethods
        FROM 
            Payments p
        LEFT JOIN 
            PaymentMethods pm ON p.PaymentMethodID = pm.PaymentMethodID";
                }

                else
                {
                    // Стандартный запрос для других таблиц
                    query = $"SELECT * FROM {tableName}";
                }

                // Выполняем запрос
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetSqlConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Получаем информацию о первичном ключе
                DataTable primaryKeyInfo = db.GetSqlConnection().GetSchema("IndexColumns", new[] { null, null, tableName, null });
                string primaryKeyColumn = primaryKeyInfo.Rows.Count > 0 ? primaryKeyInfo.Rows[0]["COLUMN_NAME"].ToString() : null;

                // Устанавливаем источник данных
                dataGridViewMain.DataSource = table;
                dataGridViewMain.AllowUserToAddRows = false;

                // Делаем колонку с первичным ключом только для чтения
                if (!string.IsNullOrEmpty(primaryKeyColumn) && dataGridViewMain.Columns.Contains(primaryKeyColumn))
                {
                    dataGridViewMain.Columns[primaryKeyColumn].ReadOnly = true;
                }
                PopulateSortColumns();
                // Устанавливаем размер шрифта заголовков всех колонок
                foreach (DataGridViewColumn column in dataGridViewMain.Columns)
                {
                    column.HeaderCell.Style.Font = new System.Drawing.Font("Mongolian Baiti", 14, System.Drawing.FontStyle.Italic); // Устанавливаем размер шрифта для заголовка
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; // Автоматическая ширина в зависимости от контента
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchingTablesBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите таблицу перед добавлением записи.", "Ошибка");
                return;
            }

            string tableName = SwitchingTablesBox.SelectedItem.ToString();
            int newOrderID = -1; // ID новой записи, если таблица Orders
            try
            {
                db.openConnection();

                // Если таблица "Orders", проверяем и сбрасываем идентификатор автоинкремента
                if (tableName == "Orders")
                {
                    // Получаем максимальное значение ID
                    string maxIdQuery = "SELECT ISNULL(MAX(OrderID), 0) FROM Orders;";
                    int maxId = 0;

                    using (SqlCommand maxIdCommand = new SqlCommand(maxIdQuery, db.GetSqlConnection()))
                    {
                        maxId = Convert.ToInt32(maxIdCommand.ExecuteScalar());
                    }

                    // Сбрасываем идентификатор до текущего максимального значения
                    string resetIdentityQuery = $"DBCC CHECKIDENT ('Orders', RESEED, {maxId});";
                    using (SqlCommand resetCommand = new SqlCommand(resetIdentityQuery, db.GetSqlConnection()))
                    {
                        resetCommand.ExecuteNonQuery(); // Выполняем сброс идентификатора
                    }
                }

                // Получаем схему таблицы
                DataTable schema = db.GetSqlConnection().GetSchema("Columns", new[] { null, null, tableName });

                // Определяем первичный ключ
                string primaryKeyColumn = schema.Rows[0]["COLUMN_NAME"].ToString(); // Предполагаем, что первый столбец — первичный ключ
                var columns = schema.AsEnumerable().Where(row => row["COLUMN_NAME"].ToString() != primaryKeyColumn);

                // Формируем SQL-запрос без указания первичного ключа
                string query = $"INSERT INTO {tableName} ({string.Join(", ", columns.Select(row => row["COLUMN_NAME"].ToString()))}) " +
                               $"VALUES ({string.Join(", ", columns.Select((_, index) => $"@param{index}"))}); " +
                               "SELECT SCOPE_IDENTITY();"; // Получаем ID созданной записи, если это таблица Orders

                using (SqlCommand command = new SqlCommand(query, db.GetSqlConnection()))
                {
                    DateTime? orderDate = null;

                    foreach (var column in columns)
                    {
                        string columnName = column["COLUMN_NAME"].ToString();
                        string dataType = column["DATA_TYPE"].ToString(); // Получаем тип данных столбца
                        bool isNullable = column["IS_NULLABLE"].ToString() == "YES"; // Проверяем, допускает ли столбец NULL

                        object value = null;

                        if (dataType.Contains("date")) // Если столбец является датой
                        {
                            DateTime? minDate = null;

                            if (columnName.Equals("PickupDate", StringComparison.OrdinalIgnoreCase) && orderDate.HasValue)
                            {
                                minDate = orderDate; // Устанавливаем минимальную дату
                            }

                            value = ShowDatePickerWithLabel($"Выберите значение для {columnName}:", columnName, minDate);

                            if (value != null && columnName.Equals("OrderDate", StringComparison.OrdinalIgnoreCase))
                            {
                                orderDate = (DateTime)value;
                            }
                        }
                        else
                        {
                            value = Prompt.ShowDialog($"Введите значение для {columnName}:", "Добавить запись");

                            // Если это поле для телефона, проверим его
                            if (columnName.Equals("Phone", StringComparison.OrdinalIgnoreCase))
                            {
                                if (!IsValidPhoneNumber(value?.ToString()))
                                {
                                    MessageBox.Show("Номер телефона должен содержать только цифры или символ +.", "Ошибка");
                                    return; // Прерываем операцию
                                }
                            }
                        }

                        // Если значение пустое и поле не допускает NULL, прерываем добавление
                        if (value == null || (value is string strValue && string.IsNullOrEmpty(strValue)))
                        {
                            if (!isNullable)
                            {
                                MessageBox.Show($"Поле '{columnName}' не может быть пустым. Заполните обязательное поле.", "Ошибка");
                                return; // Прерываем операцию
                            }
                            command.Parameters.AddWithValue($"@param{columns.ToList().IndexOf(column)}", DBNull.Value);
                            continue;
                        }

                        // Добавляем значение в команду
                        command.Parameters.AddWithValue($"@param{columns.ToList().IndexOf(column)}", value);
                    }

                    // Выполняем SQL-команду и, если это таблица Orders, получаем новый ID
                    if (tableName == "Orders")
                    {
                        newOrderID = Convert.ToInt32(command.ExecuteScalar());
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                    }
                }

                // Если это таблица Orders, предлагаем выбрать продукт
                if (tableName == "Orders" && newOrderID > 0)
                {
                    using (Form productSelectionForm = new Form())
                    {
                        productSelectionForm.Text = "Выбор продукта";
                        productSelectionForm.Width = 400;
                        productSelectionForm.Height = 150;
                        productSelectionForm.StartPosition = FormStartPosition.CenterParent;

                        ComboBox cmbProducts = new ComboBox
                        {
                            Left = 10,
                            Top = 10,
                            Width = 360
                        };

                        LoadProductsIntoComboBox(cmbProducts);
                        productSelectionForm.Controls.Add(cmbProducts);

                        Button btnConfirm = new Button
                        {
                            Text = "Выбрать",
                            Left = 150,
                            Top = 50,
                            Width = 100,
                            DialogResult = DialogResult.OK
                        };
                        btnConfirm.Click += (s, args) => productSelectionForm.Close();
                        productSelectionForm.Controls.Add(btnConfirm);

                        if (productSelectionForm.ShowDialog() == DialogResult.OK)
                        {
                            if (cmbProducts.SelectedItem != null)
                            {
                                DataRowView selectedRow = (DataRowView)cmbProducts.SelectedItem;
                                int selectedProductID = Convert.ToInt32(selectedRow["ProductID"]);

                                string orderItemsQuery = "INSERT INTO OrderItems (OrderID, ProductID, Quantity) VALUES (@OrderID, @ProductID, @Quantity)";
                                using (SqlCommand orderItemsCommand = new SqlCommand(orderItemsQuery, db.GetSqlConnection()))
                                {
                                    orderItemsCommand.Parameters.AddWithValue("@OrderID", newOrderID);
                                    orderItemsCommand.Parameters.AddWithValue("@ProductID", selectedProductID);
                                    orderItemsCommand.Parameters.AddWithValue("@Quantity", 1);

                                    orderItemsCommand.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Продукт не выбран. Операция отменена.", "Ошибка");
                            }
                        }
                    }
                }

                LoadData(tableName); // Обновляем данные таблицы
                MessageBox.Show("Запись успешно добавлена.", "Успех");
            }
            catch (SqlException ex)
            {
                // Детальная обработка ошибок
                string errorMessage = TranslateSqlError(ex); // Переводим ошибку
                MessageBox.Show($"Ошибка добавления записи: {errorMessage}", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }
        // Метод для проверки корректности номера телефона
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Регулярное выражение для проверки номера телефона
            string pattern = @"^\+?\d+$"; // Разрешает только цифры и один символ +

            return !string.IsNullOrEmpty(phoneNumber) && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern);
        }
        private DateTime? ShowDatePickerWithLabel(string caption, string columnName, DateTime? minDate = null)
{
    using (Form datePickerForm = new Form())
    {
        datePickerForm.Text = caption;
        datePickerForm.Width = 400;
        datePickerForm.Height = 200;
        datePickerForm.StartPosition = FormStartPosition.CenterParent;

        // Добавляем метку
        Label label = new Label
        {
            Text = $"Выберите {columnName}:",
            Left = 10,
            Top = 10,
            Width = 360
        };
        datePickerForm.Controls.Add(label);

        // Добавляем элемент DateTimePicker
        DateTimePicker datePicker = new DateTimePicker
        {
            Left = 10,
            Top = 40,
            Width = 360,
            Format = DateTimePickerFormat.Short // Устанавливаем короткий формат даты
        };

        // Устанавливаем минимальную дату, если задана
        if (minDate.HasValue)
        {
            datePicker.MinDate = minDate.Value;
        }

        datePickerForm.Controls.Add(datePicker);

        // Кнопка подтверждения
        Button btnConfirm = new Button
        {
            Text = "Выбрать",
            Left = 150,
            Top = 100,
            Width = 100,
            DialogResult = DialogResult.OK
        };
        btnConfirm.Click += (s, args) => datePickerForm.Close();
        datePickerForm.Controls.Add(btnConfirm);

        // Отображаем окно и обрабатываем результат
        if (datePickerForm.ShowDialog() == DialogResult.OK)
        {
            return datePicker.Value; // Возвращаем выбранную дату
        }
        else
        {
            return null; // Если выбор отменен
        }
    }
}
        private void LoadProductsIntoComboBox(ComboBox comboBox)
        {
            try
            {
                string query = "SELECT ProductID, Name FROM Products";

                SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetSqlConnection());
                DataTable productsTable = new DataTable();
                adapter.Fill(productsTable);

                comboBox.DataSource = productsTable;
                comboBox.DisplayMember = "Name"; // Отображать имена продуктов
                comboBox.ValueMember = "ProductID"; // Хранить ID продуктов
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки списка продуктов: {ex.Message}", "Ошибка");
            }
        }
        private string TranslateSqlError(SqlException ex)
        {
            string message = ex.Message.ToLower();

            if (message.Contains("conversion failed"))
            {
                if (message.Contains("int"))
                    return "Ошибка: введено некорректное значение. Проверьте, что данные соответствуют числовому формату.";
                if (message.Contains("date and/or time"))
                    return "Ошибка: неверный формат даты или времени. Убедитесь, что дата соответствует формату 'ДД-ММ-ГГГГ'.";
            }
            else if (message.Contains("error converting data type nvarchar to numeric"))
            {
                return "Ошибка: введено некорректное значение в поле, где требуется числовой формат. Убедитесь, что данные являются числами.";
            }
            else if (message.Contains("cannot insert the value null"))
            {
                // Находим имя столбца
                var columnMatch = System.Text.RegularExpressions.Regex.Match(message, @"column '(.*?)'");
                string columnName = columnMatch.Success ? columnMatch.Groups[1].Value : "неизвестное поле";
                return $"Ошибка: поле '{columnName}' не может быть пустым. Заполните это поле перед сохранением.";
            }
            else if (message.Contains("violation of primary key constraint"))
            {
                return "Ошибка: нарушение ограничения первичного ключа. Такая запись уже существует.";
            }
            else if (message.Contains("violation of unique constraint"))
            {
                return "Ошибка: нарушение ограничения уникальности. Значение должно быть уникальным.";
            }
            else if (message.Contains("conflicted with the foreign key constraint"))
            {
                return "Ошибка: введённое значение отсутствует в связанной таблице. Проверьте правильность ссылки на существующую запись.";
            }
            else if (message.Contains("string or binary data would be truncated"))
            {
                return "Ошибка: введённые данные превышают допустимую длину для поля. Проверьте ввод и повторите попытку.";
            }
            else if (message.Contains("invalid column name"))
            {
                return "Ошибка: указано неверное имя столбца. Проверьте структуру таблицы.";
            }

            // Если ошибка не распознана
            return $"SQL-ошибка: {ex.Message}";
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchingTablesBox.SelectedItem == null || dataGridViewMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите таблицу и запись для редактирования.", "Ошибка");
                return;
            }

            string tableName = SwitchingTablesBox.SelectedItem.ToString();
            try
            {
                db.openConnection();
                DataTable schema = db.GetSqlConnection().GetSchema("Columns", new[] { null, null, tableName });

                string keyColumn = schema.Rows[0]["COLUMN_NAME"].ToString();
                int id = Convert.ToInt32(dataGridViewMain.SelectedRows[0].Cells[0].Value);

                string query = $"UPDATE {tableName} SET {string.Join(", ", schema.Rows.Cast<DataRow>().Skip(1).Select((row, index) => $"{row["COLUMN_NAME"]} = @param{index}"))} WHERE {keyColumn} = @id";

                using (SqlCommand command = new SqlCommand(query, db.GetSqlConnection()))
                {
                    DateTime? orderDate = null; // Для хранения значения OrderDate

                    for (int i = 1; i < schema.Rows.Count; i++)
                    {
                        string columnName = schema.Rows[i]["COLUMN_NAME"].ToString();
                        string dataType = schema.Rows[i]["DATA_TYPE"].ToString(); // Получаем тип данных столбца
                        object newValue = null;

                        if (dataType.Contains("date")) // Если столбец является датой
                        {
                            DateTime? minDate = null;

                            if (columnName.Equals("PickupDate", StringComparison.OrdinalIgnoreCase) && orderDate.HasValue)
                            {
                                minDate = orderDate; // Устанавливаем минимальную дату
                            }

                            newValue = ShowDatePickerWithLabel($"Выберите значение для {columnName}:", columnName, minDate);

                            if (newValue != null && columnName.Equals("OrderDate", StringComparison.OrdinalIgnoreCase))
                            {
                                orderDate = (DateTime)newValue;
                            }
                        }
                        else
                        {
                            newValue = Prompt.ShowDialog($"Введите новое значение для {columnName}:", "Редактировать запись");
                        }

                        // Если значение пустое, передаём DBNull
                        if (newValue == null || (newValue is string strValue && string.IsNullOrEmpty(strValue)))
                        {
                            command.Parameters.AddWithValue($"@param{i - 1}", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue($"@param{i - 1}", newValue);
                        }
                    }

                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                LoadData(tableName);
                MessageBox.Show("Запись успешно обновлена.", "Успех");
            }
            catch (SqlException ex)
            {
                string errorMessage = TranslateSqlError(ex); // Переводим ошибку
                MessageBox.Show($"Ошибка редактирования записи: {errorMessage}", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка редактирования записи: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchingTablesBox.SelectedItem == null || dataGridViewMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите таблицу и запись для удаления.", "Ошибка");
                return;
            }

            string tableName = SwitchingTablesBox.SelectedItem.ToString();
            try
            {
                db.openConnection();
                // Получаем первичный ключ выбранной записи
                string keyColumn = db.GetSqlConnection().GetSchema("Columns", new[] { null, null, tableName }).Rows[0]["COLUMN_NAME"].ToString();
                int id = Convert.ToInt32(dataGridViewMain.SelectedRows[0].Cells[0].Value);

                // Проверяем наличие связанных записей
                string relatedRecords = CheckRelatedRecords(id, tableName);

                // Формируем сообщение для подтверждения удаления
                string message = string.IsNullOrEmpty(relatedRecords)
                    ? $"Вы уверены, что хотите удалить запись с ID = {id} из таблицы '{tableName}'?"
                    : $"Вы уверены, что хотите удалить запись с ID = {id} из таблицы '{tableName}'?\n" +
                      $"Эта запись связана со следующими данными:\n{relatedRecords}";

                // Показываем диалоговое окно с предупреждением
                DialogResult result = MessageBox.Show(
                    message,
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Если пользователь выбрал "No", отменяем удаление
                if (result == DialogResult.No)
                {
                    return;
                }

                // Выполняем удаление записи
                string query = $"DELETE FROM {tableName} WHERE {keyColumn} = @id";

                using (SqlCommand command = new SqlCommand(query, db.GetSqlConnection()))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                LoadData(tableName);
                MessageBox.Show("Запись успешно удалена.", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления записи: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }
        private void SwitchingTablesBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (SwitchingTablesBox.SelectedItem != null)
            {
                string selectedTable = SwitchingTablesBox.SelectedItem.ToString();
                LoadData(selectedTable);
            }
            // Обновляем видимость фильтров
            UpdateFilterVisibility();
        }
        private void dataGridViewMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Игнорируем заголовки

            if (SwitchingTablesBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите таблицу для редактирования данных.", "Ошибка");
                return;
            }

            string tableName = SwitchingTablesBox.SelectedItem.ToString(); // Определяем название таблицы

            try
            {
                db.openConnection();

                // Определяем имя колонки и значение ключевого столбца
                string columnName = dataGridViewMain.Columns[e.ColumnIndex].HeaderText;
                string keyColumn = dataGridViewMain.Columns[0].HeaderText; // Предполагаем, что ключевой столбец — первый
                object id = dataGridViewMain.Rows[e.RowIndex].Cells[0].Value;

                if (id == null)
                {
                    MessageBox.Show("Не удалось определить ключевую колонку для редактирования.", "Ошибка");
                    return;
                }

                // Получаем новое значение из измененной ячейки
                object newValue = dataGridViewMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ?? DBNull.Value;

                // Получаем информацию о столбце, чтобы проверить допустимость NULL
                DataTable schema = db.GetSqlConnection().GetSchema("Columns", new[] { null, null, tableName });
                var columnInfo = schema.AsEnumerable().FirstOrDefault(row => row["COLUMN_NAME"].ToString() == columnName);
                bool isNullable = columnInfo != null && columnInfo["IS_NULLABLE"].ToString() == "YES";

                if (!isNullable && (newValue == null || newValue == DBNull.Value || string.IsNullOrWhiteSpace(newValue.ToString())))
                {
                    MessageBox.Show($"Поле '{columnName}' не может быть пустым. Пожалуйста, заполните это поле.", "Ошибка");
                    return;
                }

                // Формируем запрос для обновления
                string query = $"UPDATE {tableName} SET {columnName} = @value WHERE {keyColumn} = @id";
                using (SqlCommand command = new SqlCommand(query, db.GetSqlConnection()))
                {
                    command.Parameters.AddWithValue("@value", newValue);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                //MessageBox.Show("Данные успешно обновлены.", "Успех");
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("FOREIGN KEY"))
                {
                    MessageBox.Show($"Ошибка при обновлении данных: значение, введённое в поле '{dataGridViewMain.Columns[e.ColumnIndex].HeaderText}', не существует в связанной таблице. Убедитесь, что введённое значение корректно.", "Ошибка");
                }
                else
                {
                    MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }
        private void dataGridViewMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMain_CellValueChanged(sender, e); // Вызываем обновление данных
        }
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchingTablesBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите таблицу перед поиском.", "Ошибка");
                return;
            }

            string searchValue = Prompt.ShowDialog("Введите значение для поиска:", "Поиск");
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Значение для поиска не введено.", "Ошибка");
                return;
            }

            try
            {
                DataTable table = (DataTable)dataGridViewMain.DataSource;
                if (table == null)
                {
                    MessageBox.Show("Данные таблицы не загружены.", "Ошибка");
                    return;
                }

                // Экранируем символы, которые могут вызвать ошибки в фильтре
                searchValue = searchValue.Replace("'", "''");

                // Формируем фильтр
                string filter = string.Join(" OR ", table.Columns.Cast<DataColumn>().Select(col =>
                {
                    if (col.DataType == typeof(string))
                    {
                        return $"{col.ColumnName} LIKE '%{searchValue}%'";
                    }
                    else if (col.DataType == typeof(int) || col.DataType == typeof(decimal) || col.DataType == typeof(double) || col.DataType == typeof(float))
                    {
                        // Конвертируем числовые значения в строку
                        return $"CONVERT([{col.ColumnName}], 'System.String') LIKE '%{searchValue}%'";
                    }
                    else if (col.DataType == typeof(DateTime))
                    {
                        // Конвертируем дату в строку в формате "dd.MM.yyyy"
                        return $"CONVERT([{col.ColumnName}], 'System.String') LIKE '%{searchValue}%'";
                    }
                    else
                    {
                        return "1=0"; // Игнорируем неподходящие столбцы
                    }
                }));

                // Применяем фильтр к DataTable
                table.DefaultView.RowFilter = filter;

                if (table.DefaultView.Count == 0)
                {
                    MessageBox.Show("Записи, соответствующие поисковому запросу, не найдены.", "Результат поиска");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении поиска: {ex.Message}", "Ошибка");
            }
        }
        private bool isLogout = false;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Проверяем, закрывается ли форма через кнопку "Выход" или крестик
            if (!isLogout)
            {
                // Если форма закрывается через крестик, завершаем процесс приложения
                Application.Exit();
            }
        }
        private string CheckRelatedRecords(int id, string tableName)
        {
            string relatedInfo = "";
            try
            {
                // Проверяем связанные таблицы
                var relatedTables = new (string table, string column)[]
                {
            ("Orders", "CustomerID"),
            ("OrderItems", "OrderID"),
            ("OrderIssues", "OrderID"),
            ("Payments", "PaymentID"),
            ("Delivery", "PickupPointID"),
            ("Administrators", "PickupPointID")
                };

                foreach (var (relatedTable, relatedColumn) in relatedTables)
                {
                    string query = $"SELECT COUNT(*) FROM {relatedTable} WHERE {relatedColumn} = @id";
                    using (SqlCommand command = new SqlCommand(query, db.GetSqlConnection()))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Если найдены связанные записи, добавляем информацию в строку relatedInfo
                        if (count > 0)
                        {
                            relatedInfo += $"- Таблица '{relatedTable}': {count} связанных записей\n";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка проверки связанных записей: {ex.Message}", "Ошибка");
            }

            return relatedInfo;
        }
        private void UpdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchingTablesBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите таблицу перед обновлением.", "Ошибка");
                return;
            }

            // Получаем название текущей выбранной таблицы
            string tableName = SwitchingTablesBox.SelectedItem.ToString();

            // Загружаем данные из выбранной таблицы
            LoadData(tableName);

            //MessageBox.Show("Данные таблицы успешно обновлены.", "Обновление");
        }
        private void LoadPickupPoints()
        {
            try
            {
                db.openConnection();
                string query = "SELECT Address FROM PickupPoints"; // Запрос для получения всех адресов
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetSqlConnection());
                DataTable pickupPointsTable = new DataTable();
                adapter.Fill(pickupPointsTable);

                cmbPickupPoints.Items.Clear(); // Очистить старые элементы
                cmbPickupPoints.Items.Add("Выберите пункт"); // Добавляем пустой пункт
                foreach (DataRow row in pickupPointsTable.Rows)
                {
                    string address = row["Address"].ToString();
                    cmbPickupPoints.Items.Add(address); // Добавляем адрес в ComboBox
                }

                cmbPickupPoints.SelectedIndex = 0; // По умолчанию выбираем первый элемент (Выберите пункт)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки адресов: {ex.Message}", "Ошибка");
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

                string query = "SELECT StatusDescription FROM OrderStatus"; // Запрос на получение всех статусов
                SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetSqlConnection());
                DataTable statusTable = new DataTable();
                adapter.Fill(statusTable);

                cmbStatusOrders.Items.Clear(); // Очищаем старые данные
                cmbStatusOrders.Items.Add("Выберите статус"); // Добавляем пункт по умолчанию

                foreach (DataRow row in statusTable.Rows)
                {
                    cmbStatusOrders.Items.Add(row["StatusDescription"].ToString()); // Добавляем статусы
                }

                cmbStatusOrders.SelectedIndex = 0; // Устанавливаем пункт по умолчанию
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статусов: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }
        private void cmbPickupPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAddress = cmbPickupPoints.SelectedItem?.ToString();
            string selectedStatus = cmbStatusOrders.SelectedItem?.ToString();

            // Если оба фильтра сброшены, показываем все заказы
            if ((selectedAddress == "Выберите пункт" || string.IsNullOrEmpty(selectedAddress)) &&
                (selectedStatus == "Выберите статус" || string.IsNullOrEmpty(selectedStatus)))
            {
                LoadData(SwitchingTablesBox.SelectedItem.ToString());
                return;
            }

            try
            {
                db.openConnection();

                // Базовый запрос для фильтрации
                string query = @"
        SELECT 
            o.OrderID,
            o.OrderDate,
            o.TotalAmount,
            p.Status AS PaymentStatus,
            c.FirstName + ' ' + c.LastName AS CustomerName,
            pp.Address AS PickupPointAddress,
 
            os.StatusDescription      -- Добавляем StatusDescription
        FROM 
            Orders o
        LEFT JOIN 
            Payments p ON o.PaymentID = p.PaymentID
        LEFT JOIN 
            Customers c ON o.CustomerID = c.CustomerID
        LEFT JOIN 
            PickupPoints pp ON o.PickupPointID = pp.PickupPointID
        LEFT JOIN 
            OrderStatus os ON o.Status = os.StatusID";  // JOIN для получения описания статуса

                // Фильтрация по адресу
                if (!string.IsNullOrEmpty(selectedAddress) && selectedAddress != "Выберите пункт")
                {
                    query += " WHERE pp.Address = @address";  // Фильтруем по адресу
                }

                // Фильтрация по статусу
                if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "Выберите статус")
                {
                    // Если добавлен фильтр по статусу, добавляем условие для фильтрации по StatusDescription
                    if (query.Contains("WHERE"))
                    {
                        query += " AND os.StatusDescription = @status";  // Фильтрация по статусу
                    }
                    else
                    {
                        query += " WHERE os.StatusDescription = @status";  // Добавляем WHERE если фильтры несколько
                    }
                }

                query += " ORDER BY o.OrderID";  // Сортировка по умолчанию, если не выбран другой критерий

                SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetSqlConnection());

                // Добавление параметров для фильтров
                if (!string.IsNullOrEmpty(selectedAddress) && selectedAddress != "Выберите пункт")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@address", selectedAddress);
                }

                if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "Выберите статус")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@status", selectedStatus);
                }

                DataTable ordersTable = new DataTable();
                adapter.Fill(ordersTable);

                // Отображаем данные в DataGridView
                dataGridViewMain.DataSource = ordersTable;
                dataGridViewMain.AutoResizeColumns(); // Автоматическое изменение размера колонок
                ApplySorting(); // Применяем сохраненную сортировку

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных заказов: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void cmbStatusOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAddress = cmbPickupPoints.SelectedItem?.ToString();
            string selectedStatus = cmbStatusOrders.SelectedItem?.ToString();

            // Если оба фильтра сброшены, показываем все заказы
            if ((selectedAddress == "Выберите пункт" || string.IsNullOrEmpty(selectedAddress)) &&
                (selectedStatus == "Выберите статус" || string.IsNullOrEmpty(selectedStatus)))
            {
                LoadData(SwitchingTablesBox.SelectedItem.ToString()); // Загрузка всех данных
                return;
            }

            try
            {
                db.openConnection();

                // Базовый запрос для фильтрации
                string query = @"
        SELECT 
            o.OrderID,
            o.OrderDate,
            o.TotalAmount,
            p.Status AS PaymentStatus,
            c.FirstName + ' ' + c.LastName AS CustomerName,
            pp.Address AS PickupPointAddress,

            os.StatusDescription      -- Добавляем StatusDescription
        FROM 
            Orders o
        LEFT JOIN 
            Payments p ON o.PaymentID = p.PaymentID
        LEFT JOIN 
            Customers c ON o.CustomerID = c.CustomerID
        LEFT JOIN 
            PickupPoints pp ON o.PickupPointID = pp.PickupPointID
        LEFT JOIN 
            OrderStatus os ON o.Status = os.StatusID";  // JOIN для получения описания статуса

                // Фильтрация по адресу
                if (!string.IsNullOrEmpty(selectedAddress) && selectedAddress != "Выберите пункт")
                {
                    query += " WHERE pp.Address = @address";
                }

                // Фильтрация по статусу
                if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "Выберите статус")
                {
                    query += " AND os.StatusDescription = @status";  // Используем описание статуса для фильтрации
                }

                query += " ORDER BY o.OrderID";  // Сортировка по умолчанию, если не выбран другой критерий

                SqlDataAdapter adapter = new SqlDataAdapter(query, db.GetSqlConnection());

                // Добавление параметров для фильтров
                if (!string.IsNullOrEmpty(selectedAddress) && selectedAddress != "Выберите пункт")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@address", selectedAddress);
                }

                if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "Выберите статус")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@status", selectedStatus);
                }

                DataTable ordersTable = new DataTable();
                adapter.Fill(ordersTable);

                // Отображаем данные в DataGridView
                dataGridViewMain.DataSource = ordersTable;
                dataGridViewMain.AutoResizeColumns(); // Автоматическое изменение размера колонок
                ApplySorting(); // Применяем сохраненную сортировку

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных заказов: {ex.Message}", "Ошибка");
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void cmbSortTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortTable.SelectedItem != null && dataGridViewMain.DataSource is DataTable currentTable)
            {
                string selectedColumn = cmbSortTable.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(selectedColumn))
                {
                    // Применяем сортировку к DataView, а затем к DataGridView
                    currentTable.DefaultView.Sort = $"{selectedColumn} ASC"; // Сортировка по возрастанию

                    // Обновляем источник данных в DataGridView
                    dataGridViewMain.DataSource = currentTable.DefaultView.ToTable();
                }
            }

            // Обработка выбранного столбца для сохранения информации о сортировке
            if (cmbSortTable.SelectedItem != null)
            {
                currentSortColumn = cmbSortTable.SelectedItem.ToString(); // Сохраняем выбранный столбец
                ApplySorting(); // Применяем сортировку, если это необходимо
            }
        }
        private void PopulateSortColumns()
        {
            if (dataGridViewMain.DataSource is DataTable currentTable)
            {
                cmbSortTable.Items.Clear();  // Очистить ComboBox

                // Добавляем имена всех столбцов в ComboBox
                foreach (DataColumn column in currentTable.Columns)
                {
                    cmbSortTable.Items.Add(column.ColumnName);
                }

                // Выбираем первый столбец по умолчанию
                if (cmbSortTable.Items.Count > 0)
                {
                    cmbSortTable.SelectedIndex = 0;
                }
            }
        }

        private void SwitchingTablesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SwitchingTablesBox.SelectedItem != null)
            {
                string selectedTable = SwitchingTablesBox.SelectedItem.ToString();
                LoadData(selectedTable);
            }
            // Обновляем видимость фильтров
            UpdateFilterVisibility();
        }
        private void ThemeSwitcher_CheckedChanged(object sender, EventArgs e)
        {

            ThemeManager.ToggleTheme(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Устанавливаем флаг выхода
            isLogout = true;

            // Создаем экземпляр формы авторизации
            LoginForm loginForm = new LoginForm();

            // Показываем форму авторизации
            loginForm.Show();

            // Скрываем текущую форму MainForm
            this.Hide();
        }


    }

    // Класс Prompt
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen // Центрирование окна
            };

            Label textLabel = new Label() { Left = 10, Top = 10, Text = text, Width = 370 };
            TextBox textBox = new TextBox() { Left = 10, Top = 40, Width = 370 };
            Button confirmation = new Button() { Text = "OK", Left = 210, Width = 80, Top = 70, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Отмена", Left = 300, Width = 80, Top = 70, DialogResult = DialogResult.Cancel };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);

            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            var result = prompt.ShowDialog();

            if (result == DialogResult.OK)
            {
                return textBox.Text;
            }
            else
            {
                return null; // Пользователь нажал "Отмена" или закрыл окно
            }
        }
    }

}
