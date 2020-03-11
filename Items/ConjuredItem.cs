using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class ConjuredItem : CustomisableItem
    {
        public ConjuredItem(Item i) : base(i) { }
    
        public void ChangeQuality()
        {
            if (Quality > 0)
            {
                Quality--;
            }

            if (Quality > 0)
            {
                Quality--;
            }

            SellIn--;
            if (SellIn < 0 && Quality > 0)
            {
                Quality--;
                if (Quality > 0)
                {
                    Quality--;
                }
            }
        }
    }
}
