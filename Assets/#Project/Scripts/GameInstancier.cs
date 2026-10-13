using System;
using UnityEngine;

public class GameInstancier : MonoBehaviour
{

    [SerializeField] private GameManager gameManager;
    [SerializeField] private StartScreenManager startScreenManager;

    private void Start()
    {
        CreateInstances();
        Iniatilize();

        Destroy(gameObject);

    }

    private void CreateInstances()
    {
        gameManager = Instantiate(gameManager);

        startScreenManager = Instantiate(startScreenManager);
        startScreenManager.gameObject.SetActive(false);
    }

    private void Iniatilize()
    {
        StartScreenState startScreenState = new(startScreenManager);
        InGameState inGameState = new();
        VictoryState victoryState = new();

        GameStateMachine gameStateMachine = new(startScreenState, inGameState, victoryState);

        gameManager.Initialize(gameStateMachine);
    }

}
