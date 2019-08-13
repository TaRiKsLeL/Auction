namespace Auction_Kostishin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.progectNameLabel = new System.Windows.Forms.Label();
            this.LotsDataGrid = new System.Windows.Forms.DataGridView();
            this.logInBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lotTitleTextBox = new System.Windows.Forms.TextBox();
            this.lotDescrTextBox = new System.Windows.Forms.TextBox();
            this.lotMinPriceTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addToLots = new System.Windows.Forms.Button();
            this.titleLotLabel = new System.Windows.Forms.Label();
            this.adminGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.offeredPrice = new System.Windows.Forms.TextBox();
            this.makeOfferBtn = new System.Windows.Forms.Button();
            this.lotSelectedLabel = new System.Windows.Forms.Label();
            this.plzLogIn = new System.Windows.Forms.Label();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.offersDataGrid = new System.Windows.Forms.DataGridView();
            this.offersDataGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LotsDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.adminGroupBox.SuspendLayout();
            this.userGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offersDataGrid)).BeginInit();
            this.offersDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // progectNameLabel
            // 
            this.progectNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progectNameLabel.AutoSize = true;
            this.progectNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.progectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progectNameLabel.Location = new System.Drawing.Point(383, 23);
            this.progectNameLabel.Name = "progectNameLabel";
            this.progectNameLabel.Size = new System.Drawing.Size(165, 38);
            this.progectNameLabel.TabIndex = 0;
            this.progectNameLabel.Text = "АУКЦІОН";
            this.progectNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LotsDataGrid
            // 
            this.LotsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LotsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.LotsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LotsDataGrid.GridColor = System.Drawing.Color.DarkGray;
            this.LotsDataGrid.Location = new System.Drawing.Point(26, 115);
            this.LotsDataGrid.Name = "LotsDataGrid";
            this.LotsDataGrid.RowTemplate.Height = 24;
            this.LotsDataGrid.Size = new System.Drawing.Size(608, 268);
            this.LotsDataGrid.TabIndex = 1;
            this.LotsDataGrid.Visible = false;
            this.LotsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LotsDataGrid_CellContentClick);
            // 
            // logInBtn
            // 
            this.logInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInBtn.BackColor = System.Drawing.Color.Transparent;
            this.logInBtn.FlatAppearance.BorderSize = 0;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInBtn.ForeColor = System.Drawing.Color.White;
            this.logInBtn.Location = new System.Drawing.Point(729, 23);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(217, 39);
            this.logInBtn.TabIndex = 2;
            this.logInBtn.Text = "Вхід/Реєстрація";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logInBtn);
            this.panel1.Controls.Add(this.progectNameLabel);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 89);
            this.panel1.TabIndex = 3;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(782, 23);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(145, 39);
            this.logOutBtn.TabIndex = 5;
            this.logOutBtn.Text = "Вийти";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Visible = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // lotTitleTextBox
            // 
            this.lotTitleTextBox.BackColor = System.Drawing.Color.White;
            this.lotTitleTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.lotTitleTextBox.Location = new System.Drawing.Point(10, 52);
            this.lotTitleTextBox.Name = "lotTitleTextBox";
            this.lotTitleTextBox.Size = new System.Drawing.Size(100, 22);
            this.lotTitleTextBox.TabIndex = 4;
            // 
            // lotDescrTextBox
            // 
            this.lotDescrTextBox.BackColor = System.Drawing.Color.White;
            this.lotDescrTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.lotDescrTextBox.Location = new System.Drawing.Point(132, 52);
            this.lotDescrTextBox.Name = "lotDescrTextBox";
            this.lotDescrTextBox.Size = new System.Drawing.Size(188, 22);
            this.lotDescrTextBox.TabIndex = 5;
            // 
            // lotMinPriceTextBox
            // 
            this.lotMinPriceTextBox.BackColor = System.Drawing.Color.White;
            this.lotMinPriceTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.lotMinPriceTextBox.Location = new System.Drawing.Point(350, 52);
            this.lotMinPriceTextBox.Name = "lotMinPriceTextBox";
            this.lotMinPriceTextBox.Size = new System.Drawing.Size(87, 22);
            this.lotMinPriceTextBox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(483, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // addToLots
            // 
            this.addToLots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.addToLots.FlatAppearance.BorderSize = 0;
            this.addToLots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToLots.ForeColor = System.Drawing.Color.White;
            this.addToLots.Location = new System.Drawing.Point(800, 32);
            this.addToLots.Name = "addToLots";
            this.addToLots.Size = new System.Drawing.Size(73, 42);
            this.addToLots.TabIndex = 9;
            this.addToLots.Text = "Внести";
            this.addToLots.UseVisualStyleBackColor = false;
            this.addToLots.Click += new System.EventHandler(this.addToLots_Click);
            // 
            // titleLotLabel
            // 
            this.titleLotLabel.AutoSize = true;
            this.titleLotLabel.Location = new System.Drawing.Point(10, 32);
            this.titleLotLabel.Name = "titleLotLabel";
            this.titleLotLabel.Size = new System.Drawing.Size(48, 17);
            this.titleLotLabel.TabIndex = 10;
            this.titleLotLabel.Text = "Назва";
            // 
            // adminGroupBox
            // 
            this.adminGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminGroupBox.Controls.Add(this.label4);
            this.adminGroupBox.Controls.Add(this.label3);
            this.adminGroupBox.Controls.Add(this.label2);
            this.adminGroupBox.Controls.Add(this.lotTitleTextBox);
            this.adminGroupBox.Controls.Add(this.titleLotLabel);
            this.adminGroupBox.Controls.Add(this.lotDescrTextBox);
            this.adminGroupBox.Controls.Add(this.addToLots);
            this.adminGroupBox.Controls.Add(this.lotMinPriceTextBox);
            this.adminGroupBox.Controls.Add(this.dateTimePicker1);
            this.adminGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.adminGroupBox.Location = new System.Drawing.Point(26, 390);
            this.adminGroupBox.Name = "adminGroupBox";
            this.adminGroupBox.Size = new System.Drawing.Size(899, 100);
            this.adminGroupBox.TabIndex = 11;
            this.adminGroupBox.TabStop = false;
            this.adminGroupBox.Text = "Внести новий лот";
            this.adminGroupBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дійсний по дату";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Мінімальна ціна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Опис";
            // 
            // userGroupBox
            // 
            this.userGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userGroupBox.Controls.Add(this.label6);
            this.userGroupBox.Controls.Add(this.offeredPrice);
            this.userGroupBox.Controls.Add(this.makeOfferBtn);
            this.userGroupBox.Controls.Add(this.lotSelectedLabel);
            this.userGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.userGroupBox.Location = new System.Drawing.Point(26, 399);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(899, 83);
            this.userGroupBox.TabIndex = 12;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "Зробити ставку";
            this.userGroupBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(533, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ваша ціна";
            // 
            // offeredPrice
            // 
            this.offeredPrice.BackColor = System.Drawing.Color.White;
            this.offeredPrice.ForeColor = System.Drawing.Color.DimGray;
            this.offeredPrice.Location = new System.Drawing.Point(536, 41);
            this.offeredPrice.Name = "offeredPrice";
            this.offeredPrice.Size = new System.Drawing.Size(87, 22);
            this.offeredPrice.TabIndex = 14;
            // 
            // makeOfferBtn
            // 
            this.makeOfferBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.makeOfferBtn.FlatAppearance.BorderSize = 0;
            this.makeOfferBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeOfferBtn.ForeColor = System.Drawing.Color.White;
            this.makeOfferBtn.Location = new System.Drawing.Point(741, 21);
            this.makeOfferBtn.Name = "makeOfferBtn";
            this.makeOfferBtn.Size = new System.Drawing.Size(132, 47);
            this.makeOfferBtn.TabIndex = 14;
            this.makeOfferBtn.Text = "Зробити ставку";
            this.makeOfferBtn.UseVisualStyleBackColor = false;
            this.makeOfferBtn.Click += new System.EventHandler(this.makeOfferBtn_Click);
            // 
            // lotSelectedLabel
            // 
            this.lotSelectedLabel.AutoSize = true;
            this.lotSelectedLabel.BackColor = System.Drawing.Color.Transparent;
            this.lotSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lotSelectedLabel.ForeColor = System.Drawing.Color.DimGray;
            this.lotSelectedLabel.Location = new System.Drawing.Point(26, 37);
            this.lotSelectedLabel.Name = "lotSelectedLabel";
            this.lotSelectedLabel.Size = new System.Drawing.Size(126, 20);
            this.lotSelectedLabel.TabIndex = 14;
            this.lotSelectedLabel.Text = "Вибраний лот";
            // 
            // plzLogIn
            // 
            this.plzLogIn.AutoSize = true;
            this.plzLogIn.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plzLogIn.ForeColor = System.Drawing.Color.SlateGray;
            this.plzLogIn.Location = new System.Drawing.Point(62, 164);
            this.plzLogIn.Name = "plzLogIn";
            this.plzLogIn.Size = new System.Drawing.Size(572, 44);
            this.plzLogIn.TabIndex = 12;
            this.plzLogIn.Text = "АВТОРИЗУЙТЕСЬ, БУДЬ ЛАСКА!";
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupBox.Controls.Add(this.filterTextBox);
            this.filterGroupBox.Controls.Add(this.comboBox1);
            this.filterGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.filterGroupBox.Location = new System.Drawing.Point(654, 111);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(271, 83);
            this.filterGroupBox.TabIndex = 13;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фільтр даних";
            this.filterGroupBox.Visible = false;
            // 
            // filterTextBox
            // 
            this.filterTextBox.BackColor = System.Drawing.Color.White;
            this.filterTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.filterTextBox.Location = new System.Drawing.Point(133, 32);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(132, 22);
            this.filterTextBox.TabIndex = 16;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Title",
            "Description",
            "Min_Price"});
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // offersDataGrid
            // 
            this.offersDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.offersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offersDataGrid.GridColor = System.Drawing.Color.LightGray;
            this.offersDataGrid.Location = new System.Drawing.Point(13, 53);
            this.offersDataGrid.Name = "offersDataGrid";
            this.offersDataGrid.RowTemplate.Height = 24;
            this.offersDataGrid.Size = new System.Drawing.Size(246, 201);
            this.offersDataGrid.TabIndex = 14;
            // 
            // offersDataGroupBox
            // 
            this.offersDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.offersDataGroupBox.Controls.Add(this.comboBox2);
            this.offersDataGroupBox.Controls.Add(this.offersDataGrid);
            this.offersDataGroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.offersDataGroupBox.Location = new System.Drawing.Point(653, 111);
            this.offersDataGroupBox.Name = "offersDataGroupBox";
            this.offersDataGroupBox.Size = new System.Drawing.Size(272, 269);
            this.offersDataGroupBox.TabIndex = 6;
            this.offersDataGroupBox.TabStop = false;
            this.offersDataGroupBox.Text = "Ставки";
            this.offersDataGroupBox.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Всі ставки",
            "Закінчені"});
            this.comboBox2.Location = new System.Drawing.Point(6, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(966, 523);
            this.Controls.Add(this.offersDataGroupBox);
            this.Controls.Add(this.LotsDataGrid);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.userGroupBox);
            this.Controls.Add(this.plzLogIn);
            this.Controls.Add(this.adminGroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Аукціон";
            ((System.ComponentModel.ISupportInitialize)(this.LotsDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.adminGroupBox.ResumeLayout(false);
            this.adminGroupBox.PerformLayout();
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offersDataGrid)).EndInit();
            this.offersDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label progectNameLabel;
        private System.Windows.Forms.DataGridView LotsDataGrid;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lotTitleTextBox;
        private System.Windows.Forms.TextBox lotDescrTextBox;
        private System.Windows.Forms.TextBox lotMinPriceTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addToLots;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label titleLotLabel;
        private System.Windows.Forms.GroupBox adminGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.Button makeOfferBtn;
        private System.Windows.Forms.Label lotSelectedLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox offeredPrice;
        private System.Windows.Forms.Label plzLogIn;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView offersDataGrid;
        private System.Windows.Forms.GroupBox offersDataGroupBox;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

