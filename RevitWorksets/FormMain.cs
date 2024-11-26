using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace RevitWorksets
{
    public partial class FormMain : Form
    {
        public InfosStorage Model { get; set; }

        List<RevitCategory> AllCategories { get; set; }
        public string XmlPath { get; set; }
        public FormMain(InfosStorage newSettings, string xmlPath, List<RevitCategory> allCategories)
        {
            Debug.WriteLine("Initialize main window");
            InitializeComponent();

            XmlPath = xmlPath;
            AllCategories = allCategories;
            Model = newSettings;

            BuildWindow();

            CreateButtonColumn(dataGridViewCategories, "Категории", nameof(WorksetByCategory.CategoriesText), Model.worksetsByCategory);
            CreateButtonColumn(dataGridViewFamilies, "Семейства", nameof(WorksetByFamily.FamiliesText), Model.worksetsByFamily);
            CreateButtonColumn(dataGridViewTypes, "Имена типов", nameof(WorksetByType.TypesText), Model.worksetsByType);

            Debug.WriteLine("Initialized main window");
        }

        private void CreateButtonColumn(DataGridView table, string header, string name, object source)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn()
            {
                DataPropertyName = name,
                HeaderText = header,
                Name = name,
                FillWeight = 200,
            };
            table.Columns.Add(buttonColumn);
            table.DataSource = source;
            table.Columns[name].DisplayIndex = table.Columns.Count - 1;
        }


        private void chkbxInGroup_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox curChkBox = sender as CheckBox;
            GroupBox grbx = curChkBox.Parent as GroupBox;
            foreach (Control child in grbx.Controls)
            {
                if (child == curChkBox) continue;
                child.Enabled = curChkBox.Checked;
            }
        }

        private void dataGridView_EnabledChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (!dgv.Enabled)
            {
                dgv.DefaultCellStyle.BackColor = SystemColors.Control;
                dgv.DefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgv.CurrentCell = null;
                dgv.ReadOnly = true;
                dgv.EnableHeadersVisualStyles = false;
            }
            else
            {
                dgv.DefaultCellStyle.BackColor = SystemColors.Window;
                dgv.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Window;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgv.ReadOnly = false;
                dgv.EnableHeadersVisualStyles = true;
            }
        }

        private void FormMain_HelpButtonClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bim-starter.com/plugins/worksets");
        }


        private void BuildWindow()
        {
            if (string.IsNullOrEmpty(XmlPath))
            {
                toolStripStatusLabel1.Text = "Файл настроек не найден, заданы настройки по умолчанию";
                XmlPath = Path.Combine(InfosStorage.GetDefaultStorageFolder(), "worksets.xml");
                MakeHelpLabelsVisible(true);
            }
            else
            {
                toolStripStatusLabel1.Text = "Загружено из файла: " + XmlPath;
            }


            checkBoxEnabledByCategory.Checked = Model.WorksetByCetagoryEnabled;

            checkBoxEnableByFamilyName.Checked = Model.WorksetByFamilyEnabled;

            checkBoxEnableByType.Checked = Model.WorksetByTypeEnabled;

            checkBoxEnabledByParameter.Checked = Model.WorksetByParameterEnabled;
            textBoxWorksetNameParameter.Text = Model.worksetByParameter.ParameterName;

            checkBoxEnabledForLinkedFiles.Checked = Model.WorksetByLinkEnabled;
            textBoxLinkSeparator.Text = Model.worksetByLink.separator;
            numericLinkPartNumber.Value = Model.worksetByLink.partNumberAfterSeparator;
            numericLinkIgnoreFirstChars.Value = Model.worksetByLink.ignoreFirstCharsAfterSeparation;
            numericLinkIgnoreLastChars.Value = Model.worksetByLink.ignoreLastCharsAfterSeparation;
            textBoxLinkPrefix.Text = Model.worksetByLink.prefixForLinkWorksets;

            checkBoxEnabledForDwgLinks.Checked = Model.WorksetByDwgEnabled;
            textBoxDwgWorksetName.Text = Model.worksetByDwg.WorksetName;

            refreshLinkWorksetName();
        }

        private void UpdateModel()
        {
            Model.WorksetByCetagoryEnabled = checkBoxEnabledByCategory.Checked;

            Model.WorksetByFamilyEnabled = checkBoxEnableByFamilyName.Checked;

            Model.WorksetByParameterEnabled = checkBoxEnabledByParameter.Checked;
            Model.worksetByParameter.ParameterName = textBoxWorksetNameParameter.Text;

            Model.WorksetByLinkEnabled = checkBoxEnabledForLinkedFiles.Checked;
            Model.worksetByLink.separator = textBoxLinkSeparator.Text;
            Model.worksetByLink.partNumberAfterSeparator = (int)numericLinkPartNumber.Value;
            Model.worksetByLink.ignoreFirstCharsAfterSeparation = (int)numericLinkIgnoreFirstChars.Value;
            Model.worksetByLink.ignoreLastCharsAfterSeparation = (int)numericLinkIgnoreLastChars.Value;
            Model.worksetByLink.prefixForLinkWorksets = textBoxLinkPrefix.Text;

            Model.WorksetByDwgEnabled = checkBoxEnabledForDwgLinks.Checked;
            Model.worksetByDwg.WorksetName = textBoxDwgWorksetName.Text;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string lastUsedFolder = Path.GetDirectoryName(XmlPath);

            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.InitialDirectory = lastUsedFolder;
            dialog.Multiselect = false;
            dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            XmlPath = dialog.FileName;
            InfosStorage.SaveLastUsedXmlPath(XmlPath);

            Model = InfosStorage.LoadFromFile(XmlPath);
            BuildWindow();

            Debug.WriteLine("Xml path: " + XmlPath);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(XmlPath);
            string lastUsedFolder = Path.GetDirectoryName(XmlPath);

            System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog();
            dialog.InitialDirectory = lastUsedFolder;
            dialog.FileName = fileName;
            dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            XmlPath = dialog.FileName;
            toolStripStatusLabel1.Text = "Сохранено в файл: " + XmlPath;
            Model.Save(XmlPath);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("OK clicked");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("CANCEL clicked");
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void refreshLinkWorksetName()
        {
            UpdateModel();
            string sampleFilename = textBoxLinkTestFilename.Text;
            string worksetName = Model.worksetByLink.GetWorksetName(sampleFilename);
            label1LinkTestResult.Text = worksetName;
        }

        private void textBoxLink_KeyUp(object sender, KeyEventArgs e)
        {
            refreshLinkWorksetName();
        }


        private void numericLink_Click(object sender, EventArgs e)
        {
            refreshLinkWorksetName();
        }

        private void dataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNumber = datagridViewCellClickHandler(sender, e);

            WorksetByCategory clickedRow = Model.worksetsByCategory[e.RowIndex];
            if (clickedRow.revitCategories == null)
                clickedRow.revitCategories = new List<Autodesk.Revit.DB.BuiltInCategory>();


            FormSelectCategories formSelect = new FormSelectCategories(clickedRow.revitCategories, AllCategories);
            if (formSelect.ShowDialog() != DialogResult.OK)
                return;

            clickedRow.revitCategories = formSelect.SelectedCategories;
            this.Refresh();
        }


        private void dataGridViewFamilies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNumber = datagridViewCellClickHandler(sender, e);
            WorksetByFamily clickedRow = Model.worksetsByFamily[rowNumber];

            FormSelectTextValues formSelect = new FormSelectTextValues("Задайте префиксы имен семейств", clickedRow.FamilyNames);
            if (formSelect.ShowDialog() != DialogResult.OK) return;

            clickedRow.FamilyNames = formSelect.ResultValues;
            this.Refresh();
        }

        private void dataGridViewByType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNumber = datagridViewCellClickHandler(sender, e);
            WorksetByType clickedRow = Model.worksetsByType[rowNumber];

            FormSelectTextValues formSelect = new FormSelectTextValues("Задайте префиксы имен типов", clickedRow.TypeNames);
            if (formSelect.ShowDialog() != DialogResult.OK) return;

            clickedRow.TypeNames = formSelect.ResultValues;
            this.Refresh();
        }

        private int datagridViewCellClickHandler(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView ?? throw new Exception("DataGridView cast error");
            if (!(dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
                return -1;
            int rowNumber = e.RowIndex;
            return rowNumber;
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            MakeHelpLabelsVisible(false);
        }

        private void MakeHelpLabelsVisible(bool visible)
        {
            labelHelp1.Visible = visible;
            labelHelp2.Visible = visible;
            labelHelp3.Visible = visible;
            labelHelp4.Visible = visible;
            labelHelp5.Visible = visible;
            labelHelp6.Visible = visible;
        }
    }
}
