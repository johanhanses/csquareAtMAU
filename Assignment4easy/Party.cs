using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4easy
{
    class Party
    {
        private double costPerCapita;
        private string[] guestList;



        //constructor
        public Party (int maxNumOfGuests)
        {
            this.guestList = new string[maxNumOfGuests];
        }


        //get / set for number of guests
        public double CostPerCapita
        {
            get { return this.costPerCapita; }
            set
            {
                if (value >= 0)
                    this.costPerCapita = value;
            }   
        }

        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();

            if (vacantPos != -1)
            {
                this.guestList[vacantPos] = FullName(firstName, lastName);
            }
            else
                ok = false;

            return ok;
        }

        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName;
        }

        private int FindVacantPos()
        {
            int vacantPos = -1;

            for (int index = 0; index < this.guestList.Length; index++)
            {
                if (string.IsNullOrEmpty(this.guestList[index]))
                {
                    vacantPos = index;
                    break;
                }
            }

            return vacantPos;
        }

        private int NumOfGuests ()
        {
            int numGuests = 0;

            for (int i = 0; i < this.guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(this.guestList[i]))
                {
                    numGuests++;
                }
            }

            return numGuests;
        }

        public int Count
        {
            get { return NumOfGuests(); }
        }

        public double CalcTotalCost()
        {
            int numOfGuests = NumOfGuests();
            double totalCost = numOfGuests * this.costPerCapita;

            return totalCost;
        }

        public string[] GetGuestList()
        {
            //get num of guest from that method
            int size = NumOfGuests();

            // if num of guests == 0, then stop
            if (size <= 0)
                return null;

            string[] guests = new string[size];

            for (int i = 0, j = 0; i < this.guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(this.guestList[i]))
                {
                    guests[j++] = this.guestList[i];
                }
            }

            return guests;
        }

        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < this.guestList.Length); 
        }

        public string GetItemAt(int index)
        {
            if (CheckIndex(index))
                return this.guestList[index];

            return null;
        }

        public bool DeleteAt(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                this.guestList[index] = string.Empty;
                MoveElementsOneStepToLeft(index);
                ok = true;
            }

            return ok;
        }

        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index+1; i < this.guestList.Length; i++)
            {
                this.guestList[i - 1] = this.guestList[i];
                this.guestList[i] = string.Empty;
            }
        }

        
        //private bool ChangeAt(int index, string firstName, string lastName)
        //{
        //    bool ok = false;
        //    if (CheckIndex(index))
        //    {
        //        this.guestList[index] = FullName(firstName, lastName);
        //    }
        //    else
        //        ok = true;

        //    return ok;
        //} 
    }
}
