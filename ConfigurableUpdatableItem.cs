using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    class QualityUpdateConfiguration
    {
        public Func<int, int> QualityUpdateFunc { get; set; }
        public int MinimumAppliableSellInStartingPoint { get; set; }
    }

    class ConfigurableUpdatableItem : UpdatableItem
    {
        private readonly IEnumerable<QualityUpdateConfiguration> qualityUpdateConfigurationsIntervals;
        private readonly int sellInSpeed;

        public ConfigurableUpdatableItem(Item item, IEnumerable<QualityUpdateConfiguration> qualityUpdateConfigurationsIntervals, int sellInSpeed) : base(item)
        {
            this.qualityUpdateConfigurationsIntervals = qualityUpdateConfigurationsIntervals.OrderByDescending(i => i.MinimumAppliableSellInStartingPoint);
            this.sellInSpeed = sellInSpeed;
        }
        protected override void UpdateQuality()
        {
            var updateConfiguration = this.qualityUpdateConfigurationsIntervals.First(i => Item.SellIn >= i.MinimumAppliableSellInStartingPoint);
            Item.Quality = updateConfiguration.QualityUpdateFunc(Item.Quality);
        }

        protected override void UpdateSellIn()
        {
            Item.SellIn = Item.SellIn + sellInSpeed;
        }
    }
}
