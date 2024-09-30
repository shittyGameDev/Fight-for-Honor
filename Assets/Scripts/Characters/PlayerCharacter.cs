using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{
    public int Experience;
    public int SkillPoints;

    public override void Attack(Character target) { /* Implementation */ }
    public override void Defend() { /* Implementation */ }
    public void AllocateSkillPoints() { /* Implementation */ }
    public void EquipItem(Equipment item) { /* Implementation */ }
    public void SellItem(Item item) { /* Implementation */ }
}
