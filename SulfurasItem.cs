using System;

namespace csharp
{
    class SulfurasItem : UpdatebleItem
    {
        public SulfurasItem(Item item) : base(item)
        {
            if(item.Quality != 80)
            {
                item.Quality = 80;
            }
        }

        protected override void UpdateQuality()
        {
        }

        protected override void UpdateSellIn()
        {
        }
    }
}
