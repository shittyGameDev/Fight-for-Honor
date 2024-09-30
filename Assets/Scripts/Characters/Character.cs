using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string Name;
    public int Level;
    public int Health;
    public int Mana;
    public Stats Stats;
    public Inventory Inventory;

    public abstract void Attack(Character target);
    public abstract void Defend();
    public void UseItem(Item item) { /* Implementation */ }
    public void LevelUp() { /* Implementation */ }
}
