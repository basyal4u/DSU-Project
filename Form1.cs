using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            sourcesUnits.SetSelected(0, true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string NUM_FORMAT = "N3";
            double sourceDistance;
            if (!Double.TryParse(measureInput.Text, out sourceDistance))
            {
                MessageBox.Show("The distance must be numeric", "Input Error");
            }
            else
            {
                string sourceUnit = sourcesUnits.SelectedItem.ToString();
                string targetUnits = "";
               if (radioButtonFeet.Checked)
                {
                    targetUnits = "Feet";
                }
                else if (radioButtonInches.Checked)
                {
                    targetUnits = "Inches";
                }
               else
                {
                    targetUnits = "Yards";
                }

               if (sourceUnit == targetUnits)
                {
                    measureOutput.Text = sourceDistance.ToString(NUM_FORMAT);
                }    
              else
                {
                    string conversionType = sourceUnit + "To" + targetUnits;
                    double measureIn = double.Parse(measureInput.Text);
                    double result = 0.0;
                    switch (conversionType)
                    {
                        case "InchesToFeet":
                            result = measureIn / 12.0; 
                            break;
                        case "InchesToYards":
                            result = measureIn / 36.0;
                            break;
                        case "FeetToInches":
                            result = measureIn * 12.0;
                            break;
                        case "FeetToYards":
                            result = measureIn / 3.0;
                            break;
                        case "YardsToInches":
                            result = measureIn * 36.0;
                            break;
                        case "YardsToFeet":
                            result = measureIn * 3.0;
                            break;                       
                    }
                    measureOutput.Text = Math.Round(result, 3).ToString(NUM_FORMAT);
                } 
            }
          

        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonInches_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sourcesUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
