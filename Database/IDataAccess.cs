using csharp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Database
{
    public interface IDataAccess
    {
        IList<CustomisableItem> GetAllItems();

        CustomisableItem GetItemType(Item item);
    }
}
