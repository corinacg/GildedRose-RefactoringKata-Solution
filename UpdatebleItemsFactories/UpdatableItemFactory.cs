using csharp.UpdatableItems;

namespace csharp.UpdatebleItemsFactories
{
    static class UpdatableItemFactory
    {
        public static UpdatableItem CreateFromItem(Item item)
        {
            if(item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return SulfurasItemFactory.CreateFromItem(item);
            }
            else if(item.Name == "Aged Brie")
            {
                return AgedBrieItemFactory.CreateFromItem(item);
            }
            else if (item.Name.Contains("Backstage passes"))
            {
                return BackstagePassItemFactory.CreateFromItem(item);
            }
            else if(item.Name.Contains("Conjured"))
            {
                return ConjuredItemFactory.CreateFromItem(item);
            }
            return RegularItemFactory.CreateFromItem(item);
        }
    }
}
