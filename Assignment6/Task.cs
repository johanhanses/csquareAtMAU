using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Task
    {
        private DateTime date;
        private string description;
        private PriorityType priority;



        /// <summary>
        /// constructor that saves args to dedicated variables
        /// </summary>
        /// <param name="date">due date and time for task</param>
        /// <param name="priority">task priority</param>
        /// <param name="name">description, what is the task?</param>
        public Task(DateTime date, PriorityType priority, string name)
        {
            this.date = date;
            this.priority = priority;
            this.description = name;
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

        public PriorityType Priority
        {
            get { return this.priority; }
            set
            {
                if (Enum.IsDefined(typeof(PriorityType), value))
                    this.priority = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set
            {
                this.date = value;
            }
        }

        /// <summary>
        /// format how user input is displayed to user
        /// </summary>
        /// <returns>a string formated to be displayed in list box</returns>
        public override string ToString()
        {
            return $"{date.ToShortDateString(), -13}" +
                   $"{GetTimeString(),-10}" +
                   $"{GetPriorityString(), -20}" +
                   $"{this.description}";
        }

        /// <summary>
        /// format time to a string
        /// </summary>
        /// <returns>a string of due time </returns>
        private string GetTimeString()
        {
            return date.ToShortTimeString();
        }

        /// <summary>
        /// formats priority to a string and replaces _ with an empty space
        /// </summary>
        /// <returns>priority as a string</returns>
        private string GetPriorityString()
        {
            string textout;
            textout = this.priority.ToString();
            textout = textout.Replace("_", " ");
            return textout;
        }



    }
}
