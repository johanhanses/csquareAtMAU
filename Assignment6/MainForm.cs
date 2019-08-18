using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        TaskManager taskManager = new TaskManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "To do reminder by Johan Hanses";


            lstTasks.Items.Clear();
            txtDescription.Text = string.Empty;

            taskManager.Clear();

            cmbPriority.Items.Clear();
            string[] priority = Enum.GetNames(typeof(PriorityType));
            foreach (var item in priority)
                cmbPriority.Items.Add(item.Replace("_", " "));

            cmbPriority.SelectedIndex = (int)PriorityType.Normal;

            toolTip.SetToolTip(dateTimePickerControl, "Click to open calendar, write in time here");

            dateTimePickerControl.Format = DateTimePickerFormat.Custom;
            dateTimePickerControl.CustomFormat = "yyyy-MM-dd    HH:mm";

            //menuFileOpen.Enabled = false;
            //menuFileSave.Enabled = false;
        }

        private void Timer_Seconds_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Task newTask = GetTaskFromUserInput();
            if (newTask != null)
            {
                taskManager.Add(newTask);
                UpdateGUI();
            }
        }

        private Task GetTaskFromUserInput()
        {
            string description = ReadTaskDescription();

            Task newTask = null;

            if (IsValidDate() && (description != null))
            {
                DateTime date = dateTimePickerControl.Value;

                PriorityType priority = (PriorityType)cmbPriority.SelectedIndex;
                newTask = new Task(date, priority, description);
            }
            return newTask;
        }

        private bool IsValidDate()
        {
            if (dateTimePickerControl.Value < new DateTime(2000, 01, 01) || dateTimePickerControl.Value >= new DateTime(2222, 01, 01))
            {
                GiveMessage("Wrong date, must be between 2000 - 2222");
                return false;
            }
            else
                return true;
        }

        private string ReadTaskDescription()
        {
            string text = txtDescription.Text.Trim();

            if (!string.IsNullOrEmpty(text))
                return text;
            else
            {
                GiveMessage("Provide a description of to do!");
                return null;
            }
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
            lstTasks.Items.Clear();

            string[] taskStrings = taskManager.ListToStringArray();
            if (taskStrings != null)
                lstTasks.Items.AddRange(taskStrings);
        }

        private void Menu_New_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            if (ResultFromQuitDialog())
                Close();
        }

        private bool ResultFromQuitDialog()
        {
            bool close = false;

            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "You better think twice", MessageBoxButtons.OKCancel);

            switch (result)
            {
                case DialogResult.OK:
                    {
                        close = true;
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        close = false;
                        break;
                    }
            }
            return close;
        }

        private void Menu_About_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }
    }


}
