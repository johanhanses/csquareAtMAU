using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    class ItemManager
    {
        private List<ShoppingItem> itemList;

        public ItemManager()
        {
            this.itemList = new List<ShoppingItem>();
        }

        public ShoppingItem GetItem(int index)
        {
            if (!CheckIndex(index))
                return null;

            return this.itemList[index];
        }

        public int Count
        {
            get { return this.itemList.Count; }
        }

        public bool Additem(ShoppingItem itemIn)
        {
            bool ok = false;
            if (itemIn != null)
            {
                this.itemList.Add(itemIn);
                ok = true;
            }
            return ok;
        }

        private bool CheckIndex(int index)
        {
            return (index >= 0) && (index < this.itemList.Count);
        }

        //public bool ChangeItem(ShoppingItem itemIn, int index)
        //{
        //    bool ok = false;
        //    if (CheckIndex(index))
        //    {
        //        ok = true;
        //        this.itemList[index] = itemIn;
        //    }
        //    return ok;
        //}

        //public bool DeleteItem(int index)
        //{
        //    bool ok = false;
        //    if (CheckIndex(index))
        //    {
        //        ok = true;
        //        this.itemList.RemoveAt(index);
        //    }
        //    return ok;
        //}

        public string[] GetItemsInfoStrings()
        {
            string[] stringInfoStrings = new string[this.itemList.Count];

            int i = 0;
            foreach (ShoppingItem ItemObj in itemList)
            {
                stringInfoStrings[i++] = ItemObj.ToString();
            }
            return stringInfoStrings;
        }
    }
}
