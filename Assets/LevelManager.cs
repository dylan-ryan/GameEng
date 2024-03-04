using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private GameManager gameManager;

    public Scene currentScene;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UILoad()
    {
        if (sceneName == "MainMenu")
        {
            gameManager.gameState = GameManager.GameState.MainMenu;
        }
        else gameManager.gameState = GameManager.GameState.Gameplay;
    }

    public void ButtonLoad(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
