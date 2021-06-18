using System;
using System.Collections.Generic;

namespace WitcherCharacterCreator
{
    public class Inventory
    {
        private List<IInventoryItem> items = new List<IInventoryItem>();

        public void addItem(IInventoryItem item)
        {
            items.Add(item);
        }
    }

    public interface IInventoryItem : IInfo
    {
        public string getName();
        public string getDescription();
        public float getWeight();

        public new string text()
        {
            return getName();
        }
    }
}