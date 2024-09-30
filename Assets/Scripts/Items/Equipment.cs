using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item
{
    public int AttackBonus;
    public int DefenseBonus;
    public EquipmentType EquipmentType;

    public override void Use(Character target)
    {
        // Equip the item
    }
}
