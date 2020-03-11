using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var i in Items)
            {
                if (i.Name == "Sulfuras, Hand of Ragnaros")
                {
                    continue;
                }

                if (i.Name != "Aged Brie" && i.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    i.Quality = DecreaseQuality(i.Quality);
                }
                else
                {
                    i.Quality = IncreaseQuality(i.Quality);
                    if (i.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (i.SellIn < 11)
                        {
                            i.Quality = IncreaseQuality(i.Quality);
                        }

                        if (i.SellIn < 6)
                        {
                            i.Quality = IncreaseQuality(i.Quality);
                        }
                    }
                }

                i.SellIn--;
                if (i.SellIn < 0)
                {
                    if (i.Name != "Aged Brie")
                    {
                        if (i.Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            i.Quality = DecreaseQuality(i.Quality);
                        }
                        else
                        {
                            i.Quality = 0;
                        }
                    }
                    else
                    {
                        i.Quality = IncreaseQuality(i.Quality);
                    }
                }
            }
        }

        private int IncreaseQuality(int quality)
        {
            quality++;
            return quality > 50 ? 50 : quality;
        }

        private int DecreaseQuality(int quality)
        {
            quality--;
            return quality < 0 ? 0 : quality;
        }
    }
}
