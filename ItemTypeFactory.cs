using csharp.Database;

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
