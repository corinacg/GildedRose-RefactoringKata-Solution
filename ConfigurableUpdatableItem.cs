using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    class QualityUpdateConfiguration
    {
        public int QualityUpdateSpeed { get; set; }
        public int QualityUpdateLimit { get; set; }
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
            var ensureQualityLimitFunc = GetEnsureQualityLimitFunc(updateConfiguration);
            Item.Quality = ensureQualityLimitFunc(Item.Quality + updateConfiguration.QualityUpdateSpeed, updateConfiguration.QualityUpdateLimit);
        }

        private Func<int, int, int> GetEnsureQualityLimitFunc(QualityUpdateConfiguration qualityUpdateConfiguration)
        {
            return qualityUpdateConfiguration.QualityUpdateSpeed > 0
                ? new Func<int, int, int>((int x, int y) => Math.Min(x, y))
                : (int x, int y) => Math.Max(x, y);
        }

        protected override void UpdateSellIn()
        {
            Item.SellIn = Item.SellIn + sellInSpeed;
        }
    }
}
