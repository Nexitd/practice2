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
    public partial class Form5 : MaterialForm
    {


        public Form5()
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

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Самолеты". При необходимости она может быть перемещена или удалена.
            this.самолетыTableAdapter.Fill(this.airportDataSet.Самолеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Экипажи". При необходимости она может быть перемещена или удалена.
            this.экипажиTableAdapter.Fill(this.airportDataSet.Экипажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.airportDataSet.Рейсы);

        }

        private void рейсыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рейсыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.MovePrevious();
        }

        private void materialFlatButton8_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.MoveNext();
        }

        private void materialFlatButton6_Click_1(object sender, EventArgs e)
        {
            this.рейсыBindingSource.RemoveCurrent();
        }

        private void materialFlatButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.рейсыBindingSource.EndEdit();
                this.рейсыTableAdapter.Update(this.airportDataSet);
                MessageBox.Show("Update successful");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.AddNew();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Airoport.table5 frm = new Airoport.table5();
            frm.Show();
        }
    }


}
