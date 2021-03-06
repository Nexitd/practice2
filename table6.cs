using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;

namespace Airoport
{
    public partial class table6 : MaterialForm
    {
        public table6()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void table6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.airportDataSet.Билеты);

        }

        private void билетыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.билетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            билетыBindingSource.Filter = "`Место`='" + comboBox1.Text + "'";
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            билетыBindingSource.Filter = "";
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < билетыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < билетыDataGridView.RowCount; j++)
                {
                    билетыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    билетыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }

            for (i = 0; i < билетыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < билетыDataGridView.RowCount; j++)
                {
                    var value = билетыDataGridView.Rows[j].Cells[i].Value;

                    if (value != null)
                    {
                        string baseStr = value.ToString();

                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            билетыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            билетыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialFlatButton1.Enabled = true;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn5;
                    break;
            }

            if (materialRadioButton1.Checked)
            {
                билетыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                билетыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }
    }
}
