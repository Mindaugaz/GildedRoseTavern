using csharp.Database;
using csharp.Items;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        IDataAccess dataInventoryAccess;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            dataInventoryAccess = ItemTypeFactory.GetDataAccessObj();
        }

        public void UpdateQuality()
        {
            foreach (var i in Items)
            {
                CustomisableItem clone = dataInventoryAccess.GetItemType(i);
                clone.ChangeQuality();

                //copy values
                i.Quality = clone.Quality;
                i.SellIn = clone.SellIn;

                //we could change Item class objects to new custom item class here, but I am afraid of goblins
            }
        }
    }
}
