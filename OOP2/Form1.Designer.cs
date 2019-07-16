namespace OOP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_BankAccount = new System.Windows.Forms.TextBox();
            this.groupBox_IsSmsEnabled = new System.Windows.Forms.GroupBox();
            this.radioButton_SmsFalse = new System.Windows.Forms.RadioButton();
            this.radioButton_SmsTrue = new System.Windows.Forms.RadioButton();
            this.comboBox_typeOfBankAccount = new System.Windows.Forms.ComboBox();
            this.trackBar_Balance = new System.Windows.Forms.TrackBar();
            this.label_BalanceValue = new System.Windows.Forms.Label();
            this.checkBox_InternetBanking = new System.Windows.Forms.CheckBox();
            this.checkBox_3DSecure = new System.Windows.Forms.CheckBox();
            this.label_BancAccount = new System.Windows.Forms.Label();
            this.label_Owner = new System.Windows.Forms.Label();
            this.label_InputNumberOfBankAccount = new System.Windows.Forms.Label();
            this.label_TypeOfBankAccount = new System.Windows.Forms.Label();
            this.label_OwnerName = new System.Windows.Forms.Label();
            this.textBox_OwnerName = new System.Windows.Forms.TextBox();
            this.label_OwnerSecondName = new System.Windows.Forms.Label();
            this.textBox_OwnerSecondName = new System.Windows.Forms.TextBox();
            this.label_OwnerThirdName = new System.Windows.Forms.Label();
            this.textBox_OwnerThridName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label_DateOfBirth = new System.Windows.Forms.Label();
            this.domainUpDown_Gender = new System.Windows.Forms.DomainUpDown();
            this.label_OwnerGender = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_SaveXML = new System.Windows.Forms.Button();
            this.button_ReadXML = new System.Windows.Forms.Button();
            this.richTextBox_toOutput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepositTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateOfOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox_IsSmsEnabled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Balance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_BankAccount
            // 
            this.textBox_BankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BankAccount.Location = new System.Drawing.Point(12, 126);
            this.textBox_BankAccount.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_BankAccount.MaxLength = 10;
            this.textBox_BankAccount.Multiline = true;
            this.textBox_BankAccount.Name = "textBox_BankAccount";
            this.textBox_BankAccount.Size = new System.Drawing.Size(201, 26);
            this.textBox_BankAccount.TabIndex = 0;
            // 
            // groupBox_IsSmsEnabled
            // 
            this.groupBox_IsSmsEnabled.Controls.Add(this.radioButton_SmsFalse);
            this.groupBox_IsSmsEnabled.Controls.Add(this.radioButton_SmsTrue);
            this.groupBox_IsSmsEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_IsSmsEnabled.Location = new System.Drawing.Point(12, 162);
            this.groupBox_IsSmsEnabled.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox_IsSmsEnabled.Name = "groupBox_IsSmsEnabled";
            this.groupBox_IsSmsEnabled.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox_IsSmsEnabled.Size = new System.Drawing.Size(201, 66);
            this.groupBox_IsSmsEnabled.TabIndex = 1;
            this.groupBox_IsSmsEnabled.TabStop = false;
            this.groupBox_IsSmsEnabled.Text = "SMS-оповещения";
            // 
            // radioButton_SmsFalse
            // 
            this.radioButton_SmsFalse.AutoSize = true;
            this.radioButton_SmsFalse.Location = new System.Drawing.Point(65, 31);
            this.radioButton_SmsFalse.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton_SmsFalse.Name = "radioButton_SmsFalse";
            this.radioButton_SmsFalse.Size = new System.Drawing.Size(51, 20);
            this.radioButton_SmsFalse.TabIndex = 1;
            this.radioButton_SmsFalse.Text = "Нет";
            this.radioButton_SmsFalse.UseVisualStyleBackColor = true;
            this.radioButton_SmsFalse.CheckedChanged += new System.EventHandler(this.radioButton_SmsFalse_CheckedChanged);
            // 
            // radioButton_SmsTrue
            // 
            this.radioButton_SmsTrue.AutoSize = true;
            this.radioButton_SmsTrue.Checked = true;
            this.radioButton_SmsTrue.Location = new System.Drawing.Point(10, 31);
            this.radioButton_SmsTrue.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton_SmsTrue.Name = "radioButton_SmsTrue";
            this.radioButton_SmsTrue.Size = new System.Drawing.Size(43, 20);
            this.radioButton_SmsTrue.TabIndex = 0;
            this.radioButton_SmsTrue.TabStop = true;
            this.radioButton_SmsTrue.Text = "Да";
            this.radioButton_SmsTrue.UseVisualStyleBackColor = true;
            this.radioButton_SmsTrue.CheckedChanged += new System.EventHandler(this.radioButton_SmsTrue_CheckedChanged);
            // 
            // comboBox_typeOfBankAccount
            // 
            this.comboBox_typeOfBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typeOfBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_typeOfBankAccount.FormattingEnabled = true;
            this.comboBox_typeOfBankAccount.Items.AddRange(new object[] {
            "Долгосрочный",
            "Краткосрочный"});
            this.comboBox_typeOfBankAccount.Location = new System.Drawing.Point(15, 255);
            this.comboBox_typeOfBankAccount.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_typeOfBankAccount.Name = "comboBox_typeOfBankAccount";
            this.comboBox_typeOfBankAccount.Size = new System.Drawing.Size(199, 28);
            this.comboBox_typeOfBankAccount.TabIndex = 3;
            this.comboBox_typeOfBankAccount.SelectedIndexChanged += new System.EventHandler(this.comboBox_typeOfBankAccount_SelectedIndexChanged);
            // 
            // trackBar_Balance
            // 
            this.trackBar_Balance.Location = new System.Drawing.Point(7, 333);
            this.trackBar_Balance.Margin = new System.Windows.Forms.Padding(5);
            this.trackBar_Balance.Maximum = 150000;
            this.trackBar_Balance.Name = "trackBar_Balance";
            this.trackBar_Balance.Size = new System.Drawing.Size(200, 45);
            this.trackBar_Balance.TabIndex = 3;
            this.trackBar_Balance.Scroll += new System.EventHandler(this.TrackBar_Balance_Scroll);
            // 
            // label_BalanceValue
            // 
            this.label_BalanceValue.AutoSize = true;
            this.label_BalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BalanceValue.Location = new System.Drawing.Point(13, 308);
            this.label_BalanceValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_BalanceValue.Name = "label_BalanceValue";
            this.label_BalanceValue.Size = new System.Drawing.Size(75, 18);
            this.label_BalanceValue.TabIndex = 4;
            this.label_BalanceValue.Text = "Баланс: 0";
            // 
            // checkBox_InternetBanking
            // 
            this.checkBox_InternetBanking.AutoSize = true;
            this.checkBox_InternetBanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_InternetBanking.Location = new System.Drawing.Point(17, 386);
            this.checkBox_InternetBanking.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox_InternetBanking.Name = "checkBox_InternetBanking";
            this.checkBox_InternetBanking.Size = new System.Drawing.Size(148, 20);
            this.checkBox_InternetBanking.TabIndex = 5;
            this.checkBox_InternetBanking.Text = "Интернет-банкинг";
            this.checkBox_InternetBanking.UseVisualStyleBackColor = true;
            // 
            // checkBox_3DSecure
            // 
            this.checkBox_3DSecure.AutoSize = true;
            this.checkBox_3DSecure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_3DSecure.Location = new System.Drawing.Point(17, 417);
            this.checkBox_3DSecure.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox_3DSecure.Name = "checkBox_3DSecure";
            this.checkBox_3DSecure.Size = new System.Drawing.Size(87, 20);
            this.checkBox_3DSecure.TabIndex = 6;
            this.checkBox_3DSecure.Text = "3DSecure";
            this.checkBox_3DSecure.UseVisualStyleBackColor = true;
            // 
            // label_BancAccount
            // 
            this.label_BancAccount.AutoSize = true;
            this.label_BancAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_BancAccount.Location = new System.Drawing.Point(8, 74);
            this.label_BancAccount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_BancAccount.Name = "label_BancAccount";
            this.label_BancAccount.Size = new System.Drawing.Size(51, 20);
            this.label_BancAccount.TabIndex = 7;
            this.label_BancAccount.Text = "Счет";
            this.label_BancAccount.Click += new System.EventHandler(this.label_BancAccount_Click);
            // 
            // label_Owner
            // 
            this.label_Owner.AutoSize = true;
            this.label_Owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Owner.Location = new System.Drawing.Point(245, 74);
            this.label_Owner.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Owner.Name = "label_Owner";
            this.label_Owner.Size = new System.Drawing.Size(95, 20);
            this.label_Owner.TabIndex = 8;
            this.label_Owner.Text = "Владелец";
            // 
            // label_InputNumberOfBankAccount
            // 
            this.label_InputNumberOfBankAccount.AutoSize = true;
            this.label_InputNumberOfBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_InputNumberOfBankAccount.Location = new System.Drawing.Point(9, 104);
            this.label_InputNumberOfBankAccount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_InputNumberOfBankAccount.Name = "label_InputNumberOfBankAccount";
            this.label_InputNumberOfBankAccount.Size = new System.Drawing.Size(95, 16);
            this.label_InputNumberOfBankAccount.TabIndex = 9;
            this.label_InputNumberOfBankAccount.Text = "Номер счета:";
            // 
            // label_TypeOfBankAccount
            // 
            this.label_TypeOfBankAccount.AutoSize = true;
            this.label_TypeOfBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TypeOfBankAccount.Location = new System.Drawing.Point(19, 233);
            this.label_TypeOfBankAccount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_TypeOfBankAccount.Name = "label_TypeOfBankAccount";
            this.label_TypeOfBankAccount.Size = new System.Drawing.Size(77, 16);
            this.label_TypeOfBankAccount.TabIndex = 10;
            this.label_TypeOfBankAccount.Text = "Тип счета:";
            this.label_TypeOfBankAccount.Click += new System.EventHandler(this.label_TypeOfBankAccount_Click);
            // 
            // label_OwnerName
            // 
            this.label_OwnerName.AutoSize = true;
            this.label_OwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OwnerName.Location = new System.Drawing.Point(246, 104);
            this.label_OwnerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_OwnerName.Name = "label_OwnerName";
            this.label_OwnerName.Size = new System.Drawing.Size(37, 16);
            this.label_OwnerName.TabIndex = 12;
            this.label_OwnerName.Text = "Имя:";
            // 
            // textBox_OwnerName
            // 
            this.textBox_OwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_OwnerName.Location = new System.Drawing.Point(249, 126);
            this.textBox_OwnerName.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_OwnerName.MaxLength = 15;
            this.textBox_OwnerName.Multiline = true;
            this.textBox_OwnerName.Name = "textBox_OwnerName";
            this.textBox_OwnerName.Size = new System.Drawing.Size(201, 26);
            this.textBox_OwnerName.TabIndex = 11;
            // 
            // label_OwnerSecondName
            // 
            this.label_OwnerSecondName.AutoSize = true;
            this.label_OwnerSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OwnerSecondName.Location = new System.Drawing.Point(246, 162);
            this.label_OwnerSecondName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_OwnerSecondName.Name = "label_OwnerSecondName";
            this.label_OwnerSecondName.Size = new System.Drawing.Size(70, 16);
            this.label_OwnerSecondName.TabIndex = 14;
            this.label_OwnerSecondName.Text = "Фамилия:";
            // 
            // textBox_OwnerSecondName
            // 
            this.textBox_OwnerSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_OwnerSecondName.Location = new System.Drawing.Point(249, 184);
            this.textBox_OwnerSecondName.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_OwnerSecondName.MaxLength = 15;
            this.textBox_OwnerSecondName.Multiline = true;
            this.textBox_OwnerSecondName.Name = "textBox_OwnerSecondName";
            this.textBox_OwnerSecondName.Size = new System.Drawing.Size(201, 26);
            this.textBox_OwnerSecondName.TabIndex = 13;
            // 
            // label_OwnerThirdName
            // 
            this.label_OwnerThirdName.AutoSize = true;
            this.label_OwnerThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OwnerThirdName.Location = new System.Drawing.Point(246, 215);
            this.label_OwnerThirdName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_OwnerThirdName.Name = "label_OwnerThirdName";
            this.label_OwnerThirdName.Size = new System.Drawing.Size(74, 16);
            this.label_OwnerThirdName.TabIndex = 16;
            this.label_OwnerThirdName.Text = "Отчество:";
            // 
            // textBox_OwnerThridName
            // 
            this.textBox_OwnerThridName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_OwnerThridName.Location = new System.Drawing.Point(249, 237);
            this.textBox_OwnerThridName.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_OwnerThridName.MaxLength = 15;
            this.textBox_OwnerThridName.Multiline = true;
            this.textBox_OwnerThridName.Name = "textBox_OwnerThridName";
            this.textBox_OwnerThridName.Size = new System.Drawing.Size(201, 26);
            this.textBox_OwnerThridName.TabIndex = 15;
            // 
            // dateTimePicker_DateOfBirth
            // 
            this.dateTimePicker_DateOfBirth.Location = new System.Drawing.Point(249, 301);
            this.dateTimePicker_DateOfBirth.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_DateOfBirth.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Size = new System.Drawing.Size(201, 26);
            this.dateTimePicker_DateOfBirth.TabIndex = 17;
            this.dateTimePicker_DateOfBirth.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label_DateOfBirth
            // 
            this.label_DateOfBirth.AutoSize = true;
            this.label_DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_DateOfBirth.Location = new System.Drawing.Point(248, 281);
            this.label_DateOfBirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_DateOfBirth.Name = "label_DateOfBirth";
            this.label_DateOfBirth.Size = new System.Drawing.Size(110, 16);
            this.label_DateOfBirth.TabIndex = 18;
            this.label_DateOfBirth.Text = "Дата рождения:";
            // 
            // domainUpDown_Gender
            // 
            this.domainUpDown_Gender.Items.Add("Мужской");
            this.domainUpDown_Gender.Items.Add("Женский");
            this.domainUpDown_Gender.Location = new System.Drawing.Point(249, 362);
            this.domainUpDown_Gender.Name = "domainUpDown_Gender";
            this.domainUpDown_Gender.ReadOnly = true;
            this.domainUpDown_Gender.Size = new System.Drawing.Size(201, 26);
            this.domainUpDown_Gender.TabIndex = 19;
            this.domainUpDown_Gender.Text = "Мужской";
            this.domainUpDown_Gender.Wrap = true;
            // 
            // label_OwnerGender
            // 
            this.label_OwnerGender.AutoSize = true;
            this.label_OwnerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OwnerGender.Location = new System.Drawing.Point(248, 342);
            this.label_OwnerGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_OwnerGender.Name = "label_OwnerGender";
            this.label_OwnerGender.Size = new System.Drawing.Size(37, 16);
            this.label_OwnerGender.TabIndex = 20;
            this.label_OwnerGender.Text = "Пол:";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(12, 446);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(438, 117);
            this.button_Add.TabIndex = 21;
            this.button_Add.Text = "ДОБАВИТЬ";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // button_SaveXML
            // 
            this.button_SaveXML.Location = new System.Drawing.Point(473, 366);
            this.button_SaveXML.Name = "button_SaveXML";
            this.button_SaveXML.Size = new System.Drawing.Size(263, 55);
            this.button_SaveXML.TabIndex = 23;
            this.button_SaveXML.Text = "Сохранить в XML";
            this.button_SaveXML.UseVisualStyleBackColor = true;
            this.button_SaveXML.Click += new System.EventHandler(this.Button_SaveXML_Click);
            // 
            // button_ReadXML
            // 
            this.button_ReadXML.Location = new System.Drawing.Point(473, 438);
            this.button_ReadXML.Name = "button_ReadXML";
            this.button_ReadXML.Size = new System.Drawing.Size(262, 55);
            this.button_ReadXML.TabIndex = 24;
            this.button_ReadXML.Text = "Прочитать из XML";
            this.button_ReadXML.UseVisualStyleBackColor = true;
            this.button_ReadXML.Click += new System.EventHandler(this.Button_ReadXML_Click);
            // 
            // richTextBox_toOutput
            // 
            this.richTextBox_toOutput.Location = new System.Drawing.Point(473, 74);
            this.richTextBox_toOutput.Name = "richTextBox_toOutput";
            this.richTextBox_toOutput.ReadOnly = true;
            this.richTextBox_toOutput.Size = new System.Drawing.Size(262, 285);
            this.richTextBox_toOutput.TabIndex = 25;
            this.richTextBox_toOutput.Text = "";
            this.richTextBox_toOutput.TextChanged += new System.EventHandler(this.richTextBox_toOutput_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.AboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DepositTypeToolStripMenuItem,
            this.DateOfOpenToolStripMenuItem});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.сортировкаПоToolStripMenuItem.Text = "Сортировка по";
            this.сортировкаПоToolStripMenuItem.Click += new System.EventHandler(this.сортировкаПоToolStripMenuItem_Click);
            // 
            // DepositTypeToolStripMenuItem
            // 
            this.DepositTypeToolStripMenuItem.Name = "DepositTypeToolStripMenuItem";
            this.DepositTypeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.DepositTypeToolStripMenuItem.Text = "Типу вклада";
            this.DepositTypeToolStripMenuItem.Click += new System.EventHandler(this.DepositTypeToolStripMenuItem_Click);
            // 
            // DateOfOpenToolStripMenuItem
            // 
            this.DateOfOpenToolStripMenuItem.Name = "DateOfOpenToolStripMenuItem";
            this.DateOfOpenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.DateOfOpenToolStripMenuItem.Text = "Дате открытия счета";
            this.DateOfOpenToolStripMenuItem.Click += new System.EventHandler(this.DateOfOpenToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 54);
            this.button1.TabIndex = 27;
            this.button1.Text = "Сохранить сортировку в XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 44);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(64, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 44);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(115, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 44);
            this.button4.TabIndex = 30;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(167, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 44);
            this.button5.TabIndex = 31;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(748, 575);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox_toOutput);
            this.Controls.Add(this.button_ReadXML);
            this.Controls.Add(this.button_SaveXML);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_OwnerGender);
            this.Controls.Add(this.domainUpDown_Gender);
            this.Controls.Add(this.label_DateOfBirth);
            this.Controls.Add(this.dateTimePicker_DateOfBirth);
            this.Controls.Add(this.label_OwnerThirdName);
            this.Controls.Add(this.textBox_OwnerThridName);
            this.Controls.Add(this.label_OwnerSecondName);
            this.Controls.Add(this.textBox_OwnerSecondName);
            this.Controls.Add(this.label_OwnerName);
            this.Controls.Add(this.textBox_OwnerName);
            this.Controls.Add(this.label_TypeOfBankAccount);
            this.Controls.Add(this.label_InputNumberOfBankAccount);
            this.Controls.Add(this.label_Owner);
            this.Controls.Add(this.label_BancAccount);
            this.Controls.Add(this.checkBox_3DSecure);
            this.Controls.Add(this.checkBox_InternetBanking);
            this.Controls.Add(this.label_BalanceValue);
            this.Controls.Add(this.trackBar_Balance);
            this.Controls.Add(this.comboBox_typeOfBankAccount);
            this.Controls.Add(this.groupBox_IsSmsEnabled);
            this.Controls.Add(this.textBox_BankAccount);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Bank";
            this.TransparencyKey = System.Drawing.Color.SeaShell;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_IsSmsEnabled.ResumeLayout(false);
            this.groupBox_IsSmsEnabled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Balance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_BankAccount;
        private System.Windows.Forms.GroupBox groupBox_IsSmsEnabled;
        private System.Windows.Forms.RadioButton radioButton_SmsFalse;
        private System.Windows.Forms.RadioButton radioButton_SmsTrue;
        private System.Windows.Forms.ComboBox comboBox_typeOfBankAccount;
        private System.Windows.Forms.TrackBar trackBar_Balance;
        private System.Windows.Forms.Label label_BalanceValue;
        private System.Windows.Forms.CheckBox checkBox_InternetBanking;
        private System.Windows.Forms.CheckBox checkBox_3DSecure;
        private System.Windows.Forms.Label label_BancAccount;
        private System.Windows.Forms.Label label_Owner;
        private System.Windows.Forms.Label label_InputNumberOfBankAccount;
        private System.Windows.Forms.Label label_TypeOfBankAccount;
        private System.Windows.Forms.Label label_OwnerName;
        private System.Windows.Forms.TextBox textBox_OwnerName;
        private System.Windows.Forms.Label label_OwnerSecondName;
        private System.Windows.Forms.TextBox textBox_OwnerSecondName;
        private System.Windows.Forms.Label label_OwnerThirdName;
        private System.Windows.Forms.TextBox textBox_OwnerThridName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirth;
        private System.Windows.Forms.Label label_DateOfBirth;
        private System.Windows.Forms.DomainUpDown domainUpDown_Gender;
        private System.Windows.Forms.Label label_OwnerGender;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_SaveXML;
        private System.Windows.Forms.Button button_ReadXML;
        private System.Windows.Forms.RichTextBox richTextBox_toOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepositTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DateOfOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

