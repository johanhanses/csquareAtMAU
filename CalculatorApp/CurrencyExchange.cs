using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class CurrencyExchange
    {
        //private string fromCurrencyName;
        //private string toCurrencyName;
        private double exchangeRate; //1 from = x to
        private double amountToExchange;


        //Getters and Setters
        public double GetExchangeRate()
        {
            return this.exchangeRate;
        }

        public double GetAmountToExchange()
        {
            return this.amountToExchange;
        }

        public void SetAmountToExchange(double amount)
        {
            if (amount > 0.0)
                this.amountToExchange = amount;
        }

        public void SetExchangeRate(double rate)
        {
            if (rate > 0.0)
                this.exchangeRate = rate;
        }


        /// <summary>
        /// Converts the amountToExchange to the new currency
        /// </summary>
        /// <returns>the converted amount</returns>
        public double CalculateNewAmount()
        {
            double amount = 0.0;

            if (this.exchangeRate > 0.0)
                amount = this.amountToExchange / this.exchangeRate;

            return amount;
        }

    }
}
