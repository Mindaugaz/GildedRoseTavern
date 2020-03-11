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
            for(int i=0; i<Items.Count; i++)
            {
                //need to use factory for identifying item type
                switch (Items[i].Name)
                {
                    case "Sulfuras, Hand of Ragnaros":
                        LegendaryItem l = new LegendaryItem(Items[i]);
                        l.ChangeQuality();
                        Items[i] = l;
                        break;
                    case "Aged Brie":
                        AgingItem a = new AgingItem(Items[i]);
                        a.ChangeQuality();
                        Items[i] = a;
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        TicketItem t = new TicketItem(Items[i]);
                        t.ChangeQuality();
                        Items[i] = t;
                        break;
                    case "Conjured Mana Cake":
                        ConjuredItem c = new ConjuredItem(Items[i]);
                        c.ChangeQuality();
                        Items[i] = c;
                        break;
                    default:
                        SimpleItem s = new SimpleItem(Items[i]);
                        s.ChangeQuality();
                        Items[i] = s;
                        break;
                }                
            }               
        }
    }
}
