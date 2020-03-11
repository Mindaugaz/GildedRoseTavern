using csharp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Database
{
    public class ItemTypeDataAccess : IDataAccess
    {
        public IList<CustomisableItem> GetAllItems()
        {
            IList<CustomisableItem> Items = new List<CustomisableItem>
            {
                new SimpleItem {Name = "+5 Dexterity Vest"},
                new AgingItem {Name = "Aged Brie"},
                new SimpleItem {Name = "Elixir of the Mongoose"},
                new LegendaryItem {Name = "Sulfuras, Hand of Ragnaros"},
                new TicketItem { Name = "Backstage passes to a TAFKAL80ETC concert" },
                new ConjuredItem {Name = "Conjured Mana Cake"}
            };

            return Items;
        }

        public CustomisableItem GetItemType(Item item)
        {
            CustomisableItem c = GetAllItems().First(a => a.Name == item.Name);
            if (c == null)
            {
                c = new SimpleItem();
            }

            c.Clone(item);
            return c;
        }
    }
}
