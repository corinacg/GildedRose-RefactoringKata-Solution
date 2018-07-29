namespace csharp
{
    class AgedBrieItem : UpdatableItem
    {
        public AgedBrieItem(Item item) : base(item)
        {
        }

        protected override void UpdateQuality()
        {
            if(Item.Quality < 50)
            {
                Item.Quality += 1;
            }
            if(Item.SellIn < 0 && Item.Quality < 50)
            {
                Item.Quality += 1;
            }
        }

        protected override void UpdateSellIn()
        {
            Item.SellIn -= 1;
        }
    }
}
