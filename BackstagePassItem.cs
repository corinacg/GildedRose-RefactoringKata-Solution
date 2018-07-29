namespace csharp
{
    class BackstagePassItem : UpdatableItem
    {
        public BackstagePassItem(Item item) : base(item)
        {
        }

        protected override void UpdateQuality()
        {
            if (Item.Quality < 50)
            {
                Item.Quality = Item.Quality + 1;
            }

            if (Item.SellIn < 10)
            {
                if (Item.Quality < 50)
                {
                    Item.Quality = Item.Quality + 1;
                }
            }

            if (Item.SellIn < 5)
            {
                if (Item.Quality < 50)
                {
                    Item.Quality = Item.Quality + 1;
                }
            }

            if (Item.SellIn < 0)
            {
               Item.Quality = Item.Quality - Item.Quality;
            }
        }

        protected override void UpdateSellIn()
        {
            Item.SellIn = Item.SellIn - 1;
        }
    }
}
