using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class TaskManager
    {
        private List<Task> taskList;

        public TaskManager()
        {
            this.taskList = new List<Task>();
        }

        public int Count
        {
            get { return this.taskList.Count; }
        }

        public bool Add(Task itemIn)
        {
            bool ok = false;
            if (itemIn != null)
            {
                this.taskList.Add(itemIn);

                ok = true;
            }
            return ok;
        }

        public void Clear()
        {
            this.taskList.Clear();
        }

        public string[] ListToStringArray()
        {
            string[] stringInfoStrings = new string[this.taskList.Count];

            int i = 0;
            foreach (Task ItemObj in taskList)
            {
                stringInfoStrings[i++] = ItemObj.ToString();
            }
            return stringInfoStrings;
        }
    }
}
