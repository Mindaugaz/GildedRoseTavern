using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class CustomisableItem : Item
    {
        public virtual void ChangeQuality() { }

        public void IncreaseQuality(int increment)
        {
            this.Quality = this.Quality + increment;
            this.Quality = this.Quality > 50 ? 50 : this.Quality;
        }

        public void DecreaseQuality(int increment)
        {
            this.Quality = this.Quality - increment;
            this.Quality = this.Quality < 0 ? 0 : this.Quality;
        }

        public void Clone(Item i)
        {
            this.Name = i.Name;
            this.Quality = i.Quality;
            this.SellIn = i.SellIn;
        }
    }
}
