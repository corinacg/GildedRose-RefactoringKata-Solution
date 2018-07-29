using System;

namespace csharp
{
    class ConjuredItem : UpdatableItem
    {
        public ConjuredItem(Item item) : base(item)
        {

        }
        protected override void UpdateQuality()
        {
            if (Item.Quality > 0)
            {
                Item.Quality = Math.Max(Item.Quality - 2, 0);
            }

            if (Item.SellIn < 0)
            {
                if (Item.Quality > 0)
                {
                    Item.Quality = Math.Max(Item.Quality - 2, 0);
                }
            }
        }

        protected override void UpdateSellIn()
        {
            Item.SellIn = Item.SellIn - 1;
        }
    }
}
