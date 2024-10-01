using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerCharacter Player;

    private void Awake()
    {
        Instance = this;
    }

    // Additional game management methods
}
