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
            resources.ApplyResources(buttonOk, "buttonOk");
            buttonOk.Name = "buttonOk";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            resources.ApplyResources(buttonCancel, "buttonCancel");
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.Name = "buttonCancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            resources.ApplyResources(buttonSave, "buttonSave");
            buttonSave.Name = "buttonSave";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            resources.ApplyResources(buttonLoad, "buttonLoad");
            buttonLoad.Name = "buttonLoad";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(labelHelp1);
            groupBox1.Controls.Add(dataGridViewCategories);
            groupBox1.Controls.Add(checkBoxEnabledByCategory);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // labelHelp1
            // 
            labelHelp1.AutoEllipsis = true;
            labelHelp1.BackColor = System.Drawing.Color.Yellow;
            labelHelp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(labelHelp1, "labelHelp1");
            labelHelp1.Name = "labelHelp1";
            labelHelp1.Click += labelHelp_Click;
            // 
            // dataGridViewCategories
            // 
            resources.ApplyResources(dataGridViewCategories, "dataGridViewCategories");
            dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.CellContentClick += dataGridViewCategories_CellContentClick;
            dataGridViewCategories.EnabledChanged += dataGridView_EnabledChanged;
            // 
            // checkBoxEnabledByCategory
            // 
            resources.ApplyResources(checkBoxEnabledByCategory, "checkBoxEnabledByCategory");
            checkBoxEnabledByCategory.Checked = true;
            checkBoxEnabledByCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnabledByCategory.Name = "checkBoxEnabledByCategory";
            checkBoxEnabledByCategory.UseVisualStyleBackColor = true;
            checkBoxEnabledByCategory.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(labelHelp2);
            groupBox2.Controls.Add(dataGridViewFamilies);
            groupBox2.Controls.Add(checkBoxEnableByFamilyName);
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // labelHelp2
            // 
            resources.ApplyResources(labelHelp2, "labelHelp2");
            labelHelp2.AutoEllipsis = true;
            labelHelp2.BackColor = System.Drawing.Color.Yellow;
            labelHelp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp2.Name = "labelHelp2";
            labelHelp2.Click += labelHelp_Click;
            // 
            // dataGridViewFamilies
            // 
            resources.ApplyResources(dataGridViewFamilies, "dataGridViewFamilies");
            dataGridViewFamilies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFamilies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFamilies.Name = "dataGridViewFamilies";
            dataGridViewFamilies.CellContentClick += dataGridViewFamilies_CellContentClick;
            dataGridViewFamilies.EnabledChanged += dataGridView_EnabledChanged;
            // 
            // checkBoxEnableByFamilyName
            // 
            resources.ApplyResources(checkBoxEnableByFamilyName, "checkBoxEnableByFamilyName");
            checkBoxEnableByFamilyName.Checked = true;
            checkBoxEnableByFamilyName.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnableByFamilyName.Name = "checkBoxEnableByFamilyName";
            checkBoxEnableByFamilyName.UseVisualStyleBackColor = true;
            checkBoxEnableByFamilyName.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // labelHelp6
            // 
            resources.ApplyResources(labelHelp6, "labelHelp6");
            labelHelp6.AutoEllipsis = true;
            labelHelp6.BackColor = System.Drawing.Color.Yellow;
            labelHelp6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp6.Name = "labelHelp6";
            labelHelp6.Click += labelHelp_Click;
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBoxWorksetNameParameter);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(checkBoxEnabledByParameter);
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // textBoxWorksetNameParameter
            // 
            resources.ApplyResources(textBoxWorksetNameParameter, "textBoxWorksetNameParameter");
            textBoxWorksetNameParameter.Name = "textBoxWorksetNameParameter";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // checkBoxEnabledByParameter
            // 
            resources.ApplyResources(checkBoxEnabledByParameter, "checkBoxEnabledByParameter");
            checkBoxEnabledByParameter.Checked = true;
            checkBoxEnabledByParameter.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnabledByParameter.Name = "checkBoxEnabledByParameter";
            checkBoxEnabledByParameter.UseVisualStyleBackColor = true;
            checkBoxEnabledByParameter.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // buttonHelp
            // 
            resources.ApplyResources(buttonHelp, "buttonHelp");
            buttonHelp.Name = "buttonHelp";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += FormMain_HelpButtonClicked;
            // 
            // groupBox4
            // 
            resources.ApplyResources(groupBox4, "groupBox4");
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
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // labelHelp5
            // 
            resources.ApplyResources(labelHelp5, "labelHelp5");
            labelHelp5.AutoEllipsis = true;
            labelHelp5.BackColor = System.Drawing.Color.Yellow;
            labelHelp5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp5.Name = "labelHelp5";
            labelHelp5.Click += labelHelp_Click;
            // 
            // labelHelp4
            // 
            resources.ApplyResources(labelHelp4, "labelHelp4");
            labelHelp4.AutoEllipsis = true;
            labelHelp4.BackColor = System.Drawing.Color.Yellow;
            labelHelp4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp4.Name = "labelHelp4";
            labelHelp4.Click += labelHelp_Click;
            // 
            // labelLinkTestResult
            // 
            resources.ApplyResources(labelLinkTestResult, "labelLinkTestResult");
            labelLinkTestResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            labelLinkTestResult.Name = "labelLinkTestResult";
            // 
            // numericLinkIgnoreLastChars
            // 
            resources.ApplyResources(numericLinkIgnoreLastChars, "numericLinkIgnoreLastChars");
            numericLinkIgnoreLastChars.Name = "numericLinkIgnoreLastChars";
            numericLinkIgnoreLastChars.ValueChanged += textBoxLink_TextChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // numericLinkIgnoreFirstChars
            // 
            resources.ApplyResources(numericLinkIgnoreFirstChars, "numericLinkIgnoreFirstChars");
            numericLinkIgnoreFirstChars.Name = "numericLinkIgnoreFirstChars";
            numericLinkIgnoreFirstChars.ValueChanged += textBoxLink_TextChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // numericLinkPartNumber
            // 
            resources.ApplyResources(numericLinkPartNumber, "numericLinkPartNumber");
            numericLinkPartNumber.Name = "numericLinkPartNumber";
            numericLinkPartNumber.ValueChanged += textBoxLink_TextChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // textBoxLinkTestFilename
            // 
            resources.ApplyResources(textBoxLinkTestFilename, "textBoxLinkTestFilename");
            textBoxLinkTestFilename.Name = "textBoxLinkTestFilename";
            textBoxLinkTestFilename.TextChanged += textBoxLink_TextChanged;
            // 
            // textBoxLinkPrefix
            // 
            resources.ApplyResources(textBoxLinkPrefix, "textBoxLinkPrefix");
            textBoxLinkPrefix.Name = "textBoxLinkPrefix";
            textBoxLinkPrefix.TextChanged += textBoxLink_TextChanged;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // textBoxLinkSeparator
            // 
            resources.ApplyResources(textBoxLinkSeparator, "textBoxLinkSeparator");
            textBoxLinkSeparator.Name = "textBoxLinkSeparator";
            textBoxLinkSeparator.TextChanged += textBoxLink_TextChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // checkBoxEnabledForLinkedFiles
            // 
            resources.ApplyResources(checkBoxEnabledForLinkedFiles, "checkBoxEnabledForLinkedFiles");
            checkBoxEnabledForLinkedFiles.Checked = true;
            checkBoxEnabledForLinkedFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnabledForLinkedFiles.Name = "checkBoxEnabledForLinkedFiles";
            checkBoxEnabledForLinkedFiles.UseVisualStyleBackColor = true;
            checkBoxEnabledForLinkedFiles.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // groupBox5
            // 
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.Controls.Add(textBoxDwgWorksetName);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(checkBoxEnabledForDwgLinks);
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // textBoxDwgWorksetName
            // 
            resources.ApplyResources(textBoxDwgWorksetName, "textBoxDwgWorksetName");
            textBoxDwgWorksetName.Name = "textBoxDwgWorksetName";
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // checkBoxEnabledForDwgLinks
            // 
            resources.ApplyResources(checkBoxEnabledForDwgLinks, "checkBoxEnabledForDwgLinks");
            checkBoxEnabledForDwgLinks.Checked = true;
            checkBoxEnabledForDwgLinks.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnabledForDwgLinks.Name = "checkBoxEnabledForDwgLinks";
            checkBoxEnabledForDwgLinks.UseVisualStyleBackColor = true;
            checkBoxEnabledForDwgLinks.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // groupBox6
            // 
            resources.ApplyResources(groupBox6, "groupBox6");
            groupBox6.Controls.Add(dataGridViewTypes);
            groupBox6.Controls.Add(checkBoxEnableByType);
            groupBox6.Name = "groupBox6";
            groupBox6.TabStop = false;
            // 
            // dataGridViewTypes
            // 
            resources.ApplyResources(dataGridViewTypes, "dataGridViewTypes");
            dataGridViewTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.CellContentClick += dataGridViewByType_CellContentClick;
            dataGridViewTypes.EnabledChanged += dataGridView_EnabledChanged;
            // 
            // checkBoxEnableByType
            // 
            resources.ApplyResources(checkBoxEnableByType, "checkBoxEnableByType");
            checkBoxEnableByType.Checked = true;
            checkBoxEnableByType.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxEnableByType.Name = "checkBoxEnableByType";
            checkBoxEnableByType.UseVisualStyleBackColor = true;
            checkBoxEnableByType.CheckedChanged += chkbxInGroup_CheckedChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1 });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // labelHelp3
            // 
            resources.ApplyResources(labelHelp3, "labelHelp3");
            labelHelp3.AutoEllipsis = true;
            labelHelp3.BackColor = System.Drawing.Color.Yellow;
            labelHelp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelHelp3.Name = "labelHelp3";
            labelHelp3.Click += labelHelp_Click;
            // 
            // buttonReset
            // 
            resources.ApplyResources(buttonReset, "buttonReset");
            buttonReset.Name = "buttonReset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelHelp0
            // 
            labelHelp0.AutoEllipsis = true;
            labelHelp0.BackColor = System.Drawing.Color.Yellow;
            labelHelp0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(labelHelp0, "labelHelp0");
            labelHelp0.Name = "labelHelp0";
            labelHelp0.Click += labelHelp_Click;
            // 
            // checkBoxNoEmptyWorksets
            // 
            resources.ApplyResources(checkBoxNoEmptyWorksets, "checkBoxNoEmptyWorksets");
            checkBoxNoEmptyWorksets.Name = "checkBoxNoEmptyWorksets";
            checkBoxNoEmptyWorksets.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AcceptButton = buttonOk;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonCancel;
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
            Name = "FormMain";
            ShowIcon = false;
            ShowInTaskbar = false;
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