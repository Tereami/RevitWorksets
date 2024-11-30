namespace RevitWorksets
{
    partial class FormSelectCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectCategories));
            buttonOk = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            checkedListBoxCats = new System.Windows.Forms.CheckedListBox();
            checkBoxHide = new System.Windows.Forms.CheckBox();
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
            // checkedListBoxCats
            // 
            resources.ApplyResources(checkedListBoxCats, "checkedListBoxCats");
            checkedListBoxCats.CheckOnClick = true;
            checkedListBoxCats.FormattingEnabled = true;
            checkedListBoxCats.Name = "checkedListBoxCats";
            // 
            // checkBoxHide
            // 
            resources.ApplyResources(checkBoxHide, "checkBoxHide");
            checkBoxHide.Name = "checkBoxHide";
            checkBoxHide.UseVisualStyleBackColor = true;
            checkBoxHide.CheckedChanged += checkBoxHide_CheckedChanged;
            // 
            // FormSelectCategories
            // 
            AcceptButton = buttonOk;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonCancel;
            Controls.Add(checkBoxHide);
            Controls.Add(checkedListBoxCats);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "FormSelectCategories";
            ShowIcon = false;
            ShowInTaskbar = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckedListBox checkedListBoxCats;
        private System.Windows.Forms.CheckBox checkBoxHide;
    }
}