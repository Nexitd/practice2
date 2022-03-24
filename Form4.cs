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

namespace Sandbox
{
    public partial class Form4 : MaterialForm
    {


        public Form4()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.airportDataSet.Должности);

        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MovePrevious();
        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.MoveNext();
        }

        private void materialFlatButton6_Click_1(object sender, EventArgs e)
        {
            this.должностиBindingSource.RemoveCurrent();
        }

        private void materialFlatButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.должностиBindingSource.EndEdit();
                this.должностиTableAdapter.Update(this.airportDataSet);
                MessageBox.Show("Update successful");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.должностиBindingSource.AddNew();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Airoport.table4 frm = new Airoport.table4();
            frm.Show();
        }
    }


}
