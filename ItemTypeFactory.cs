using csharp.Database;
using csharp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemTypeFactory
    {
        public static IDataAccess GetDataAccessObj()
        {
            return new ItemTypeDataAccess();
        }
    }
}
