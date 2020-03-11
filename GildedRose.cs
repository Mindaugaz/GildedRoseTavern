using csharp.Database;
using csharp.Items;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var i in Items)
            {
                CustomisableItem clone = GetItemType(i);
                clone.ChangeQuality();
                i.Quality = clone.Quality;
                i.SellIn = clone.SellIn;
            }
        }
        /*
        private CustomisableItem GetItemType(Item i)
        {
            ItemTypeFactory dataInventoryAccess = ItemTypeFactory.GetInventoryItemTypes(i);
            return dataInventoryAccess.IdentifyItem(i);
        }*/

        private CustomisableItem GetItemType(Item i)
        {
            IDataAccess dataInventoryAccess = ItemTypeFactory.GetDataAccessObj();
            return dataInventoryAccess.GetItemType(i);
        }
    }
}
