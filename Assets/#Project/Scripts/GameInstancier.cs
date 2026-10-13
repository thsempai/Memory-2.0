using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GameInstancier : MonoBehaviour
{
    # region serialize

    [Header("Managers")]
    [SerializeField] private GameManager gameManager;
    [SerializeField] private StartScreenManager startScreenManager;

    [Space(10)]

    [Header("Cards")]
    [SerializeField] private CardBehavior cardPrefab;
    [SerializeField] private int maxCardsNumber = 24;

    # endregion

    # region private attribute

    private CardBehavior[] cards;

    # endregion

    private void Start()
    {
        CreateInstances();
        Iniatilize();

        Destroy(gameObject);

    }

    #region instances creation

    private void CreateInstances()
    {
        gameManager = Instantiate(gameManager);

        startScreenManager = Instantiate(startScreenManager);
        startScreenManager.gameObject.SetActive(false);

        CreateCards();
    }

    private void CreateCards()
    {
        cards = new CardBehavior[maxCardsNumber];

        for (int index = 0; index < maxCardsNumber; index++)
        {
            cards[index] = Instantiate(cardPrefab);
            cards[index].gameObject.SetActive(false);
        }


    }

    #endregion

    #region Initialization
    private void Iniatilize()
    {
        StartScreenState startScreenState = new(startScreenManager, gameManager);
        InGameState inGameState = new(gameManager);
        VictoryState victoryState = new();

        GameStateMachine gameStateMachine = new(startScreenState, inGameState, victoryState);

        gameManager.Initialize(gameStateMachine, cards);

        startScreenManager.AddListenerToLeft(gameManager.DefineEasyGrid);
        startScreenManager.AddListenerToMiddle(gameManager.DefineNormalGrid);
        startScreenManager.AddListenerToRight(gameManager.DefineDifficultGrid);

    }
    #endregion

}
