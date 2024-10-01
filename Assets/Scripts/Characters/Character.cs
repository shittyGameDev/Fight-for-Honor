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

    public virtual void Attack(Character target)
    {
        // Basic attack implementation
        int damage = CalculateDamage(target);
        target.TakeDamage(damage);

        Debug.Log($"{Name} attacks {target.Name} and deals {damage} damage.");
    }

    protected virtual int CalculateDamage(Character target)
    {
        // Basic damage calculation: Attacker's Strength minus Defender's Defense
        int baseDamage = Stats.Strength;
        int defense = target.Stats.Defense;
        int damage = baseDamage - defense;

        // Ensure damage is at least 1
        return Mathf.Max(damage, 1);
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;

        Debug.Log($"{Name} takes {damage} damage. Remaining Health: {Health}");

        if (Health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log($"{Name} has been defeated.");
        // Handle death (e.g., play animation, remove from game)
    }

    public abstract void Defend();

    public void UseItem(Item item)
    {
        // Implementation for using an item
        if (item == null)
        {
            Debug.Log("Item is null");
            return;
        }
        else
        {
            item.Use(this);
        }
    }

    public void LevelUp()
    {
        // Implementation for leveling up
    }
}
