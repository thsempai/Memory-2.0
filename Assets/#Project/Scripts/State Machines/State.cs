public abstract class State
{

    private StateMachine stateMachine;

    public void LinkToStateMachine(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void Enter()
    {

    }

    public virtual void Process()
    {

    }

    public virtual void Exit()
    {

    }
}