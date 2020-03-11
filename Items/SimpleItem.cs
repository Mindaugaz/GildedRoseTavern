using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    /// <summary>
    /// Simple item. Once the sell by date has passed, Quality degrades twice as fast
    /// The Quality of an item is never negative
    /// </summary>
    public class SimpleItem : CustomisableItem
    {        
        public override void ChangeQuality()
        {
            DecreaseQuality(1);
            SellIn--;
            if (SellIn < 0)
            {
                DecreaseQuality(1);
            }
        }
    }
}
