using csharp.UpdatableItems;

namespace csharp.UpdatebleItemsFactories
{
    class SulfurasItemFactory
    {
        public static UpdatableItem CreateFromItem(Item item)
        {
            if (item.Quality != 80)
            {
                item.Quality = 80;
            }

            return new ConfigurableUpdatableItem(item,
                new QualityUpdateConfiguration[]
                {
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateFunc = x => x,
                        MinimumAppliableSellInStartingPoint = int.MinValue
                    }
                },
                0);
        }
    }
}
