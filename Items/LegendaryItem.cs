using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class LegendaryItem : CustomisableItem
    {
        public LegendaryItem(Item i) : base(i) { }

        public void ChangeQuality()
        {
            //nothing to do here
        }
    }
}
