// ItemData.cs
using UnityEngine;

[CreateAssetMenu(fileName = "NewItemData", menuName = "Items/ItemData")]
public class ItemData : ScriptableObject
{
    public string ItemName;
    public string Description;
    public int Value;
    public ItemType ItemType;

    // Equipment-specific
    public int AttackBonus;
    public int DefenseBonus;
    public EquipmentType EquipmentType;

    // Consumable-specific
    public int EffectAmount;
}