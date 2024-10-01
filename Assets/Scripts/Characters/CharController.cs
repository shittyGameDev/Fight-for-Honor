using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour
{
    public CharacterData characterData;
    public Character character; // Could be PlayerCharacter or EnemyCharacter
    public bool isPlayerCharacter;

    private bool canAcceptInput = false;

    private void Start()
    {
        if (isPlayerCharacter)
        {
            character = new PlayerCharacter();
        }
        else
        {
            character = new EnemyCharacter();
        }

        InitializeCharacter();
    }

    public void EnableInput(bool enable)
    {
        canAcceptInput = enable;
    }

    private void Update()
    {
        // Handle input or AI actions
        if (isPlayerCharacter && canAcceptInput)
        {
            HandlePlayerInput();
        }
    }

    private void InitializeCharacter()
    {
        // Initialize character stats, inventory, etc.
        character.Name = characterData.Name;
        character.Level = characterData.Level;
        character.Health = characterData.Health;
        character.Mana = characterData.Mana;
        character.Stats = characterData.Stats;
        character.Inventory = characterData.Inventory;
    }

    private void HandlePlayerInput()
    {
        // Example input handling
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Attack command
            Character target = FindTarget();
            character.Attack(target);
        }
    }

    public void OnAttackButtonPressed()
    {
        if (canAcceptInput)
        {
            PerformPlayerAction(ActionType.Attack);
        }
    }

    public void OnDefendButtonPressed()
    {
        if (canAcceptInput)
        {
            PerformPlayerAction(ActionType.Defend);
        }
    }

    private void PerformPlayerAction(ActionType actionType)
    {
        Character target = CombatManager.Instance.enemyController.character;

        switch (actionType)
        {
            case ActionType.Attack:
                character.Attack(target);
                break;
            case ActionType.Defend:
                character.Defend();
                break;
                // Add cases for other actions like UseItem
        }

        // Check for end of battle
        CombatManager.Instance.CheckBattleEnd();

        // End the player's turn
        CombatManager.Instance.EndPlayerTurn();
    }


    public void PerformEnemyTurn()
    {
        ((EnemyCharacter)character).PerformAIAction();

        CombatManager.Instance.CheckBattleEnd();
        StartCoroutine(EndEnemyTurnAfterDelay());
    }

    private IEnumerator EndEnemyTurnAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        CombatManager.Instance.EndEnemyTurn();
    }

    private Character FindTarget()
    {
        // Implement logic to find and return a target character
        return null;
    }
}
