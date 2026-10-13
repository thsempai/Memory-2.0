using UnityEngine;

public class StartScreenState : State
{
    private StartScreenManager startScreenManager;
    public StartScreenState(StartScreenManager startScreenManager)
    {
        this.startScreenManager = startScreenManager;
    }

    public override void Enter()
    {
        base.Enter();
        startScreenManager.gameObject.SetActive(true);
    }
    public override void Process()
    {
        base.Process();
        Debug.Log("Start");
    }

    public override void Exit()
    {
        base.Exit();
        startScreenManager.gameObject.SetActive(false);
    }
}