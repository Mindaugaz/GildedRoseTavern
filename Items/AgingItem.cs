﻿namespace csharp.Items
{
    /// <summary>
    /// Aging item increases in Quality the older it gets. Example: "Aged Brie"
    /// </summary>
    public class AgingItem : CustomisableItem
    {
        public override void ChangeQuality()
        {
            //FIX: it should increase quality only ONCE according to documentation
            IncreaseQuality(1);
            SellIn--;
        }
    }
}
