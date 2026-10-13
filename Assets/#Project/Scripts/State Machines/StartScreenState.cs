using UnityEngine;

public class StartScreenState : State
{
    private StartScreenManager startScreenManager;
    private GameManager gameManager;

    public StartScreenState(StartScreenManager startScreenManager, GameManager gameManager)
    {
        this.startScreenManager = startScreenManager;
        this.gameManager = gameManager;
    }

    public override void Enter()
    {
        base.Enter();
        startScreenManager.gameObject.SetActive(true);
    }
    public override void Process()
    {
        base.Process();
        if (gameManager.NumberOfCards > 0)
        {
            stateMachine.ChangeState(GameStateMachine.IN_GAME);
        }
    }

    public override void Exit()
    {
        base.Exit();
        startScreenManager.gameObject.SetActive(false);
    }
}