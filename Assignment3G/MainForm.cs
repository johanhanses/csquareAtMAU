using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3G
{
    public partial class MainForm : Form
    {
        //create an instance/object of BMIcalculator class
        private BMICalculator bmiCalc = new BMICalculator();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "BMI Calculator";

            //input controls
            rbtnUsUnit.Checked = true;
            lblHeight.Text = "Height (feet)";
            lblWeight.Text = "Weight (lbs)";

            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;

        }

        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWeight.Text = "Weight (kg)";
                bmiCalc.SetUnit(UnitTypes.Metric);
            }
        }

        private void RbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height (foot)";
                lblWeight.Text = "Weight (lbs)";
                bmiCalc.SetUnit(UnitTypes.American);
            }
        }

        /// <summary>
        /// Event handler for calculate button
        /// </summary>
        private void BtnCalculateBMI_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                DisplayResults();//calculate and display results
            }

        }
        /// <summary>
        /// validate user input
        /// </summary>
        /// <returns>bool</returns>
        private bool ReadInputBMI()
        {
            bool isInputOk = false;

            ReadName();
            ReadUnitType();
            isInputOk = ReadHeight();
            isInputOk = isInputOk && ReadWeight();

            return isInputOk;
        }

        private void ReadUnitType()
        {
            if (rbtnMetric.Checked)
                bmiCalc.SetUnit(UnitTypes.Metric);
            else
                bmiCalc.SetUnit(UnitTypes.American);
        }

        private void ReadName()
        {
            txtName.Text.Trim(); //removes whitespace before and after string

            if (!string.IsNullOrEmpty(txtName.Text))
                bmiCalc.SetName(txtName.Text);
            else
                bmiCalc.SetName("Unknown");

        }

        private bool ReadHeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(txtHeight.Text, out outValue);

            if (ok)
            {
                if (outValue > 0)
                {
                    if (bmiCalc.GetUnit() == UnitTypes.American)
                    {
                        bmiCalc.SetHeight(outValue * 12.00);//feet to inches
                        MessageBox.Show(outValue.ToString());

                    }
                    else
                    {
                        bmiCalc.SetHeight(outValue / 100.00); //cm to m
                    }
                }
                else
                    ok = false;
            }

            if (!ok)
                MessageBox.Show("Invalid height value!", "Error");
            return ok;
        }

        private bool ReadWeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(txtWeight.Text, out outValue);

            if (ok)
            {
                if (outValue > 0)
                {
                    bmiCalc.SetWeight(outValue);
                }
                else
                    ok = false;
            }

            if (!ok)
                MessageBox.Show("Invalid weight value!", "Error");
            return ok;
        }

        private void DisplayResults()
        {
            lblResultYourBMI.Text = bmiCalc.CalculateBMI().ToString("f2");
            lblResultWeightCategory.Text = bmiCalc.BMIWeightCategory().ToString();
            grpResults.Text = "Results for " + bmiCalc.GetName();   
        }
    }
}
