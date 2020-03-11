using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class TicketItem : CustomisableItem
    {
        public TicketItem(Item i) : base(i) { }

        public void ChangeQuality()
        {
            if (Quality < 50)
            {
                Quality++;
                if (SellIn < 11 && Quality < 50)
                {
                    Quality++;
                }

                if (SellIn < 6 && Quality < 50)
                {
                    Quality++;
                }
            }

            SellIn--;
            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}
