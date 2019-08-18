using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3G
{
    class BMICalculator
    {
        private string name = "No Name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string value)
        {
            if (!string.IsNullOrEmpty(value))
                this.name = value;
        }

        public double GetHeight()
        {
            return this.height;
        }

        public void SetHeight(double value)
        {
            if (value > 0)
                this.height = value;
        }

        public double GetWeight()
        {
            return this.weight;
        }

        public void SetWeight(double value)
        {
            if (value > 0)
                this.weight = value;
        }

        public UnitTypes GetUnit()
        {
            return this.unit;
        }

        public void SetUnit(UnitTypes value)
        {
            this.unit = value;
        }

        public double CalculateBMI()
        {
            double bmiValue = 0.0;
            double factor = 0.0;

            if (unit == UnitTypes.American)
            {

                factor = 703.0;
            }
            else
            {
                factor = 1.0;
            }

            bmiValue = factor * this.weight / (this.height * this.height);

            return bmiValue;
        }

        public string BMIWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringOut = string.Empty;
            if (bmi > 40)
                stringOut = "Overweight (Obesity class III)";
            else if (bmi < 40 && bmi > 34.9)
                stringOut = "Overweight (Obesity class II)";
            else if (bmi < 35 && bmi > 29.9)
                stringOut = "Overweight (Obesity class I)";
            else if (bmi < 30 && bmi > 24.9)
                stringOut = "OverWeight (Pre-obesity)";
            else if (bmi < 25 && bmi > 18.4)
                stringOut = "Normal Weight";
            else
                stringOut = "Underweigth";

            return stringOut;
        }
    }
}
