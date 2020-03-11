using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    /// <summary>
    /// A legendary item, never has to be sold or decreases in Quality
    /// </summary>
    public class LegendaryItem : CustomisableItem
    {
        public LegendaryItem(Item i) : base(i) { }

        public override void ChangeQuality()
        {
            //nothing to do here
        }
    }
}
