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
    public partial class Form1 : MaterialForm
    {

        
        public Form1()
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();

        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }

       

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
        }

        private void materialFlatButton12_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton11_Click(object sender, EventArgs e)
        {
            Airoport.reqtable1 frm = new Airoport.reqtable1();
            frm.Show();
        }

        private void materialFlatButton10_Click(object sender, EventArgs e)
        {
            Airoport.reqtable2 frm = new Airoport.reqtable2();
            frm.Show();
        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            Airoport.reqtable3 frm = new Airoport.reqtable3();
            frm.Show();
        }

        private void materialFlatButton9_Click(object sender, EventArgs e)
        {
            Airoport.reqtable4 frm = new Airoport.reqtable4();
            frm.Show();
        }

        private void materialFlatButton12_Click_1(object sender, EventArgs e)
        {
            Airoport.reqtable5 frm = new Airoport.reqtable5();
            frm.Show();
        }

        private void materialFlatButton14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialFlatButton13_Click(object sender, EventArgs e)
        {
            Airoport.about frm = new Airoport.about();
            frm.Show();
        }

        private void materialFlatButton15_Click(object sender, EventArgs e)
        {
            Airoport.chart frm = new Airoport.chart();
            frm.Show();
        }
    }

    
}
