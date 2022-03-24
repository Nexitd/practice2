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
    public partial class chart : MaterialForm
    {
        public chart()
        {
            InitializeComponent();

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

        private void chart_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Оклад"].Points.AddXY("Пилот гражданской авиации",194000);
            this.chart1.Series["Оклад"].Points.AddXY("Бортпроводник", 106000);
            this.chart1.Series["Оклад"].Points.AddXY("Бортинженер", 100000);
            this.chart1.Series["Оклад"].Points.AddXY("IT-специалист", 90000);
            this.chart1.Series["Оклад"].Points.AddXY("Авиадиспетчер", 63000);
        }
    }
}
