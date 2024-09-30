using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AIState
{
    void EnterState(EnemyCharacter enemy);
    void UpdateState(EnemyCharacter enemy);
    void ExitState(EnemyCharacter enemy);
}

