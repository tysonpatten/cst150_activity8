using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cast150Activity8
{
    public partial class Form1 : Form
    {

        // create method FatCalories(double fatGrams) that returns double fatCalories

        
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void button1_Click(object sender, EventArgs e) // on button click
        {
            try
            {
                fatCalories(inputFatGrams.Text); // call fatCalories method
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // display error message
            }
            carbCalories(inputCarbGrams.Text);

            try
            {
                carbCalories(inputCarbGrams.Text); // call carbCalories method
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // display error message
            }
        }

        

        private void fatCalories(string strFatGrams)
        {
            inputFatGrams.Text = strFatGrams; // get input from textbox
            double fatGrams = double.Parse(inputFatGrams.Text); // convert input to double
            double fatCalories = fatGrams * 9; // calculate fat calories
            outputFatCalories.Text = fatCalories.ToString(); // display fat calories
        }

        private void carbCalories(string strCarbGrams)
        {
            inputCarbGrams.Text = strCarbGrams; // get input from textbox
            double carbGrams = double.Parse(inputCarbGrams.Text); // convert input to double
            double carbCalories = carbGrams * 4; // calculate carb calories
            outputCarbCalories.Text = carbCalories.ToString(); // display carb calories
        }


    }
}
