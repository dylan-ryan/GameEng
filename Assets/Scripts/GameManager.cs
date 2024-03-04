using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private UIManager uiManager;
    public enum GameState {MainMenu,Pause,Gameplay}
    public GameState gameState;
    private void Start()
    {
        uiManager = GetComponent<UIManager>();
    }
    public void Update()
    {
        switch (gameState)
        {
            case GameState.MainMenu:
                MainMenuUI();
                break;
            case GameState.Pause:
                PauseUI();
                break;
            case GameState.Gameplay:
                GameplayUI();
                break;
        }
    }

    public void MainMenuUI()
    {
        uiManager.ManagerMainMenuUI();
    }

    public void PauseUI()
    {
        uiManager.ManagerPauseUI();
    }

    public void GameplayUI()
    {
        uiManager.ManagerGameplayUI();
    }
}
