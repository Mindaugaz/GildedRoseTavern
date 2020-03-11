using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void AgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //"Aged Brie" actually increases in Quality the older it gets
            Assert.AreEqual(21, Items[0].Quality);
        }

        [Test]
        public void Sulfuras()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //"Sulfuras", being a legendary item, never has to be sold or decreases in Quality
            Assert.AreEqual(80, Items[0].Quality);
        }

        [Test]
        public void Tickets()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            /*
             * "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
             * Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
             * Quality drops to 0 after the concert
             */
            Assert.AreEqual(21, Items[0].Quality);
        }

        [Test]
        public void TicketOutdated()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }


        [Test]
        public void Conjured()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 2, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //"Conjured" items degrade in Quality twice as fast as normal items
            //not implemented in original version. should fail
            Assert.AreEqual(3, Items[0].Quality);
        }
    }
}
