using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Characters/CharacterData")]
public class CharacterData : ScriptableObject
{
    public string Name;
    public int Level;
    public int Health;
    public int Mana;
    public Stats Stats;
    public Inventory Inventory;
}
