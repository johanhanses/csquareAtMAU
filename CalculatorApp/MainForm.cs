using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        CurrencyExchange converter = new CurrencyExchange();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }


        private void InitializeGUI()
        {
            this.Text = "Currency converter";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //read input
            bool ok = ReadInput();
            //calculate and display result
            if (ok)
            {
                double convertedAmount = converter.CalculateNewAmount();
                lblResult.Text = convertedAmount.ToString("0.00");
            }

            //display result
            //if (ok)
            //    UpdateGUI();
        }

        private bool ReadInput()
        {
            //read amount and exchange rate
            bool amountOK = ReadAmount();
            bool rateOK = ReadExchangeRate();

            return amountOK && rateOK;
        }

        private bool ReadAmount()
        {
            bool ok = true;
            string strAmount = txtAmount.Text;
            strAmount = strAmount.Trim();
            double amount = 0.0;

            ok = double.TryParse(strAmount, out amount);
            if (ok)
                converter.SetAmountToExchange(amount);
            else
                MessageBox.Show("Invalid amount!", "Error");
                //ok = false;

            return ok;
        }

        private bool ReadExchangeRate()
        {
            bool ok = true;
            string strRate = txtRate.Text;
            strRate = strRate.Trim();
            double amount = 0.0;

            ok = double.TryParse(strRate, out amount);
            if (ok)
                converter.SetExchangeRate(amount);
            else
                MessageBox.Show("Invalid exchange rate!", "Error");

            return ok;
        }
    }
}
