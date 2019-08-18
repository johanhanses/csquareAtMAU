using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListApp
{
    public partial class MainForm : Form
    {
        ItemManager itemManager = new ItemManager();



        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "The shopping list";
            //fill combobox with options.
            cmbUnits.Items.AddRange(Enum.GetNames(typeof(UnitTypes)));
            //set detfault unit in the combobox.
            cmbUnits.SelectedIndex = (int)UnitTypes.piece;
            cmbUnits.d
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool succes = false;

            ShoppingItem item = ReadInput(out succes);
            if (succes)
            {
                itemManager.Additem(item);
                UpdateGUI();
            }
        }

        private ShoppingItem ReadInput(out bool succes)
        {
            succes = false;

            ShoppingItem item = new ShoppingItem();

            item.Description = ReadDescription(out succes);
            if (!succes)
                return null;

            item.Amount = ReadAmount(out succes);
            if (!succes)
                return null;

            item.Unit = ReadUnit(out succes);

            return item;
        }

        private string ReadDescription(out bool succes)
        {
            succes = false;
            string text = txtName.Text.Trim();

            if (!string.IsNullOrEmpty(text))
                succes = true;
            else
                GiveMessage("Provide a description!");

            return text;
        }

        private double ReadAmount(out bool succes)
        {
            double amount = 0.0;
            succes = false;

            if (!double.TryParse(txtAmount.Text, out amount))
            {
                GiveMessage("Wrong amount!");
                txtAmount.Focus();
                txtAmount.SelectionStart = 0;
                txtAmount.SelectionLength = txtAmount.TextLength;
            }
            else
            {
                succes = true;
            }
            return amount;
        }

        private UnitTypes ReadUnit(out bool succes)
        {
            succes = false;
            UnitTypes unit = UnitTypes.lb;

            if (cmbUnits.SelectedIndex >= 0)
            {
                succes = true;
                unit = (UnitTypes)cmbUnits.SelectedIndex;
            }
            else
            {
                GiveMessage("Wrong Unit!");
            }
            return unit;
        }

        private void GiveMessage(string message)
        {
            MessageBox.Show(message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
        }

        private void UpdateGUI()
        {
            lstItems.Items.Clear();

            string[] itemStrings = itemManager.GetItemsInfoStrings();
            if (itemStrings != null)
                lstItems.Items.AddRange(itemStrings);
        }

        private void LstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex < 0)
                return;

            ShoppingItem item = itemManager.GetItem(lstItems.SelectedIndex);
            txtAmount.Text = item.Amount.ToString();
            txtName.Text = item.Description;
            cmbUnits.SelectedIndex = (int)item.Unit;
        }
    }
}
