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
    public partial class table3 : MaterialForm
    {
        public table3()
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

        private void table3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Экипажи". При необходимости она может быть перемещена или удалена.
            this.экипажиTableAdapter.Fill(this.airportDataSet.Экипажи);

        }

        private void экипажиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.экипажиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            экипажиBindingSource.Filter = "`НалетаноЧасов`='" + comboBox1.Text + "'";
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            экипажиBindingSource.Filter = "";
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < экипажиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < экипажиDataGridView.RowCount; j++)
                {
                    экипажиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    экипажиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }

            for (i = 0; i < экипажиDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < экипажиDataGridView.RowCount; j++)
                {
                    var value = экипажиDataGridView.Rows[j].Cells[i].Value;

                    if (value != null)
                    {
                        string baseStr = value.ToString();

                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            экипажиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            экипажиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
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
                экипажиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                экипажиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }
    }
}
