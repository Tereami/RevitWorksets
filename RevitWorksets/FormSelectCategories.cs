using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RevitWorksets
{
    public partial class FormSelectCategories : Form
    {
        public List<Autodesk.Revit.DB.BuiltInCategory> SelectedCategories;
        public List<RevitCategory> AllCategories;

        public FormSelectCategories(List<Autodesk.Revit.DB.BuiltInCategory> selectedCategories, List<RevitCategory> allCategories)
        {
            InitializeComponent();

            AllCategories = allCategories;
            SelectedCategories = selectedCategories;

            WriteRows(AllCategories, selectedCategories);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ReadSelectedRows();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ReadSelectedRows()
        {
            SelectedCategories = checkedListBoxCats
                .CheckedItems
                .Cast<RevitCategory>()
                .Select(c => c.InternalCategory)
                .ToList();

            if (SelectedCategories.Count == 0)
            {
                MessageBox.Show("Не выбраны категории!");
                return;
            }
        }

        private void WriteRows(List<RevitCategory> VisibleCategories, List<Autodesk.Revit.DB.BuiltInCategory> SelectedCategories)
        {
            checkedListBoxCats.Items.Clear();
            for (int i = 0; i < VisibleCategories.Count; i++)
            {
                RevitCategory item = VisibleCategories[i];
                checkedListBoxCats.Items.Add(item);

                if (SelectedCategories.Contains(item.InternalCategory))
                {
                    checkedListBoxCats.SetItemChecked(i, true);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBoxHide_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            ReadSelectedRows();

            if (check.Checked)
            {
                List<RevitCategory> visibleCategories = AllCategories
                    .Where(i => SelectedCategories.Contains(i.InternalCategory))
                    .ToList();
                WriteRows(visibleCategories, SelectedCategories);
            }
            else
            {
                WriteRows(AllCategories, SelectedCategories);
            }
        }
    }
}
