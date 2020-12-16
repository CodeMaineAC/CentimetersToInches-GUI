using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentimetersToInches_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conversionButton_Click(object sender, EventArgs e)
        {
            const double CENTIMETERS_PER_INCH = 2.54;

            if(Double.TryParse(inchesBox.Text,out double inches))
            {
                OutputToCentimeters.Visible = true;
                OutputToCentimeters.Text =
                    string.Format("{0} inches is\n {1:F4} centimeters",
                    inches, inches * CENTIMETERS_PER_INCH);
            }
            else
            {
                MessageBox.Show("ERROR:\nINVALID INPUT"); //error popup
            }


        }

        private void convToInchesButton_Click(object sender, EventArgs e)
        {
            const double CENTIMETERS_PER_INCH = 2.54;

            if (Double.TryParse(centimeterBox.Text, out double CM))
            {
                OutputToCentimeters.Visible = true;
                OutputToCentimeters.Text =
                    string.Format("{0} cm is \n{1:F4} inches",
                    CM, CM / CENTIMETERS_PER_INCH);
            }
            else
            {
                MessageBox.Show("ERROR:\nINVALID INPUT"); //error popup
            }
        }
    }
}
