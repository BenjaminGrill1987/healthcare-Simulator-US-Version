using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : Singleton<GameState>
{
    private GameStates currentState;

    public static GameStates CurrentState { get => Instance.currentState; }

    private void Start()
    {
        currentState = GameStates.Menu;
    }

    public static void TryToChangeState(GameStates newState)
    {
        bool permisssionGranted = false;

        if (CurrentState != newState)
        {
            permisssionGranted = true;
        }

        switch (newState)
        {
            case GameStates.Menu:
                {
                    if (permisssionGranted)
                    {

                    }
                    else
                    {
                        Debug.LogError("You try to change in state: " + newState.ToString() + " But you are already in state: " + CurrentState.ToString());
                    }

                    break;
                }
            case GameStates.Loading:
                {
                    if (permisssionGranted)
                    {

                    }
                    else
                    {
                        Debug.LogError("You try to change in state: " + newState.ToString() + " But you are already in state: " + CurrentState.ToString());
                    }
                    break;
                }
            case GameStates.Game:
                {
                    if (permisssionGranted)
                    {

                    }
                    else
                    {
                        Debug.LogError("You try to change in state: " + newState.ToString() + " But you are already in state: " + CurrentState.ToString());
                    }

                    break;
                }
            case GameStates.GameOver:
                {
                    if (permisssionGranted)
                    {

                    }
                    else
                    {
                        Debug.LogError("You try to change in state: " + newState.ToString() + " But you are already in state: " + CurrentState.ToString());
                    }

                    break;
                }
            case GameStates.Quit:
                {
                    if (permisssionGranted)
                    {
                        Application.Quit();
                        Debug.LogError("Quit Game");
                    }
                    else
                    {
                        Debug.LogError("You try to change in state: " + newState.ToString() + " But you are already in state: " + CurrentState.ToString());
                    }

                    break;
                }
            default:
                {
                    Debug.LogError("You try to change in state: " + newState.ToString() + " But there is no condition for that state");
                    break;
                }
        }

        if (permisssionGranted)
        {
            ChangeCurrentState(newState);
        }
    }

    private static void ChangeCurrentState(GameStates newState)
    {
        Instance.currentState = newState;
    }
}

public enum GameStates
{
    Menu,
    Loading,
    Game,
    GameOver,
    Quit
}