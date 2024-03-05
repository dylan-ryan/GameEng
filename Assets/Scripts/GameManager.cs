using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class GameManager : MonoBehaviour
{
    private CharacterController2D characterController2D;
    private UIManager uiManager;
    public LevelManager levelManager;


    public GameObject character;
    private SpriteRenderer characterArt;

    public enum GameState {MainMenu,Pause,Gameplay}
    public GameState gameState;
    public void Start()
    {
        character.transform.position = GameObject.FindGameObjectWithTag("SpawnPoint").transform.position;
        characterArt = character.GetComponent<SpriteRenderer>();
        characterController2D = GetComponent<CharacterController2D>();
        uiManager = GetComponent<UIManager>();
        levelManager = GetComponent<LevelManager>();
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

        if(Input.GetKeyUp(KeyCode.Escape) && gameState == GameState.Gameplay)
        {
            gameState = GameState.Pause;
        }
        else if(Input.GetKeyUp(KeyCode.Escape) && gameState == GameState.Pause)
        {
            gameState = GameState.Gameplay;
        }
    }

    public void MainMenuUI()
    {
        uiManager.ManagerMainMenuUI();
        characterArt.enabled = false;
        character.GetComponent<CharacterController2D>().enabled = false;

    }

    public void PauseUI()
    {     
        uiManager.ManagerPauseUI();
        character.GetComponent<CharacterController2D>().enabled = false;
    }

    public void GameplayUI()
    {
        uiManager.ManagerGameplayUI();
        characterArt.enabled = true;
        character.GetComponent<CharacterController2D>().enabled = true;

    }
}
