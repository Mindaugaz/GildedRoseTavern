using csharp.Items;
using System.Collections.Generic;

namespace csharp.Database
{
    public interface IDataAccess
    {
        IList<CustomisableItem> GetAllItems();

        CustomisableItem GetItemType(Item item);
    }
}
