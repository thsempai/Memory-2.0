public class GameStateMachine : StateMachine
{
    public static StartScreenState START_SCREEN;
    public static InGameState IN_GAME;
    public static VictoryState VICTORY;

    public GameStateMachine(StartScreenState startScreenState, InGameState inGameState, VictoryState victoryState)
    {
        START_SCREEN = startScreenState;
        startScreenState.LinkToStateMachine(this);

        IN_GAME = inGameState;
        inGameState.LinkToStateMachine(this);

        VICTORY = victoryState;
        victoryState.LinkToStateMachine(this);

        ChangeState(START_SCREEN);
    }

}