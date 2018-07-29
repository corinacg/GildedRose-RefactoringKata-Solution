namespace csharp
{
    static class UpdatableItemFactory
    {
        public static UpdatableItem CreateFromItem(Item item)
        {
            if(item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return new SulfurasItem(item);
            }
            return null;
        }
    }
}
