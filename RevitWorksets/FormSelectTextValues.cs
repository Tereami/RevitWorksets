using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if(string.IsNullOrEmpty(value)) continue;
                ResultValues.Add(value);
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
