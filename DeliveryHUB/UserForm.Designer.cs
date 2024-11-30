namespace DeliveryHUB
{
    partial class UserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.SortLabel = new System.Windows.Forms.Label();
            this.ToolbarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemeSwitcher = new MaterialSkin.Controls.MaterialSwitch();
            this.cmbSortTable = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbStatusOrders = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbPickupPoints = new MaterialSkin.Controls.MaterialComboBox();
            this.FilterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ThemeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MenuBar = new MaterialSkin.Controls.MaterialProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.ToolbarMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrders.Location = new System.Drawing.Point(5, 208);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrders.RowHeadersWidth = 35;
            this.dataGridViewOrders.Size = new System.Drawing.Size(976, 284);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(549, 73);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(67, 13);
            this.SortLabel.TabIndex = 10;
            this.SortLabel.Text = "Сортировка";
            // 
            // ToolbarMenuStrip
            // 
            this.ToolbarMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolbarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolStripMenuItem,
            this.UpdToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.ToolbarMenuStrip.Location = new System.Drawing.Point(3, 64);
            this.ToolbarMenuStrip.Name = "ToolbarMenuStrip";
            this.ToolbarMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.ToolbarMenuStrip.Size = new System.Drawing.Size(980, 26);
            this.ToolbarMenuStrip.TabIndex = 11;
            this.ToolbarMenuStrip.Text = "menuStrip2";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.SearchToolStripMenuItem.Text = "Поиск";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // UpdToolStripMenuItem
            // 
            this.UpdToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdToolStripMenuItem.Name = "UpdToolStripMenuItem";
            this.UpdToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.UpdToolStripMenuItem.Text = "Обновить";
            this.UpdToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ThemeSwitcher
            // 
            this.ThemeSwitcher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemeSwitcher.Depth = 0;
            this.ThemeSwitcher.Location = new System.Drawing.Point(936, 64);
            this.ThemeSwitcher.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeSwitcher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ThemeSwitcher.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeSwitcher.Name = "ThemeSwitcher";
            this.ThemeSwitcher.Ripple = true;
            this.ThemeSwitcher.Size = new System.Drawing.Size(58, 29);
            this.ThemeSwitcher.TabIndex = 17;
            this.ThemeSwitcher.UseVisualStyleBackColor = true;
            this.ThemeSwitcher.CheckedChanged += new System.EventHandler(this.ThemeSwitcher_CheckedChanged);
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
            this.cmbSortTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSortTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSortTable.FormattingEnabled = true;
            this.cmbSortTable.IntegralHeight = false;
            this.cmbSortTable.ItemHeight = 29;
            this.cmbSortTable.Location = new System.Drawing.Point(8, 167);
            this.cmbSortTable.MaxDropDownItems = 4;
            this.cmbSortTable.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSortTable.Name = "cmbSortTable";
            this.cmbSortTable.Size = new System.Drawing.Size(191, 35);
            this.cmbSortTable.StartIndex = 0;
            this.cmbSortTable.TabIndex = 19;
            this.cmbSortTable.UseAccent = false;
            this.cmbSortTable.UseTallSize = false;
            this.cmbSortTable.SelectedIndexChanged += new System.EventHandler(this.cmbSortTable_SelectedIndexChanged);
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
            this.cmbStatusOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbStatusOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbStatusOrders.FormattingEnabled = true;
            this.cmbStatusOrders.IntegralHeight = false;
            this.cmbStatusOrders.ItemHeight = 29;
            this.cmbStatusOrders.Location = new System.Drawing.Point(400, 167);
            this.cmbStatusOrders.MaxDropDownItems = 4;
            this.cmbStatusOrders.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbStatusOrders.Name = "cmbStatusOrders";
            this.cmbStatusOrders.Size = new System.Drawing.Size(195, 35);
            this.cmbStatusOrders.StartIndex = 0;
            this.cmbStatusOrders.TabIndex = 20;
            this.cmbStatusOrders.UseAccent = false;
            this.cmbStatusOrders.UseTallSize = false;
            this.cmbStatusOrders.SelectedIndexChanged += new System.EventHandler(this.cmbStatusOrders_SelectedIndexChanged);
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
            this.cmbPickupPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPickupPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPickupPoints.FormattingEnabled = true;
            this.cmbPickupPoints.IntegralHeight = false;
            this.cmbPickupPoints.ItemHeight = 29;
            this.cmbPickupPoints.Location = new System.Drawing.Point(208, 167);
            this.cmbPickupPoints.MaxDropDownItems = 4;
            this.cmbPickupPoints.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPickupPoints.Name = "cmbPickupPoints";
            this.cmbPickupPoints.Size = new System.Drawing.Size(186, 35);
            this.cmbPickupPoints.StartIndex = 0;
            this.cmbPickupPoints.TabIndex = 21;
            this.cmbPickupPoints.UseAccent = false;
            this.cmbPickupPoints.UseTallSize = false;
            this.cmbPickupPoints.SelectedIndexChanged += new System.EventHandler(this.cmbPickupPoints_SelectedIndexChanged);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Depth = 0;
            this.FilterLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FilterLabel.Location = new System.Drawing.Point(212, 144);
            this.FilterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(93, 19);
            this.FilterLabel.TabIndex = 22;
            this.FilterLabel.Text = "Фильтрация";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(8, 144);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Сортировка";
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
            this.ThemeLabel.TabIndex = 24;
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
            this.MenuBar.TabIndex = 25;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 507);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.cmbPickupPoints);
            this.Controls.Add(this.cmbStatusOrders);
            this.Controls.Add(this.cmbSortTable);
            this.Controls.Add(this.ThemeSwitcher);
            this.Controls.Add(this.ToolbarMenuStrip);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "UserForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ToolbarMenuStrip.ResumeLayout(false);
            this.ToolbarMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.MenuStrip ToolbarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialSwitch ThemeSwitcher;
        private MaterialSkin.Controls.MaterialComboBox cmbSortTable;
        private MaterialSkin.Controls.MaterialComboBox cmbStatusOrders;
        private MaterialSkin.Controls.MaterialComboBox cmbPickupPoints;
        private MaterialSkin.Controls.MaterialLabel FilterLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel ThemeLabel;
        private MaterialSkin.Controls.MaterialProgressBar MenuBar;
    }
}