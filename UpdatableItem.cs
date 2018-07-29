namespace csharp
{
    abstract class UpdatableItem
    {
        public UpdatableItem(Item item)
        {
            Item = item;
        }

        public Item Item { get; }

        public void Update()
        {
            UpdateSellIn();
            UpdateQuality();
        }

        protected abstract void UpdateSellIn();

        protected abstract void UpdateQuality();
    }
}
