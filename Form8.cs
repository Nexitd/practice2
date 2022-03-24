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
    public partial class Form8 : MaterialForm
    {


        public Form8()
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

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.ТипыСамолетов". При необходимости она может быть перемещена или удалена.
            this.типыСамолетовTableAdapter.Fill(this.airportDataSet.ТипыСамолетов);

        }

        private void типыСамолетовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типыСамолетовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.типыСамолетовBindingSource.MovePrevious();
        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.типыСамолетовBindingSource.MoveNext();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            this.типыСамолетовBindingSource.RemoveCurrent();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.типыСамолетовBindingSource.EndEdit();
                this.типыСамолетовTableAdapter.Update(this.airportDataSet);
                MessageBox.Show("Update successful");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }


        }

        private void materialFlatButton2_Click_1(object sender, EventArgs e)
        {
            this.типыСамолетовBindingSource.AddNew();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Airoport.table7 frm = new Airoport.table7();
            frm.Show();
        }
    }


}
