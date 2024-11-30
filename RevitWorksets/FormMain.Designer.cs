namespace RevitWorksets
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOk = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonLoad = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            labelHelp1 = new System.Windows.Forms.Label();
            dataGridViewCategories = new System.Windows.Forms.DataGridView();
            checkBoxEnabledByCategory = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            labelHelp2 = new System.Windows.Forms.Label();
            dataGridViewFamilies = new System.Windows.Forms.DataGridView();
            checkBoxEnableByFamilyName = new System.Windows.Forms.CheckBox();
            labelHelp6 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            textBoxWorksetNameParameter = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            checkBoxEnabledByParameter = new System.Windows.Forms.CheckBox();
            buttonHelp = new System.Windows.Forms.Button();
            groupBox4 = new System.Windows.Forms.GroupBox();
            labelHelp5 = new System.Windows.Forms.Label();
            labelHelp4 = new System.Windows.Forms.Label();
            labelLinkTestResult = new System.Windows.Forms.Label();
            numericLinkIgnoreLastChars = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            numericLinkIgnoreFirstChars = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            numericLinkPartNumber = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            textBoxLinkTestFilename = new System.Windows.Forms.TextBox();
            textBoxLinkPrefix = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            textBoxLinkSeparator = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            checkBoxEnabledForLinkedFiles = new System.Windows.Forms.CheckBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            textBoxDwgWorksetName = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            checkBoxEnabledForDwgLinks = new System.Windows.Forms.CheckBox();
            groupBox6 = new System.Windows.Forms.GroupBox();
            dataGridViewTypes = new System.Windows.Forms.DataGridView();
            checkBoxEnableByType = new System.Windows.Forms.CheckBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            labelHelp3 = new System.Windows.Forms.Label();
            buttonReset = new System.Windows.Forms.Button();
            labelHelp0 = new System.Windows.Forms.Label();
            checkBoxNoEmptyWorksets = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFamilies).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericLinkIgnoreLastChars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericLinkIgnoreFirstChars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericLinkPartNumber).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonOk.Location = new System.Drawing.Point(957, 944);
            buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(88, 27);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.Location = new System.Drawing.Point(1051, 944);
            buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(88, 27);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonSave.Location = new System.Drawing.Point(14, 944);
            buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(146, 27);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить в файл";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonLoad.Location = new System.Drawing.Point(167, 944);
            buttonLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new System.Drawing.Size(146, 27);
            buttonLoad.TabIndex = 2;
            buttonLoad.Text = "Загрузить из файла";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox1.Controls.Add(labelHelp1);
            groupBox1.Controls.Add(dataGridViewCategories);
            groupBox1.Controls.Add(checkBoxEnabledByCategory);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(603, 404);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. Рабочий набор по категории";
            // 
            // labelHelp1
            // 
            labelHelp1.AutoEllipsis = true;
            labelHelp1.BackColor = System.Drawing.Color.Yellow;
            labelHelp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp1.Location = new System.Drawing.Point(194, 153);
            labelHelp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHelp1.Name = "labelHelp1";
            labelHelp1.Size = new System.Drawing.Size(179, 42);
            labelHelp1.TabIndex = 2;
            labelHelp1.Text = "← щелкните по пустой строке, чтобы добавить";
            labelHelp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelHelp1.Visible = false;
            labelHelp1.Click += labelHelp_Click;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new System.Drawing.Point(8, 51);
            dataGridViewCategories.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewCategories.Size = new System.Drawing.Size(584, 361);
            dataGridViewCategories.TabIndex = 1;
            dataGridViewCategories.CellContentClick += dataGridViewCategories_CellContentClick;
            dataGridViewCategories.EnabledChanged += dataGridView_EnabledChanged;
            // 
            // checkBoxEnabledByCategory
            // 
            checkBoxEnabledByCategory.AutoSize = true;
            checkBoxEnabledByCategory.Checked = true;
            checkBoxEnabledByCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnabledByCategory.Location = new System.Drawing.Point(8, 22);
            checkBoxEnabledByCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxEnabledByCategory.Name = "checkBoxEnabledByCategory";
            checkBoxEnabledByCategory.Size = new System.Drawing.Size(102, 19);
            checkBoxEnabledByCategory.TabIndex = 0;
            checkBoxEnabledByCategory.Text = "Активировать";
            checkBoxEnabledByCategory.UseVisualStyleBackColor = true;
            checkBoxEnabledByCategory.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox2.Controls.Add(labelHelp2);
            groupBox2.Controls.Add(dataGridViewFamilies);
            groupBox2.Controls.Add(checkBoxEnableByFamilyName);
            groupBox2.Location = new System.Drawing.Point(14, 425);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(603, 512);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "2. Рабочий набор по префиксу имени семейства";
            // 
            // labelHelp2
            // 
            labelHelp2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelHelp2.AutoEllipsis = true;
            labelHelp2.BackColor = System.Drawing.Color.Yellow;
            labelHelp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp2.Location = new System.Drawing.Point(31, 125);
            labelHelp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHelp2.Name = "labelHelp2";
            labelHelp2.Size = new System.Drawing.Size(216, 42);
            labelHelp2.TabIndex = 2;
            labelHelp2.Text = "← удалить строку - щелкнуть по первой ячейке и Delete";
            labelHelp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelHelp2.Visible = false;
            labelHelp2.Click += labelHelp_Click;
            // 
            // dataGridViewFamilies
            // 
            dataGridViewFamilies.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewFamilies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFamilies.Location = new System.Drawing.Point(8, 51);
            dataGridViewFamilies.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            dataGridViewFamilies.Name = "dataGridViewFamilies";
            dataGridViewFamilies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewFamilies.Size = new System.Drawing.Size(586, 452);
            dataGridViewFamilies.TabIndex = 1;
            dataGridViewFamilies.CellContentClick += dataGridViewFamilies_CellContentClick;
            dataGridViewFamilies.EnabledChanged += dataGridView_EnabledChanged;
            // 
            // checkBoxEnableByFamilyName
            // 
            checkBoxEnableByFamilyName.AutoSize = true;
            checkBoxEnableByFamilyName.Checked = true;
            checkBoxEnableByFamilyName.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnableByFamilyName.Location = new System.Drawing.Point(8, 22);
            checkBoxEnableByFamilyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxEnableByFamilyName.Name = "checkBoxEnableByFamilyName";
            checkBoxEnableByFamilyName.Size = new System.Drawing.Size(102, 19);
            checkBoxEnableByFamilyName.TabIndex = 0;
            checkBoxEnableByFamilyName.Text = "Активировать";
            checkBoxEnableByFamilyName.UseVisualStyleBackColor = true;
            checkBoxEnableByFamilyName.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // labelHelp6
            // 
            labelHelp6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelHelp6.AutoEllipsis = true;
            labelHelp6.BackColor = System.Drawing.Color.Yellow;
            labelHelp6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp6.Location = new System.Drawing.Point(38, 873);
            labelHelp6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHelp6.Name = "labelHelp6";
            labelHelp6.Size = new System.Drawing.Size(538, 64);
            labelHelp6.TabIndex = 2;
            labelHelp6.Text = resources.GetString("labelHelp6.Text");
            labelHelp6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelHelp6.Visible = false;
            labelHelp6.Click += labelHelp_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBoxWorksetNameParameter);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(checkBoxEnabledByParameter);
            groupBox3.Location = new System.Drawing.Point(630, 425);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(603, 130);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "4. Рабочий набор по параметру";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.Location = new System.Drawing.Point(9, 83);
            label3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(542, 42);
            label3.TabIndex = 3;
            label3.Text = "Элементы будут помещены в рабочий набор, имя которого указано в этом параметре. Параметр может быть указан в Типе, формулой в загружаемом семействе и т.д.";
            // 
            // textBoxWorksetNameParameter
            // 
            textBoxWorksetNameParameter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxWorksetNameParameter.Location = new System.Drawing.Point(181, 51);
            textBoxWorksetNameParameter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxWorksetNameParameter.Name = "textBoxWorksetNameParameter";
            textBoxWorksetNameParameter.Size = new System.Drawing.Size(412, 23);
            textBoxWorksetNameParameter.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 51);
            label1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя параметра:";
            // 
            // checkBoxEnabledByParameter
            // 
            checkBoxEnabledByParameter.AutoSize = true;
            checkBoxEnabledByParameter.Checked = true;
            checkBoxEnabledByParameter.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnabledByParameter.Location = new System.Drawing.Point(8, 22);
            checkBoxEnabledByParameter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxEnabledByParameter.Name = "checkBoxEnabledByParameter";
            checkBoxEnabledByParameter.Size = new System.Drawing.Size(102, 19);
            checkBoxEnabledByParameter.TabIndex = 0;
            checkBoxEnabledByParameter.Text = "Активировать";
            checkBoxEnabledByParameter.UseVisualStyleBackColor = true;
            checkBoxEnabledByParameter.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonHelp.Location = new System.Drawing.Point(1146, 944);
            buttonHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new System.Drawing.Size(88, 27);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += FormMain_HelpButtonClicked;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox4.Controls.Add(labelHelp5);
            groupBox4.Controls.Add(labelHelp4);
            groupBox4.Controls.Add(labelLinkTestResult);
            groupBox4.Controls.Add(numericLinkIgnoreLastChars);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(numericLinkIgnoreFirstChars);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(numericLinkPartNumber);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(textBoxLinkTestFilename);
            groupBox4.Controls.Add(textBoxLinkPrefix);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(textBoxLinkSeparator);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(checkBoxEnabledForLinkedFiles);
            groupBox4.Location = new System.Drawing.Point(630, 562);
            groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Size = new System.Drawing.Size(603, 271);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "5. Рабочий набор для связанных файлов";
            // 
            // labelHelp5
            // 
            labelHelp5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelHelp5.AutoEllipsis = true;
            labelHelp5.BackColor = System.Drawing.Color.Yellow;
            labelHelp5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp5.Location = new System.Drawing.Point(205, 196);
            labelHelp5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHelp5.Name = "labelHelp5";
            labelHelp5.Size = new System.Drawing.Size(217, 26);
            labelHelp5.TabIndex = 2;
            labelHelp5.Text = "↓ можно потренироваться здесь";
            labelHelp5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelHelp5.Visible = false;
            labelHelp5.Click += labelHelp_Click;
            // 
            // labelHelp4
            // 
            labelHelp4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelHelp4.AutoEllipsis = true;
            labelHelp4.BackColor = System.Drawing.Color.Yellow;
            labelHelp4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp4.Location = new System.Drawing.Point(259, 0);
            labelHelp4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHelp4.Name = "labelHelp4";
            labelHelp4.Size = new System.Drawing.Size(344, 102);
            labelHelp4.TabIndex = 2;
            labelHelp4.Text = resources.GetString("labelHelp4.Text");
            labelHelp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelHelp4.Visible = false;
            labelHelp4.Click += labelHelp_Click;
            // 
            // labelLinkTestResult
            // 
            labelLinkTestResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelLinkTestResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            labelLinkTestResult.Location = new System.Drawing.Point(340, 225);
            labelLinkTestResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLinkTestResult.Name = "labelLinkTestResult";
            labelLinkTestResult.Size = new System.Drawing.Size(254, 23);
            labelLinkTestResult.TabIndex = 4;
            labelLinkTestResult.Text = "...";
            labelLinkTestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericLinkIgnoreLastChars
            // 
            numericLinkIgnoreLastChars.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numericLinkIgnoreLastChars.Location = new System.Drawing.Point(181, 137);
            numericLinkIgnoreLastChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericLinkIgnoreLastChars.Name = "numericLinkIgnoreLastChars";
            numericLinkIgnoreLastChars.Size = new System.Drawing.Size(413, 23);
            numericLinkIgnoreLastChars.TabIndex = 3;
            numericLinkIgnoreLastChars.ValueChanged += textBoxLink_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(16, 141);
            label7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(114, 15);
            label7.TabIndex = 1;
            label7.Text = "Отбросить в конце:";
            // 
            // numericLinkIgnoreFirstChars
            // 
            numericLinkIgnoreFirstChars.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numericLinkIgnoreFirstChars.Location = new System.Drawing.Point(181, 107);
            numericLinkIgnoreFirstChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericLinkIgnoreFirstChars.Name = "numericLinkIgnoreFirstChars";
            numericLinkIgnoreFirstChars.Size = new System.Drawing.Size(413, 23);
            numericLinkIgnoreFirstChars.TabIndex = 3;
            numericLinkIgnoreFirstChars.ValueChanged += textBoxLink_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(16, 111);
            label6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 15);
            label6.TabIndex = 1;
            label6.Text = "Отбросить в начале:";
            // 
            // numericLinkPartNumber
            // 
            numericLinkPartNumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numericLinkPartNumber.Location = new System.Drawing.Point(181, 77);
            numericLinkPartNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericLinkPartNumber.Name = "numericLinkPartNumber";
            numericLinkPartNumber.Size = new System.Drawing.Size(413, 23);
            numericLinkPartNumber.TabIndex = 3;
            numericLinkPartNumber.ValueChanged += textBoxLink_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 81);
            label4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 15);
            label4.TabIndex = 1;
            label4.Text = "Номер части:";
            // 
            // textBoxLinkTestFilename
            // 
            textBoxLinkTestFilename.Location = new System.Drawing.Point(20, 225);
            textBoxLinkTestFilename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLinkTestFilename.Name = "textBoxLinkTestFilename";
            textBoxLinkTestFilename.Size = new System.Drawing.Size(265, 23);
            textBoxLinkTestFilename.TabIndex = 2;
            textBoxLinkTestFilename.Text = "0123_КР.П_Жилой комплекс";
            textBoxLinkTestFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxLinkTestFilename.WordWrap = false;
            textBoxLinkTestFilename.TextChanged += textBoxLink_TextChanged;
            // 
            // textBoxLinkPrefix
            // 
            textBoxLinkPrefix.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxLinkPrefix.Location = new System.Drawing.Point(181, 167);
            textBoxLinkPrefix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLinkPrefix.Name = "textBoxLinkPrefix";
            textBoxLinkPrefix.Size = new System.Drawing.Size(412, 23);
            textBoxLinkPrefix.TabIndex = 2;
            textBoxLinkPrefix.TextChanged += textBoxLink_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(301, 228);
            label10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(23, 15);
            label10.TabIndex = 1;
            label10.Text = ">>";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(16, 201);
            label9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(64, 15);
            label9.TabIndex = 1;
            label9.Text = "Проверка:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(16, 171);
            label8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(142, 15);
            label8.TabIndex = 1;
            label8.Text = "Префикс имени набора:";
            // 
            // textBoxLinkSeparator
            // 
            textBoxLinkSeparator.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxLinkSeparator.Location = new System.Drawing.Point(181, 47);
            textBoxLinkSeparator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLinkSeparator.MaxLength = 1;
            textBoxLinkSeparator.Name = "textBoxLinkSeparator";
            textBoxLinkSeparator.Size = new System.Drawing.Size(412, 23);
            textBoxLinkSeparator.TabIndex = 2;
            textBoxLinkSeparator.TextChanged += textBoxLink_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(16, 51);
            label5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(117, 15);
            label5.TabIndex = 1;
            label5.Text = "Разделитель имени:";
            // 
            // checkBoxEnabledForLinkedFiles
            // 
            checkBoxEnabledForLinkedFiles.AutoSize = true;
            checkBoxEnabledForLinkedFiles.Checked = true;
            checkBoxEnabledForLinkedFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnabledForLinkedFiles.Location = new System.Drawing.Point(8, 22);
            checkBoxEnabledForLinkedFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxEnabledForLinkedFiles.Name = "checkBoxEnabledForLinkedFiles";
            checkBoxEnabledForLinkedFiles.Size = new System.Drawing.Size(102, 19);
            checkBoxEnabledForLinkedFiles.TabIndex = 0;
            checkBoxEnabledForLinkedFiles.Text = "Активировать";
            checkBoxEnabledForLinkedFiles.UseVisualStyleBackColor = true;
            checkBoxEnabledForLinkedFiles.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox5.Controls.Add(textBoxDwgWorksetName);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(checkBoxEnabledForDwgLinks);
            groupBox5.Location = new System.Drawing.Point(630, 840);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Size = new System.Drawing.Size(603, 97);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "6. Рабочий набор для DWG/DXF связей";
            // 
            // textBoxDwgWorksetName
            // 
            textBoxDwgWorksetName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxDwgWorksetName.Location = new System.Drawing.Point(181, 51);
            textBoxDwgWorksetName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxDwgWorksetName.Name = "textBoxDwgWorksetName";
            textBoxDwgWorksetName.Size = new System.Drawing.Size(412, 23);
            textBoxDwgWorksetName.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(16, 51);
            label13.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(132, 15);
            label13.TabIndex = 1;
            label13.Text = "Имя рабочего набора:";
            // 
            // checkBoxEnabledForDwgLinks
            // 
            checkBoxEnabledForDwgLinks.AutoSize = true;
            checkBoxEnabledForDwgLinks.Checked = true;
            checkBoxEnabledForDwgLinks.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnabledForDwgLinks.Location = new System.Drawing.Point(8, 22);
            checkBoxEnabledForDwgLinks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxEnabledForDwgLinks.Name = "checkBoxEnabledForDwgLinks";
            checkBoxEnabledForDwgLinks.Size = new System.Drawing.Size(102, 19);
            checkBoxEnabledForDwgLinks.TabIndex = 0;
            checkBoxEnabledForDwgLinks.Text = "Активировать";
            checkBoxEnabledForDwgLinks.UseVisualStyleBackColor = true;
            checkBoxEnabledForDwgLinks.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            groupBox6.Controls.Add(dataGridViewTypes);
            groupBox6.Controls.Add(checkBoxEnableByType);
            groupBox6.Location = new System.Drawing.Point(630, 14);
            groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox6.Size = new System.Drawing.Size(603, 404);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "3. Рабочий набор по имени типа";
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Location = new System.Drawing.Point(8, 51);
            dataGridViewTypes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridViewTypes.Size = new System.Drawing.Size(584, 361);
            dataGridViewTypes.TabIndex = 1;
            dataGridViewTypes.CellContentClick += dataGridViewByType_CellContentClick;
            dataGridViewTypes.EnabledChanged += dataGridView_EnabledChanged;
            // 
            // checkBoxEnableByType
            // 
            checkBoxEnableByType.AutoSize = true;
            checkBoxEnableByType.Checked = true;
            checkBoxEnableByType.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnableByType.Location = new System.Drawing.Point(8, 22);
            checkBoxEnableByType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxEnableByType.Name = "checkBoxEnableByType";
            checkBoxEnableByType.Size = new System.Drawing.Size(102, 19);
            checkBoxEnableByType.TabIndex = 0;
            checkBoxEnableByType.Text = "Активировать";
            checkBoxEnableByType.UseVisualStyleBackColor = true;
            checkBoxEnableByType.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new System.Drawing.Point(0, 977);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(1247, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // labelHelp3
            // 
            labelHelp3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelHelp3.AutoEllipsis = true;
            labelHelp3.BackColor = System.Drawing.Color.Yellow;
            labelHelp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp3.Location = new System.Drawing.Point(835, 7);
            labelHelp3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHelp3.Name = "labelHelp3";
            labelHelp3.Size = new System.Drawing.Size(346, 56);
            labelHelp3.TabIndex = 2;
            labelHelp3.Text = "← рабочие наборы применяются последовательно: Категория - Семейство - Тип и так далее. Последующее правило имеет больший приоритет";
            labelHelp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelHelp3.Visible = false;
            labelHelp3.Click += labelHelp_Click;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonReset.Location = new System.Drawing.Point(320, 944);
            buttonReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(146, 27);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Сбросить настройки";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelHelp0
            // 
            labelHelp0.AutoEllipsis = true;
            labelHelp0.BackColor = System.Drawing.Color.Yellow;
            labelHelp0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            labelHelp0.Location = new System.Drawing.Point(438, 284);
            labelHelp0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHelp0.Name = "labelHelp0";
            labelHelp0.Size = new System.Drawing.Size(365, 98);
            labelHelp0.TabIndex = 2;
            labelHelp0.Text = "Подсказки отображаются только при первом  запуске. Чтобы скрыть, щелкните по любой подсказке!";
            labelHelp0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelHelp0.Visible = false;
            labelHelp0.Click += labelHelp_Click;
            // 
            // checkBoxNoEmptyWorksets
            // 
            checkBoxNoEmptyWorksets.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            checkBoxNoEmptyWorksets.AutoSize = true;
            checkBoxNoEmptyWorksets.Location = new System.Drawing.Point(650, 948);
            checkBoxNoEmptyWorksets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxNoEmptyWorksets.Name = "checkBoxNoEmptyWorksets";
            checkBoxNoEmptyWorksets.Size = new System.Drawing.Size(235, 19);
            checkBoxNoEmptyWorksets.TabIndex = 8;
            checkBoxNoEmptyWorksets.Text = "Не создавать пустые рабочие наборы";
            checkBoxNoEmptyWorksets.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new System.Drawing.Size(1247, 999);
            Controls.Add(checkBoxNoEmptyWorksets);
            Controls.Add(labelHelp0);
            Controls.Add(labelHelp6);
            Controls.Add(labelHelp3);
            Controls.Add(statusStrip1);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox6);
            Controls.Add(groupBox1);
            Controls.Add(buttonReset);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            HelpButton = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(1263, 1240);
            MinimumSize = new System.Drawing.Size(1263, 779);
            Name = "FormMain";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bim-Starter Рабочие наборы";
            HelpButtonClicked += FormMain_HelpButtonClicked;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFamilies).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericLinkIgnoreLastChars).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericLinkIgnoreFirstChars).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericLinkPartNumber).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEnabledByCategory;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewFamilies;
        private System.Windows.Forms.CheckBox checkBoxEnableByFamilyName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxEnabledByParameter;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWorksetNameParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxLinkSeparator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxEnabledForLinkedFiles;
        private System.Windows.Forms.Label labelLinkTestResult;
        private System.Windows.Forms.NumericUpDown numericLinkIgnoreLastChars;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericLinkIgnoreFirstChars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericLinkPartNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLinkTestFilename;
        private System.Windows.Forms.TextBox textBoxLinkPrefix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxDwgWorksetName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxEnabledForDwgLinks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridViewTypes;
        private System.Windows.Forms.CheckBox checkBoxEnableByType;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelHelp1;
        private System.Windows.Forms.Label labelHelp2;
        private System.Windows.Forms.Label labelHelp3;
        private System.Windows.Forms.Label labelHelp4;
        private System.Windows.Forms.Label labelHelp5;
        private System.Windows.Forms.Label labelHelp6;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelHelp0;
        private System.Windows.Forms.CheckBox checkBoxNoEmptyWorksets;
    }
}