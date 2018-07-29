using System.Collections.Generic;
using System.Linq;
using csharp.UpdatebleItemsFactories;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach(var item in Items.Select(i=> UpdatableItemFactory.CreateFromItem(i)))
            {
                item.Update();
            }
        }
    }
}
