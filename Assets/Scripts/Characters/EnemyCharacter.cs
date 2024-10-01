using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : Character
{
    public AIBehaviorType AIType;

    public override void Attack(Character target)
    {
        // Enemy-specific attack implementation
        int damage = CalculateDamage(target);
        target.TakeDamage(damage);
        Debug.Log($"{Name} attacks {target.Name} and deals {damage} damage.");
    }

    public override void Defend()
    {
        // Enemy-specific defend implementation
        Debug.Log($"{Name} is defending.");
    }

    public void PerformAIAction()
    {
        // Decide action based on AI behavior
        Character target = CombatManager.Instance.playerController.character;

        switch (AIType)
        {
            case AIBehaviorType.Aggressive:
                Attack(target);
                break;
            case AIBehaviorType.Defensive:
                Defend();
                break;
            case AIBehaviorType.Balanced:
                if (Health < 50)
                    Defend();
                else
                    Attack(target);
                break;
        }
    }
}

