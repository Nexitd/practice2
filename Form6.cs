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
    public partial class Form6 : MaterialForm
    {


        public Form6()
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

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.airportDataSet.Рейсы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.airportDataSet.Билеты);

        }

        private void билетыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.билетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.билетыBindingSource.MovePrevious();
        }

        private void materialFlatButton8_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.билетыBindingSource.MoveNext();
        }

        private void materialFlatButton6_Click_1(object sender, EventArgs e)
        {
            this.билетыBindingSource.RemoveCurrent();
        }

        private void materialFlatButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.билетыBindingSource.EndEdit();
                this.билетыTableAdapter.Update(this.airportDataSet);
                MessageBox.Show("Update successful");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.билетыBindingSource.AddNew();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Airoport.table6 frm = new Airoport.table6();
            frm.Show();
        }
    }


}
