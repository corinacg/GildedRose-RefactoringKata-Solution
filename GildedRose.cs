using System.Collections.Generic;
using System.Linq;

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
            var itemsNotUpdatable = new List<Item>();
            var updatableItems = new List<UpdatableItem>();
            foreach (var item in Items)
            {
                var updatableItem = UpdatableItemFactory.CreateFromItem(item);
                if (updatableItem != null)
                {
                    updatableItems.Add(updatableItem);
                }
                else
                {
                    itemsNotUpdatable.Add(item);
                }
            }


            foreach (var item in updatableItems)
            {
                item.Update();
            }

            for (var i = 0; i < itemsNotUpdatable.Count; i++)
            {
                if (itemsNotUpdatable[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (itemsNotUpdatable[i].Quality > 0)
                    {
                        itemsNotUpdatable[i].Quality = itemsNotUpdatable[i].Quality - 1;
                    }
                }
                else
                {
                    if (itemsNotUpdatable[i].Quality < 50)
                    {
                        itemsNotUpdatable[i].Quality = itemsNotUpdatable[i].Quality + 1;

                        if (itemsNotUpdatable[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (itemsNotUpdatable[i].SellIn < 11)
                            {
                                if (itemsNotUpdatable[i].Quality < 50)
                                {
                                    itemsNotUpdatable[i].Quality = itemsNotUpdatable[i].Quality + 1;
                                }
                            }

                            if (itemsNotUpdatable[i].SellIn < 6)
                            {
                                if (itemsNotUpdatable[i].Quality < 50)
                                {
                                    itemsNotUpdatable[i].Quality = itemsNotUpdatable[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                itemsNotUpdatable[i].SellIn = itemsNotUpdatable[i].SellIn - 1;

                if (itemsNotUpdatable[i].SellIn < 0)
                {

                    if (itemsNotUpdatable[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (itemsNotUpdatable[i].Quality > 0)
                        {
                            itemsNotUpdatable[i].Quality = itemsNotUpdatable[i].Quality - 1;
                        }
                    }
                    else
                    {
                        itemsNotUpdatable[i].Quality = itemsNotUpdatable[i].Quality - itemsNotUpdatable[i].Quality;
                    }
                }
            }
        }
    }
}
