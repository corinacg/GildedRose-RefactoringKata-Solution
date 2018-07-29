using System;

namespace csharp
{
    class ConjuredItemFactory
    {
        public static UpdatableItem CreateFromItem(Item item)
        {
            return new ConfigurableUpdatableItem(item,
                new QualityUpdateConfiguration[]
                {
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateFunc = x => Math.Max(0, x - 2),
                        MinimumAppliableSellInStartingPoint = 0
                    },
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateFunc = x => Math.Max(0, x - 4),
                        MinimumAppliableSellInStartingPoint = int.MinValue
                    }
                },
                -1);
        }
    }
}
