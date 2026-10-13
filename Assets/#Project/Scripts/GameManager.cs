using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private GameStateMachine gameStateMachine;

    private int rows = 0;
    private int columns = 0;
    public int NumberOfCards => rows * columns;

    private CardBehavior[] cards;

    public void Initialize(GameStateMachine gameStateMachine, CardBehavior[] cards)
    {
        this.gameStateMachine = gameStateMachine;
        this.cards = cards;
    }

    private void Update()
    {
        gameStateMachine.Process();
    }

    private void DefineGrid(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        Debug.Log($"Test: {rows}, {columns}");
    }

    public void DefineEasyGrid() => DefineGrid(2, 3);
    public void DefineNormalGrid() => DefineGrid(4, 3);
    public void DefineDifficultGrid() => DefineGrid(4, 6);

    public void RevealCards(int number)
    {
        for (int index = 0; index < number; index++)
        {
            cards[index].gameObject.SetActive(true);
        }
    }

    public void RevealCards() => RevealCards(NumberOfCards);

    public void UnrevealCards()
    {
        for (int index = 0; index < NumberOfCards; index++)
        {
            cards[index].gameObject.SetActive(false);
        }
    }


}