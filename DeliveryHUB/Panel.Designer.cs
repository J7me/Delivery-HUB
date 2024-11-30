namespace DeliveryHUB
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.RecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.UpdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SwitchingTablesBox = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbPickupPoints = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbStatusOrders = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbSortTable = new MaterialSkin.Controls.MaterialComboBox();
            this.FilterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SortLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ThemeSwitcher = new MaterialSkin.Controls.MaterialSwitch();
            this.TableLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ThemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MenuBar = new MaterialSkin.Controls.MaterialProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.ToolbarMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToOrderColumns = true;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMain.EnableHeadersVisualStyles = false;
            this.dataGridViewMain.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 209);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMain.RowHeadersWidth = 35;
            this.dataGridViewMain.RowTemplate.Height = 20;
            this.dataGridViewMain.Size = new System.Drawing.Size(969, 301);
            this.dataGridViewMain.TabIndex = 2;
            this.dataGridViewMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellEndEdit);
            this.dataGridViewMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellValueChanged);
            // 
            // RecToolStripMenuItem
            // 
            this.RecToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.RecToolStripMenuItem.Name = "RecToolStripMenuItem";
            this.RecToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.RecToolStripMenuItem.Text = "Записи";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.AutoSize = false;
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(290, 27);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.EditToolStripMenuItem.Text = "Редактировать";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.SearchToolStripMenuItem.Text = "Поиск";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ToolbarMenuStrip
            // 
            this.ToolbarMenuStrip.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolbarMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolbarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.UpdToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.ToolbarMenuStrip.Location = new System.Drawing.Point(3, 64);
            this.ToolbarMenuStrip.Name = "ToolbarMenuStrip";
            this.ToolbarMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.ToolbarMenuStrip.Size = new System.Drawing.Size(980, 26);
            this.ToolbarMenuStrip.TabIndex = 1;
            this.ToolbarMenuStrip.Text = "menuStrip2";
            // 
            // UpdToolStripMenuItem
            // 
            this.UpdToolStripMenuItem.Name = "UpdToolStripMenuItem";
            this.UpdToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.UpdToolStripMenuItem.Text = "Обновить";
            this.UpdToolStripMenuItem.Click += new System.EventHandler(this.UpdToolStripMenuItem_Click);
            // 
            // SwitchingTablesBox
            // 
            this.SwitchingTablesBox.AutoResize = false;
            this.SwitchingTablesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SwitchingTablesBox.Depth = 0;
            this.SwitchingTablesBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SwitchingTablesBox.DropDownHeight = 118;
            this.SwitchingTablesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SwitchingTablesBox.DropDownWidth = 121;
            this.SwitchingTablesBox.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchingTablesBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SwitchingTablesBox.FormattingEnabled = true;
            this.SwitchingTablesBox.IntegralHeight = false;
            this.SwitchingTablesBox.ItemHeight = 29;
            this.SwitchingTablesBox.Location = new System.Drawing.Point(6, 156);
            this.SwitchingTablesBox.MaxDropDownItems = 4;
            this.SwitchingTablesBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SwitchingTablesBox.Name = "SwitchingTablesBox";
            this.SwitchingTablesBox.Size = new System.Drawing.Size(153, 35);
            this.SwitchingTablesBox.StartIndex = 0;
            this.SwitchingTablesBox.TabIndex = 9;
            this.SwitchingTablesBox.UseAccent = false;
            this.SwitchingTablesBox.UseTallSize = false;
            this.SwitchingTablesBox.SelectedIndexChanged += new System.EventHandler(this.SwitchingTablesBox_SelectedIndexChanged);
            // 
            // cmbPickupPoints
            // 
            this.cmbPickupPoints.AutoResize = false;
            this.cmbPickupPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPickupPoints.Depth = 0;
            this.cmbPickupPoints.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPickupPoints.DropDownHeight = 118;
            this.cmbPickupPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPickupPoints.DropDownWidth = 121;
            this.cmbPickupPoints.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPickupPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPickupPoints.FormattingEnabled = true;
            this.cmbPickupPoints.IntegralHeight = false;
            this.cmbPickupPoints.ItemHeight = 29;
            this.cmbPickupPoints.Location = new System.Drawing.Point(379, 156);
            this.cmbPickupPoints.MaxDropDownItems = 4;
            this.cmbPickupPoints.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPickupPoints.Name = "cmbPickupPoints";
            this.cmbPickupPoints.Size = new System.Drawing.Size(186, 35);
            this.cmbPickupPoints.StartIndex = 0;
            this.cmbPickupPoints.TabIndex = 10;
            this.cmbPickupPoints.UseAccent = false;
            this.cmbPickupPoints.UseTallSize = false;
            this.cmbPickupPoints.SelectedIndexChanged += new System.EventHandler(this.cmbPickupPoints_SelectedIndexChanged);
            // 
            // cmbStatusOrders
            // 
            this.cmbStatusOrders.AutoResize = false;
            this.cmbStatusOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbStatusOrders.Depth = 0;
            this.cmbStatusOrders.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatusOrders.DropDownHeight = 118;
            this.cmbStatusOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusOrders.DropDownWidth = 121;
            this.cmbStatusOrders.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold);
            this.cmbStatusOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbStatusOrders.FormattingEnabled = true;
            this.cmbStatusOrders.IntegralHeight = false;
            this.cmbStatusOrders.ItemHeight = 29;
            this.cmbStatusOrders.Location = new System.Drawing.Point(571, 156);
            this.cmbStatusOrders.MaxDropDownItems = 4;
            this.cmbStatusOrders.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbStatusOrders.Name = "cmbStatusOrders";
            this.cmbStatusOrders.Size = new System.Drawing.Size(195, 35);
            this.cmbStatusOrders.StartIndex = 0;
            this.cmbStatusOrders.TabIndex = 11;
            this.cmbStatusOrders.UseAccent = false;
            this.cmbStatusOrders.UseTallSize = false;
            this.cmbStatusOrders.SelectedIndexChanged += new System.EventHandler(this.cmbStatusOrders_SelectedIndexChanged);
            // 
            // cmbSortTable
            // 
            this.cmbSortTable.AutoResize = false;
            this.cmbSortTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSortTable.Depth = 0;
            this.cmbSortTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSortTable.DropDownHeight = 118;
            this.cmbSortTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortTable.DropDownWidth = 121;
            this.cmbSortTable.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSortTable.FormattingEnabled = true;
            this.cmbSortTable.IntegralHeight = false;
            this.cmbSortTable.ItemHeight = 29;
            this.cmbSortTable.Location = new System.Drawing.Point(182, 156);
            this.cmbSortTable.MaxDropDownItems = 4;
            this.cmbSortTable.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSortTable.Name = "cmbSortTable";
            this.cmbSortTable.Size = new System.Drawing.Size(191, 35);
            this.cmbSortTable.StartIndex = 0;
            this.cmbSortTable.TabIndex = 12;
            this.cmbSortTable.UseAccent = false;
            this.cmbSortTable.UseTallSize = false;
            this.cmbSortTable.SelectedIndexChanged += new System.EventHandler(this.cmbSortTable_SelectedIndexChanged);

            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Depth = 0;
            this.FilterLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FilterLabel.Location = new System.Drawing.Point(382, 128);
            this.FilterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(93, 19);
            this.FilterLabel.TabIndex = 13;
            this.FilterLabel.Text = "Фильтрация";
 
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Depth = 0;
            this.SortLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SortLabel.Location = new System.Drawing.Point(185, 128);
            this.SortLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(91, 19);
            this.SortLabel.TabIndex = 14;
            this.SortLabel.Text = "Сортировка";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            // 
            // ThemeSwitcher
            // 
            this.ThemeSwitcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeSwitcher.BackColor = System.Drawing.SystemColors.ControlText;
            this.ThemeSwitcher.Depth = 0;
            this.ThemeSwitcher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ThemeSwitcher.Location = new System.Drawing.Point(936, 64);
            this.ThemeSwitcher.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeSwitcher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ThemeSwitcher.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeSwitcher.Name = "ThemeSwitcher";
            this.ThemeSwitcher.Ripple = true;
            this.ThemeSwitcher.Size = new System.Drawing.Size(58, 29);
            this.ThemeSwitcher.TabIndex = 17;
            this.ThemeSwitcher.UseVisualStyleBackColor = false;
            this.ThemeSwitcher.CheckedChanged += new System.EventHandler(this.ThemeSwitcher_CheckedChanged);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Depth = 0;
            this.TableLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TableLabel.Location = new System.Drawing.Point(9, 128);
            this.TableLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(132, 19);
            this.TableLabel.TabIndex = 18;
            this.TableLabel.Text = "Выбрать таблицу";
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Depth = 0;
            this.ThemeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ThemeLabel.Location = new System.Drawing.Point(830, 67);
            this.ThemeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(106, 19);
            this.ThemeLabel.TabIndex = 19;
            this.ThemeLabel.Text = "Сменить тему";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.DarkCyan;
            this.MenuBar.Depth = 0;
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBar.ForeColor = System.Drawing.Color.DarkCyan;
            this.MenuBar.Location = new System.Drawing.Point(3, 90);
            this.MenuBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(980, 5);
            this.MenuBar.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 515);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.ThemeSwitcher);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.cmbSortTable);
            this.Controls.Add(this.cmbStatusOrders);
            this.Controls.Add(this.cmbPickupPoints);
            this.Controls.Add(this.SwitchingTablesBox);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.ToolbarMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryHUB - Панель управления";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ToolbarMenuStrip.ResumeLayout(false);
            this.ToolbarMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.ToolStripMenuItem RecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ToolbarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UpdToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MaterialSkin.Controls.MaterialComboBox SwitchingTablesBox;
        private MaterialSkin.Controls.MaterialComboBox cmbPickupPoints;
        private MaterialSkin.Controls.MaterialComboBox cmbStatusOrders;
        private MaterialSkin.Controls.MaterialComboBox cmbSortTable;
        private MaterialSkin.Controls.MaterialLabel FilterLabel;
        private MaterialSkin.Controls.MaterialLabel SortLabel;
       // private DeliveryHUBDataSet deliveryHUBDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
       // private DeliveryHUBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private MaterialSkin.Controls.MaterialSwitch ThemeSwitcher;
        private MaterialSkin.Controls.MaterialLabel TableLabel;
        private MaterialSkin.Controls.MaterialLabel ThemeLabel;
        private MaterialSkin.Controls.MaterialProgressBar MenuBar;
    }
}