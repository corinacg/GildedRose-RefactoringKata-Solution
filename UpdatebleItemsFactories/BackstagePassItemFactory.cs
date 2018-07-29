using System;
using csharp.UpdatableItems;

namespace csharp.UpdatebleItemsFactories
{
    class BackstagePassItemFactory
    {
        public static UpdatableItem CreateFromItem(Item item)
        {
            return new ConfigurableUpdatableItem(item,
                new QualityUpdateConfiguration[]
                {
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateFunc = x => Math.Min(50, x + 1),
                        MinimumAppliableSellInStartingPoint = 10
                    },
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateFunc = x => Math.Min(50, x + 2),
                        MinimumAppliableSellInStartingPoint = 5
                    },
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateFunc = x => Math.Min(50, x + 3),
                        MinimumAppliableSellInStartingPoint = 0
                    },
                     new QualityUpdateConfiguration()
                    {
                        QualityUpdateFunc = x => 0,
                        MinimumAppliableSellInStartingPoint = int.MinValue
                    }
                },
                -1);
        }
    }
}
