using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class TicketItem : CustomisableItem
    {
        /// <summary>
        /// increases in Quality as its SellIn value approaches
        /// Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but 
        /// Quality drops to 0 after the concert
        /// </summary>
        public TicketItem(Item i) : base(i) { }

        public override void ChangeQuality()
        {
            if (SellIn < 11)
            {
                IncreaseQuality(2);
            }
            else if (SellIn < 6)
            {
                IncreaseQuality(3);
            }
            else
            {
                IncreaseQuality(1);
            }

            SellIn--;
            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}
