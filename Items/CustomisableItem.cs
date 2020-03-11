using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class CustomisableItem : Item
    {
        public CustomisableItem(Item i)
        {
            this.Name = i.Name;
            this.Quality = i.Quality;
            this.SellIn = i.SellIn;
        }
    }
}
