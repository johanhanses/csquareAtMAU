using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "Personal Phone Registry";
            this.BackColor = Color.Black;
            button1.BackColor = Color.DarkSalmon;
            button1.Text = "OK";
        }

    }
}
