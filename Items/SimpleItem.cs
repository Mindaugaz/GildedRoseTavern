using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class SimpleItem : CustomisableItem
    {
        public SimpleItem(Item i) : base(i) { }

        /// <summary>
        /// Once the sell by date has passed, Quality degrades twice as fast
        /// The Quality of an item is never negative
        /// </summary>
        public void ChangeQuality()
        {
            if (Quality > 0)
            {
                Quality--;
            }

            SellIn--;
            if (SellIn < 0 && Quality > 0)
            {
                Quality--;
            }
        }
    }
}
