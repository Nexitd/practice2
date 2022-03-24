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
    public partial class Form7 : MaterialForm
    {


        public Form7()
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

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.airportDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.ТипыСамолетов". При необходимости она может быть перемещена или удалена.
            this.типыСамолетовTableAdapter.Fill(this.airportDataSet.ТипыСамолетов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Самолеты". При необходимости она может быть перемещена или удалена.
            this.самолетыTableAdapter.Fill(this.airportDataSet.Самолеты);

        }

        private void самолетыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.самолетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.самолетыBindingSource.MovePrevious();
        }

        private void materialFlatButton8_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void materialFlatButton4_Click_1(object sender, EventArgs e)
        {
            this.самолетыBindingSource.MoveNext();
        }

        private void materialFlatButton6_Click_1(object sender, EventArgs e)
        {
            this.самолетыBindingSource.RemoveCurrent();
        }

        private void materialFlatButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.самолетыBindingSource.EndEdit();
                this.самолетыTableAdapter.Update(this.airportDataSet);
                MessageBox.Show("Update successful");
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.самолетыBindingSource.AddNew();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Airoport.table8 frm = new Airoport.table8();
            frm.Show();
        }
    }


}