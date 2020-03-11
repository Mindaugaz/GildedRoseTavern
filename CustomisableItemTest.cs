﻿using csharp.Items;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class CustomisableItemTest
    {
        [Test]
        public void AgedBrie()
        {
            AgingItem i =  new AgingItem( new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 });
            i.ChangeQuality();

            //"Aged Brie" actually increases in Quality the older it gets
            Assert.AreEqual(21,i.Quality);
        }

        [Test]
        public void Sulfuras()
        {
            LegendaryItem i = new LegendaryItem(new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 });
            i.ChangeQuality();

            //"Sulfuras", being a legendary item, never has to be sold or decreases in Quality
            Assert.AreEqual(80, i.Quality);
        }

        [Test]
        public void Tickets()
        {
            TicketItem i = new TicketItem(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 });
            i.ChangeQuality();

            /*
             * "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
             * Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
             * Quality drops to 0 after the concert
             */
            Assert.AreEqual(21, i.Quality);
        }

        [Test]
        public void TicketOutdated()
        {
            TicketItem i = new TicketItem(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 });
            i.ChangeQuality();          
            Assert.AreEqual(0, i.Quality);
        }


        [Test]
        public void Conjured()
        {
            ConjuredItem i = new ConjuredItem(new Item { Name = "Conjured Mana Cake", SellIn = 2, Quality = 5 });
            i.ChangeQuality();            

            //"Conjured" items degrade in Quality twice as fast as normal items
            //not implemented in original version. should fail
            Assert.AreEqual(3, i.Quality);
        }
    }
}
