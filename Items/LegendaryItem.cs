namespace csharp.Items
{
    /// <summary>
    /// A legendary item, never has to be sold or decreases in Quality
    /// </summary>
    public class LegendaryItem : CustomisableItem
    {
        public override void ChangeQuality()
        {
            //nothing to do here
        }
    }
}
