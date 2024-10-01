// Example usage in Inventory.cs
using UnityEngine;
using System.Collections.Generic;

public class Inventory
{
    public List<Item> Items = new List<Item>();
    public int Gold;

    public void AddItem(ItemData itemData)
    {
        Item newItem = ItemFactory.CreateItem(itemData);
        Items.Add(newItem);
        Debug.Log($"Added {newItem.ItemName} to inventory.");
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
        Debug.Log($"Removed {item.ItemName} from inventory.");
    }

    public void UseItem(Item item, Character target)
    {
        item.Use(target);
        RemoveItem(item);
    }
}
