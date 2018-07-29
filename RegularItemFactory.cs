namespace csharp
{
    class RegularItemFactory
    {
        public static UpdatableItem CreateFromItem(Item item)
        {
            return new ConfigurableUpdatableItem(item,
                new QualityUpdateConfiguration[]
                {
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateSpeed = -1,
                        QualityUpdateLimit = 0,
                        MinimumAppliableSellInStartingPoint = 0
                    },
                    new QualityUpdateConfiguration()
                    {
                        QualityUpdateSpeed = -2,
                        QualityUpdateLimit = 0,
                        MinimumAppliableSellInStartingPoint = int.MinValue
                    }
                },
                -1);
        }
    }
}
