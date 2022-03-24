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
    public partial class Form3 : MaterialForm
    {


        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.экипажиBindingSource.MovePrevious();
        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialFlatButton4_Click_1(object sender, EventArgs e)
        {
            this.экипажиBindingSource.MoveNext();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            this.экипажиBindingSource.RemoveCurrent();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.экипажиBindingSource.EndEdit();
                this.экипажиTableAdapter.Update(this.airportDataSet);
                MessageBox.Show("Update successful");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }


        }

        private void materialFlatButton2_Click_1(object sender, EventArgs e)
        {
            this.экипажиBindingSource.AddNew();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Airoport.table3 frm = new Airoport.table3();
            frm.Show();

        }
    }


}
