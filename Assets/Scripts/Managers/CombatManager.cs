using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{

    public static CombatManager Instance;
    public CharController playerController;
    public CharController enemyController;

    private enum TurnState { PlayerTurn, EnemyTurn, Busy}
    private TurnState currentTurnState;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentTurnState = TurnState.PlayerTurn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartPlayerTurn()
    {
        Debug.Log("Player's Turn");
        currentTurnState = TurnState.PlayerTurn;

        playerController.EnableInput(true);
    }

    public void EndPlayerTurn()
    {
        playerController.EnableInput(false);
        StartCoroutine(StartEnemyTurn());
    }

    private IEnumerator StartEnemyTurn()
    {
        currentTurnState = TurnState.Busy;
        Debug.Log("Enemy Turn");
        yield return new WaitForSeconds(1f);

        currentTurnState = TurnState.EnemyTurn;
        enemyController.PerformEnemyTurn();
    }

    public void EndEnemyTurn()
    {
        StartPlayerTurn();
    }

    public void CheckBattleEnd()
    {
        if(playerController.character.Health <= 0)
        {
            Debug.Log("Player has been defeated");
        }
        else if(enemyController.character.Health <= 0)
        {
            Debug.Log("Enemy has been defeated");
        }
    }
}
