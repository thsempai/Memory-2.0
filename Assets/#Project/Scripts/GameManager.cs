using UnityEngine;

public class GameManager : MonoBehaviour
{

    private GameStateMachine gameStateMachine;
    public void Initialize(GameStateMachine gameStateMachine)
    {
        this.gameStateMachine = gameStateMachine;
    }

    private void Update()
    {
        gameStateMachine.Process();
    }

}