using System;
using System.Windows.Forms;

namespace MVC_Pattern_Example
{
    public partial class Form1 : Form
    {
        int value = 0;

        public Form1()
        {
            InitializeComponent();
            lblValue.Text = "Value : " + value.ToString();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            //Make some operations here and update the model
            value = (value * 3) + 4;
            //And update the View through the related model
            lblValue.Text = "Value : " + value.ToString();
        }
    }
}
