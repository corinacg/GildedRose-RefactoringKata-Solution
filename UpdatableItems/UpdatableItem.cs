namespace csharp.UpdatableItems
{
    abstract class UpdatableItem
    {
        public UpdatableItem(Item item)
        {
            Item = item;
        }

        protected Item Item { get; set; }

        public void Update()
        {
            UpdateSellIn();
            UpdateQuality();
        }

        protected abstract void UpdateSellIn();

        protected abstract void UpdateQuality();
    }
}
