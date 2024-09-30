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
}
