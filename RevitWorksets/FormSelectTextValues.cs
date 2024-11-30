﻿#region License
/*Данный код опубликован под лицензией Creative Commons Attribution-ShareAlike.
Разрешено использовать, распространять, изменять и брать данный код за основу для производных в коммерческих и
некоммерческих целях, при условии указания авторства и если производные лицензируются на тех же условиях.
Код поставляется "как есть". Автор не несет ответственности за возможные последствия использования.
Зуев Александр, 2020, все права защищены.
This code is listed under the Creative Commons Attribution-ShareAlike license.
You may use, redistribute, remix, tweak, and build upon this work non-commercially and commercially,
as long as you credit the author by linking back and license your new creations under the same terms.
This code is provided 'as is'. Author disclaims any implied warranty.
Zuev Aleksandr, 2020, all rigths reserved.*/
#endregion
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RevitWorksets
{
    public partial class FormSelectTextValues : Form
    {
        public List<string> ResultValues { get; set; }


        public FormSelectTextValues(string title, List<string> values)
        {
            InitializeComponent();

            labelTitle.Text = title;

            dataGridView1.Rows.Clear();
            foreach (string value in values)
            {
                dataGridView1.Rows.Add(value);
            }

            dataGridView1.AllowUserToAddRows = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ResultValues = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string value = row.Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(value)) continue;
                ResultValues.Add(value);
            }

            if (ResultValues == null || ResultValues.Count == 0)
            {
                MessageBox.Show(MyStrings.MessageToCheckboxesChecked);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
