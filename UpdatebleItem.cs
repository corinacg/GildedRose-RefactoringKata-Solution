namespace csharp
{
    abstract class UpdatebleItem
    {
        public UpdatebleItem(Item item)
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
