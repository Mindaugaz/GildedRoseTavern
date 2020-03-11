using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    /// <summary>
    /// Conjured items degrade in Quality twice as fast as normal items
    /// </summary>
    public class ConjuredItem : CustomisableItem
    {
        public override void ChangeQuality()
        {
            DecreaseQuality(2);
            SellIn--;
            if (SellIn < 0)
            {
                DecreaseQuality(2);
            }
        }
    }
}
