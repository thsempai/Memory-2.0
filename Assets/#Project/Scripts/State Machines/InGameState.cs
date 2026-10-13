public class InGameState : State
{
    private GameManager gameManager;

    public InGameState(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }
    public override void Enter()
    {
        base.Enter();
        gameManager.RevealCards();
    }
}