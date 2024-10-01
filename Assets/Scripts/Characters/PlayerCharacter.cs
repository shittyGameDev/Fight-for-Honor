using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{
    public int Experience;
    public int SkillPoints;

    public override void Attack(Character target)
    {
        int damage = CalculateDamage(target);

        // Implement critical hit chance
        float critChance = Stats.Agility * 0.01f; // Example: 1% crit chance per Agility point
        bool isCriticalHit = Random.value <= critChance;

        if (isCriticalHit)
        {
            damage *= 2; // Critical hits deal double damage
            Debug.Log("Critical Hit!");
        }

        target.TakeDamage(damage);

        Debug.Log($"{Name} attacks {target.Name} and deals {damage} damage.");
    }

    public override void Defend()
    {
        // Implementation for defend action
        Debug.Log($"{Name} is defending.");
        // Increase defense or reduce incoming damage
    }

    public void AllocateSkillPoints()
    {
        // Implementation for allocating skill points
    }

    public void EquipItem(Equipment item)
    {
        // Implementation for equipping an item
    }

    public void SellItem(Item item)
    {
        // Implementation for selling an item
    }
}
