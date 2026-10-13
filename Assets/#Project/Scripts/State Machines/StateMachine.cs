public abstract class StateMachine
{
    private State currentState;

    public void ChangeState(State newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void Process()
    {
        currentState?.Process();
    }

}