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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHelp1 = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.checkBoxEnabledByCategory = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelHelp2 = new System.Windows.Forms.Label();
            this.dataGridViewFamilies = new System.Windows.Forms.DataGridView();
            this.checkBoxEnableByFamilyName = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWorksetNameParameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxEnabledByParameter = new System.Windows.Forms.CheckBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelHelp5 = new System.Windows.Forms.Label();
            this.labelHelp4 = new System.Windows.Forms.Label();
            this.labelLinkTestResult = new System.Windows.Forms.Label();
            this.numericLinkIgnoreLastChars = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericLinkIgnoreFirstChars = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericLinkPartNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLinkTestFilename = new System.Windows.Forms.TextBox();
            this.textBoxLinkPrefix = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLinkSeparator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxEnabledForLinkedFiles = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxDwgWorksetName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBoxEnabledForDwgLinks = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTypes = new System.Windows.Forms.DataGridView();
            this.checkBoxEnableByType = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelHelp3 = new System.Windows.Forms.Label();
            this.labelHelp6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilies)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLinkIgnoreLastChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLinkIgnoreFirstChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLinkPartNumber)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(820, 818);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(901, 818);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(12, 818);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(143, 818);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(125, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузить из файла";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.labelHelp1);
            this.groupBox1.Controls.Add(this.dataGridViewCategories);
            this.groupBox1.Controls.Add(this.checkBoxEnabledByCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 350);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Рабочий набор по категории";
            // 
            // labelHelp1
            // 
            this.labelHelp1.AutoEllipsis = true;
            this.labelHelp1.BackColor = System.Drawing.Color.Yellow;
            this.labelHelp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelp1.Location = new System.Drawing.Point(166, 133);
            this.labelHelp1.Name = "labelHelp1";
            this.labelHelp1.Size = new System.Drawing.Size(154, 37);
            this.labelHelp1.TabIndex = 2;
            this.labelHelp1.Text = "← щелкните по пустой строке, чтобы добавить";
            this.labelHelp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelp1.Visible = false;
            this.labelHelp1.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(7, 44);
            this.dataGridViewCategories.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCategories.Size = new System.Drawing.Size(501, 313);
            this.dataGridViewCategories.TabIndex = 1;
            this.dataGridViewCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellContentClick);
            this.dataGridViewCategories.EnabledChanged += new System.EventHandler(this.dataGridView_EnabledChanged);
            // 
            // checkBoxEnabledByCategory
            // 
            this.checkBoxEnabledByCategory.AutoSize = true;
            this.checkBoxEnabledByCategory.Checked = true;
            this.checkBoxEnabledByCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnabledByCategory.Location = new System.Drawing.Point(7, 19);
            this.checkBoxEnabledByCategory.Name = "checkBoxEnabledByCategory";
            this.checkBoxEnabledByCategory.Size = new System.Drawing.Size(97, 17);
            this.checkBoxEnabledByCategory.TabIndex = 0;
            this.checkBoxEnabledByCategory.Text = "Активировать";
            this.checkBoxEnabledByCategory.UseVisualStyleBackColor = true;
            this.checkBoxEnabledByCategory.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.labelHelp2);
            this.groupBox2.Controls.Add(this.dataGridViewFamilies);
            this.groupBox2.Controls.Add(this.checkBoxEnableByFamilyName);
            this.groupBox2.Location = new System.Drawing.Point(12, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 444);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Рабочий набор по префиксу имени семейства";
            // 
            // labelHelp2
            // 
            this.labelHelp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHelp2.AutoEllipsis = true;
            this.labelHelp2.BackColor = System.Drawing.Color.Yellow;
            this.labelHelp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelp2.Location = new System.Drawing.Point(27, 108);
            this.labelHelp2.Name = "labelHelp2";
            this.labelHelp2.Size = new System.Drawing.Size(185, 37);
            this.labelHelp2.TabIndex = 2;
            this.labelHelp2.Text = "← удалить строку - щелкнуть по первой ячейке и Delete";
            this.labelHelp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelp2.Visible = false;
            this.labelHelp2.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // dataGridViewFamilies
            // 
            this.dataGridViewFamilies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFamilies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFamilies.Location = new System.Drawing.Point(7, 44);
            this.dataGridViewFamilies.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewFamilies.Name = "dataGridViewFamilies";
            this.dataGridViewFamilies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFamilies.Size = new System.Drawing.Size(502, 392);
            this.dataGridViewFamilies.TabIndex = 1;
            this.dataGridViewFamilies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFamilies_CellContentClick);
            this.dataGridViewFamilies.EnabledChanged += new System.EventHandler(this.dataGridView_EnabledChanged);
            // 
            // checkBoxEnableByFamilyName
            // 
            this.checkBoxEnableByFamilyName.AutoSize = true;
            this.checkBoxEnableByFamilyName.Checked = true;
            this.checkBoxEnableByFamilyName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableByFamilyName.Location = new System.Drawing.Point(7, 19);
            this.checkBoxEnableByFamilyName.Name = "checkBoxEnableByFamilyName";
            this.checkBoxEnableByFamilyName.Size = new System.Drawing.Size(97, 17);
            this.checkBoxEnableByFamilyName.TabIndex = 0;
            this.checkBoxEnableByFamilyName.Text = "Активировать";
            this.checkBoxEnableByFamilyName.UseVisualStyleBackColor = true;
            this.checkBoxEnableByFamilyName.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxWorksetNameParameter);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.checkBoxEnabledByParameter);
            this.groupBox3.Location = new System.Drawing.Point(540, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4. Рабочий набор по параметру";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Элементы будут помещены в рабочий набор, имя которого указано в этом параметре. П" +
    "араметр может быть указан в Типе, формулой в загружаемом семействе и т.д.";
            // 
            // textBoxWorksetNameParameter
            // 
            this.textBoxWorksetNameParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorksetNameParameter.Location = new System.Drawing.Point(155, 44);
            this.textBoxWorksetNameParameter.Name = "textBoxWorksetNameParameter";
            this.textBoxWorksetNameParameter.Size = new System.Drawing.Size(354, 20);
            this.textBoxWorksetNameParameter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя параметра:";
            // 
            // checkBoxEnabledByParameter
            // 
            this.checkBoxEnabledByParameter.AutoSize = true;
            this.checkBoxEnabledByParameter.Checked = true;
            this.checkBoxEnabledByParameter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnabledByParameter.Location = new System.Drawing.Point(7, 19);
            this.checkBoxEnabledByParameter.Name = "checkBoxEnabledByParameter";
            this.checkBoxEnabledByParameter.Size = new System.Drawing.Size(97, 17);
            this.checkBoxEnabledByParameter.TabIndex = 0;
            this.checkBoxEnabledByParameter.Text = "Активировать";
            this.checkBoxEnabledByParameter.UseVisualStyleBackColor = true;
            this.checkBoxEnabledByParameter.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Location = new System.Drawing.Point(982, 818);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.FormMain_HelpButtonClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.labelHelp5);
            this.groupBox4.Controls.Add(this.labelHelp4);
            this.groupBox4.Controls.Add(this.labelLinkTestResult);
            this.groupBox4.Controls.Add(this.numericLinkIgnoreLastChars);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numericLinkIgnoreFirstChars);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.numericLinkPartNumber);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxLinkTestFilename);
            this.groupBox4.Controls.Add(this.textBoxLinkPrefix);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBoxLinkSeparator);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.checkBoxEnabledForLinkedFiles);
            this.groupBox4.Location = new System.Drawing.Point(540, 487);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 235);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "5. Рабочий набор для связанных файлов";
            // 
            // labelHelp5
            // 
            this.labelHelp5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelp5.AutoEllipsis = true;
            this.labelHelp5.BackColor = System.Drawing.Color.Yellow;
            this.labelHelp5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelp5.Location = new System.Drawing.Point(176, 170);
            this.labelHelp5.Name = "labelHelp5";
            this.labelHelp5.Size = new System.Drawing.Size(186, 23);
            this.labelHelp5.TabIndex = 2;
            this.labelHelp5.Text = "↓ можно потренироваться здесь";
            this.labelHelp5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelp5.Visible = false;
            this.labelHelp5.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // labelHelp4
            // 
            this.labelHelp4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelp4.AutoEllipsis = true;
            this.labelHelp4.BackColor = System.Drawing.Color.Yellow;
            this.labelHelp4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelp4.Location = new System.Drawing.Point(222, 0);
            this.labelHelp4.Name = "labelHelp4";
            this.labelHelp4.Size = new System.Drawing.Size(289, 89);
            this.labelHelp4.TabIndex = 2;
            this.labelHelp4.Text = resources.GetString("labelHelp4.Text");
            this.labelHelp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelp4.Visible = false;
            this.labelHelp4.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // labelLinkTestResult
            // 
            this.labelLinkTestResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLinkTestResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLinkTestResult.Location = new System.Drawing.Point(291, 195);
            this.labelLinkTestResult.Name = "labelLinkTestResult";
            this.labelLinkTestResult.Size = new System.Drawing.Size(218, 20);
            this.labelLinkTestResult.TabIndex = 4;
            this.labelLinkTestResult.Text = "...";
            this.labelLinkTestResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericLinkIgnoreLastChars
            // 
            this.numericLinkIgnoreLastChars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericLinkIgnoreLastChars.Location = new System.Drawing.Point(155, 119);
            this.numericLinkIgnoreLastChars.Name = "numericLinkIgnoreLastChars";
            this.numericLinkIgnoreLastChars.Size = new System.Drawing.Size(354, 20);
            this.numericLinkIgnoreLastChars.TabIndex = 3;
            this.numericLinkIgnoreLastChars.ValueChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Отбросить в конце:";
            // 
            // numericLinkIgnoreFirstChars
            // 
            this.numericLinkIgnoreFirstChars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericLinkIgnoreFirstChars.Location = new System.Drawing.Point(155, 93);
            this.numericLinkIgnoreFirstChars.Name = "numericLinkIgnoreFirstChars";
            this.numericLinkIgnoreFirstChars.Size = new System.Drawing.Size(354, 20);
            this.numericLinkIgnoreFirstChars.TabIndex = 3;
            this.numericLinkIgnoreFirstChars.ValueChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Отбросить в начале:";
            // 
            // numericLinkPartNumber
            // 
            this.numericLinkPartNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericLinkPartNumber.Location = new System.Drawing.Point(155, 67);
            this.numericLinkPartNumber.Name = "numericLinkPartNumber";
            this.numericLinkPartNumber.Size = new System.Drawing.Size(354, 20);
            this.numericLinkPartNumber.TabIndex = 3;
            this.numericLinkPartNumber.ValueChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Номер части:";
            // 
            // textBoxLinkTestFilename
            // 
            this.textBoxLinkTestFilename.Location = new System.Drawing.Point(17, 195);
            this.textBoxLinkTestFilename.Name = "textBoxLinkTestFilename";
            this.textBoxLinkTestFilename.Size = new System.Drawing.Size(228, 20);
            this.textBoxLinkTestFilename.TabIndex = 2;
            this.textBoxLinkTestFilename.Text = "0123_КР.П_Жилой комплекс";
            this.textBoxLinkTestFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLinkTestFilename.WordWrap = false;
            this.textBoxLinkTestFilename.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // textBoxLinkPrefix
            // 
            this.textBoxLinkPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkPrefix.Location = new System.Drawing.Point(155, 145);
            this.textBoxLinkPrefix.Name = "textBoxLinkPrefix";
            this.textBoxLinkPrefix.Size = new System.Drawing.Size(354, 20);
            this.textBoxLinkPrefix.TabIndex = 2;
            this.textBoxLinkPrefix.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = ">>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Проверка:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Префикс имени набора:";
            // 
            // textBoxLinkSeparator
            // 
            this.textBoxLinkSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkSeparator.Location = new System.Drawing.Point(155, 41);
            this.textBoxLinkSeparator.MaxLength = 1;
            this.textBoxLinkSeparator.Name = "textBoxLinkSeparator";
            this.textBoxLinkSeparator.Size = new System.Drawing.Size(354, 20);
            this.textBoxLinkSeparator.TabIndex = 2;
            this.textBoxLinkSeparator.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Разделитель имени:";
            // 
            // checkBoxEnabledForLinkedFiles
            // 
            this.checkBoxEnabledForLinkedFiles.AutoSize = true;
            this.checkBoxEnabledForLinkedFiles.Checked = true;
            this.checkBoxEnabledForLinkedFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnabledForLinkedFiles.Location = new System.Drawing.Point(7, 19);
            this.checkBoxEnabledForLinkedFiles.Name = "checkBoxEnabledForLinkedFiles";
            this.checkBoxEnabledForLinkedFiles.Size = new System.Drawing.Size(97, 17);
            this.checkBoxEnabledForLinkedFiles.TabIndex = 0;
            this.checkBoxEnabledForLinkedFiles.Text = "Активировать";
            this.checkBoxEnabledForLinkedFiles.UseVisualStyleBackColor = true;
            this.checkBoxEnabledForLinkedFiles.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.textBoxDwgWorksetName);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.checkBoxEnabledForDwgLinks);
            this.groupBox5.Location = new System.Drawing.Point(540, 728);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(517, 84);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "6. Рабочий набор для DWG/DXF связей";
            // 
            // textBoxDwgWorksetName
            // 
            this.textBoxDwgWorksetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDwgWorksetName.Location = new System.Drawing.Point(155, 44);
            this.textBoxDwgWorksetName.Name = "textBoxDwgWorksetName";
            this.textBoxDwgWorksetName.Size = new System.Drawing.Size(354, 20);
            this.textBoxDwgWorksetName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Имя рабочего набора:";
            // 
            // checkBoxEnabledForDwgLinks
            // 
            this.checkBoxEnabledForDwgLinks.AutoSize = true;
            this.checkBoxEnabledForDwgLinks.Checked = true;
            this.checkBoxEnabledForDwgLinks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnabledForDwgLinks.Location = new System.Drawing.Point(7, 19);
            this.checkBoxEnabledForDwgLinks.Name = "checkBoxEnabledForDwgLinks";
            this.checkBoxEnabledForDwgLinks.Size = new System.Drawing.Size(97, 17);
            this.checkBoxEnabledForDwgLinks.TabIndex = 0;
            this.checkBoxEnabledForDwgLinks.Text = "Активировать";
            this.checkBoxEnabledForDwgLinks.UseVisualStyleBackColor = true;
            this.checkBoxEnabledForDwgLinks.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.dataGridViewTypes);
            this.groupBox6.Controls.Add(this.checkBoxEnableByType);
            this.groupBox6.Location = new System.Drawing.Point(540, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(517, 350);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "3. Рабочий набор по имени типа";
            // 
            // dataGridViewTypes
            // 
            this.dataGridViewTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypes.Location = new System.Drawing.Point(7, 44);
            this.dataGridViewTypes.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewTypes.Name = "dataGridViewTypes";
            this.dataGridViewTypes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewTypes.Size = new System.Drawing.Size(501, 313);
            this.dataGridViewTypes.TabIndex = 1;
            this.dataGridViewTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewByType_CellContentClick);
            this.dataGridViewTypes.EnabledChanged += new System.EventHandler(this.dataGridView_EnabledChanged);
            // 
            // checkBoxEnableByType
            // 
            this.checkBoxEnableByType.AutoSize = true;
            this.checkBoxEnableByType.Checked = true;
            this.checkBoxEnableByType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableByType.Location = new System.Drawing.Point(7, 19);
            this.checkBoxEnableByType.Name = "checkBoxEnableByType";
            this.checkBoxEnableByType.Size = new System.Drawing.Size(97, 17);
            this.checkBoxEnableByType.TabIndex = 0;
            this.checkBoxEnableByType.Text = "Активировать";
            this.checkBoxEnableByType.UseVisualStyleBackColor = true;
            this.checkBoxEnableByType.CheckedChanged += new System.EventHandler(this.chkbxInGroup_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 844);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1069, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // labelHelp3
            // 
            this.labelHelp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelp3.AutoEllipsis = true;
            this.labelHelp3.BackColor = System.Drawing.Color.Yellow;
            this.labelHelp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelp3.Location = new System.Drawing.Point(716, 6);
            this.labelHelp3.Name = "labelHelp3";
            this.labelHelp3.Size = new System.Drawing.Size(289, 49);
            this.labelHelp3.TabIndex = 2;
            this.labelHelp3.Text = "← рабочие наборы применяются последовательно: Категория - Семейство - Тип и так д" +
    "алее. Последующее правило имеет больший приоритет";
            this.labelHelp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelp3.Visible = false;
            this.labelHelp3.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // labelHelp6
            // 
            this.labelHelp6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHelp6.AutoEllipsis = true;
            this.labelHelp6.BackColor = System.Drawing.Color.Yellow;
            this.labelHelp6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelp6.Location = new System.Drawing.Point(274, 804);
            this.labelHelp6.Name = "labelHelp6";
            this.labelHelp6.Size = new System.Drawing.Size(438, 56);
            this.labelHelp6.TabIndex = 2;
            this.labelHelp6.Text = resources.GetString("labelHelp6.Text");
            this.labelHelp6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelp6.Visible = false;
            this.labelHelp6.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1069, 866);
            this.Controls.Add(this.labelHelp6);
            this.Controls.Add(this.labelHelp3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(1085, 1080);
            this.MinimumSize = new System.Drawing.Size(1085, 680);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bim-Starter Рабочие наборы";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormMain_HelpButtonClicked);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilies)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLinkIgnoreLastChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLinkIgnoreFirstChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLinkPartNumber)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}