using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class dialogbox : Form
    {
        public dialogbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public string Ntext
        {
            set
            {
                newtext.Text = value;
            }
            get
            {
                return newtext.Text;
            }
        }
        public Color Ncolor
        {
            set
            {
                colorDialog1.Color = value;
            }
            get
            {
                return colorDialog1.Color;
            }
        }

        public string fontchanger
        {
            set { 
            if (value == "Times New Roman")
            {
                font1.Checked = true;
            } else

               if (value == "Arial")
            {
                font2.Checked = true;
            }
            else if (value== "Courier")
            {
                font3.Checked = true;
            }
            }
            get { 
            if (font1.Checked == true)
            {
                return "Times New Roman";
            }
            else if (font2.Checked == true)
            {
                return "Arial";

            }
            else if (font3.Checked == true) {
                return "Courier";
            }
            else
            {
                return "Time New Roman";
            }
            }
        }
        public int fontsizer
        {
            set {
                if (value == 16)
                {
                    size1.Checked = true;
                }
                else if (value == 20)
                {
                    size2.Checked = true;
                }
                else if (value == 24)
                {
                    size3.Checked = true;
                } }
            get { 
            if (size1.Checked == true)
            {
                return 16;
            }
            
            else if (size2.Checked == true)
            {
                return 20;
            }
            else if (size3.Checked == true)
            {
                return 24;
            }
            else
            {
                return 0;
            }}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void font1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void newtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
