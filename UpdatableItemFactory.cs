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
            else if(item.Name == "Aged Brie")
            {
                return new AgedBrieItem(item);
            }
            return null;
        }
    }
}
