namespace csharp
{
    class RegularItem : UpdatableItem
    {
        public RegularItem(Item item) : base(item)
        {

        }
        protected override void UpdateQuality()
        {
            if (Item.Quality > 0)
            {
               Item.Quality = Item.Quality - 1;
            }

            if (Item.SellIn < 0)
            {
                if (Item.Quality > 0)
                {
                    Item.Quality = Item.Quality - 1;
                }
            }
        }

        protected override void UpdateSellIn()
        {
           Item.SellIn = Item.SellIn - 1;
        }
    }
}
