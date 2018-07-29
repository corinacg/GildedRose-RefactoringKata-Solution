using System;

namespace csharp
{
    class AgedBrieItemFactory 
    {
        public static UpdatableItem CreateFromItem(Item item)
        {
            return new ConfigurableUpdatableItem(item,
                new QualityUpdateConfiguration[]
                {
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateFunc = x => Math.Min(50, x + 1),
                        MinimumAppliableSellInStartingPoint = 0
                    },
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateFunc = x => Math.Min(50, x + 2),
                        MinimumAppliableSellInStartingPoint = int.MinValue
                    }
                },
                -1);
        }
    }
}
