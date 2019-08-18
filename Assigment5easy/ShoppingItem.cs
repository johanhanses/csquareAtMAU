using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    class ShoppingItem
    {
        private string description;
        private double amount;
        private UnitTypes unit;



        /// <summary>
        /// constructor with three params
        /// </summary>
        /// <param name="name">input, name and description of item</param>
        /// <param name="amount">input, amount of item(s)</param>
        /// <param name="unit">input, type of unit</param>
        public ShoppingItem(string name, double amount, UnitTypes unit)
        {
            this.description = name;
            this.amount = amount;
            this.unit = unit;
        }

        /// <summary>
        /// default constructor, sets some default params
        /// </summary>
        public ShoppingItem(): this("Unknown", 1.0, UnitTypes.piece)
        {

        }

        /// <summary>
        /// Constructor for one usergiven param. 
        /// </summary>
        /// <param name="description">input from user</param>
        public ShoppingItem(string description) : this(description, 1.0, UnitTypes.piece)
        {

        }

        /// <summary>
        /// constructor for creating a copy of an existing obj
        /// </summary>
        /// <param name="theOtherObj">the object to copy</param>
        public ShoppingItem(ShoppingItem theOtherObj)
        {
            this.description = theOtherObj.description;
            this.amount = theOtherObj.amount;
            this.unit = theOtherObj.unit;
        }



        //properties/get-set
        public string Description
        {
            get { return this.description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.description = value;
            }
        }

        public double Amount
        {
            get { return this.amount; }
            set
            {
                if (value >= 0)
                    this.amount = value;
            }
        }

        public UnitTypes Unit
        {
            get { return this.unit; }
            set
            {
                if (Enum.IsDefined(typeof(UnitTypes), value))
                    this.unit = value; 
            }
        }

        /// <summary>
        /// format how user input is displayed to user
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string textOut = string.Empty;
            textOut = $"{this.description,-45} {this.amount,6:f2} {unit,-6}";
            return textOut;
        }
    }
}
