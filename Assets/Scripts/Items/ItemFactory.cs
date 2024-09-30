using System;
using UnityEngine;

public static class ItemFactory
{
    public static Item CreateItem(ItemData itemData)
    {
        switch (itemData.ItemType)
        {
            case ItemType.Equipment:
                return CreateEquipment(itemData);
            case ItemType.Consumable:
                return CreateConsumable(itemData);
            default:
                throw new ArgumentException("Invalid item type");
        }
    }

    private static Equipment CreateEquipment(ItemData data)
    {
        Equipment equipment = new Equipment
        {
            ItemName = data.ItemName,
            Description = data.Description,
            Value = data.Value,
            ItemType = data.ItemType,
            AttackBonus = data.AttackBonus,
            DefenseBonus = data.DefenseBonus,
            EquipmentType = data.EquipmentType
        };
        return equipment;
    }

    private static Consumable CreateConsumable(ItemData data)
    {
        Consumable consumable = new Consumable
        {
            ItemName = data.ItemName,
            Description = data.Description,
            Value = data.Value,
            ItemType = data.ItemType,
            EffectAmount = data.EffectAmount
        };
        return consumable;
    }
}
