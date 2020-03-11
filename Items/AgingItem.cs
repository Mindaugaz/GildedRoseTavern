using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class AgingItem : CustomisableItem
    {
        public AgingItem(Item i) : base(i) { }
        

        /// <summary>
        /// Aging item increases in Quality the older it gets. Example: "Aged Brie"
        /// </summary>
        public void ChangeQuality()
        {
            if (Quality < 50)
            {
                Quality++;
            }

            SellIn--;
            if (SellIn < 0 && Quality < 50)
            {
                Quality++;
            }
        }
    }
}
