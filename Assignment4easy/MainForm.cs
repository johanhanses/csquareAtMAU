using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4easy
{
    public partial class MainForm : Form
    {
        Party party;



        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            //clear input
            txtMaxNum.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;

            //clear output
            lblNumGuest.Text = string.Empty;
            lblTotalCost.Text = "0.0";
            lstAllGuests.Items.Clear();

            //disable add guests group
            grpAddGuests.Enabled = false;

            //enable create new party grp
            grpNewParty.Enabled = true;
        }

        private void BtnCreateList_Click(object sender, EventArgs e)
        {
            bool maxNumOK = createParty();

            if (!maxNumOK)
                return; // stop

            bool amountÒK = ReadCostPerPerson();

            if (maxNumOK && amountÒK)
            {
                grpAddGuests.Enabled = true;
                UpdateGUI();
            }
        }

        private bool createParty()
        {
            int maxNumber = 0;
            bool ok = true;

            if (int.TryParse(txtMaxNum.Text, out maxNumber) && (maxNumber > 0))
            {
                party = new Party(maxNumber);
                MessageBox.Show($"Party list with space for {Test()}{maxNumber} guests created!", "Succes");
            }
            else
            {
                MessageBox.Show("Invalid Total number. Please try again!", "Error");
                ok = false;
            }
            return ok;
        }


        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if (double.TryParse(txtAmount.Text, out amount) && (amount > 0))
            {
                party.CostPerCapita = amount;
            }
            else
            {
                MessageBox.Show("Invalid amount. Please try again!", "Error");
                ok = false;
            }
            return ok;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TrimNames())
            {
                bool ok = party.AddNewGuest(txtFirstName.Text, txtLastName.Text);
                if (!ok)
                    MessageBox.Show("List is full! New guest not added!", "Error");
                else
                    UpdateGUI();
            }
        }

        private void UpdateGUI()
        {
            lstAllGuests.Items.Clear();
            string[] guestList = party.GetGuestList();

            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20}";
                    lstAllGuests.Items.Add(str);
                }
            }
            else
                return;

            double totalCost = party.CalcTotalCost();
            lblTotalCost.Text = totalCost.ToString("0.00");
            lblNumGuest.Text = party.Count.ToString();
        }

        private bool ValidateText(string text)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please provide both the first name and last name", "Error");
                return false;
            }
            return true;
        }

        private bool TrimNames()
        {
            if ((!ValidateText(txtFirstName.Text)) ||
                    (!ValidateText(txtLastName.Text))
                    )
                return false;

            txtFirstName.Text = txtFirstName.Text.Trim();
            txtLastName.Text = txtLastName.Text.Trim();
            return true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = IsListBoxItemSelected();

            if (index < 0)
                return;

            party.DeleteAt(index);
            UpdateGUI();
        }

        private int IsListBoxItemSelected()
        {
            int index = lstAllGuests.SelectedIndex;

            if (lstAllGuests.SelectedIndex < 0)
            {
                MessageBox.Show("Select a guest to remove from party!");
                return -1;
            }
            return index;
        }

        private decimal Test()
        {
            //int value = 0;
            //bool ok;
            //if (!((value == 6) || (value == 3)))
            //    return ok = true;
            //else
            //    return ok = false;
            decimal amount = Convert.ToDecimal("23");
            return amount;
        }
    }
}
