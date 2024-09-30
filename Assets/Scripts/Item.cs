using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Item.cs
public abstract class Item
{
    public string ItemName;
    public string Description;
    public int Value;
    public ItemType ItemType;

    public abstract void Use(Character target);
}
