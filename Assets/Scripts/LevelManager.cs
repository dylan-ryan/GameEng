using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class LevelManager : MonoBehaviour
{
    public GameManager gameManager;

    public Scene currentScene;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ButtonLoad(string levelName)
    {
        SceneManager.LoadScene(levelName);
        if (levelName != null)
        {
            if(levelName == "MainMenu")
            {
                gameManager.character.transform.position = GameObject.FindGameObjectWithTag("SpawnPoint").transform.position;
                gameManager.gameState = GameManager.GameState.MainMenu;
            }
            else
            {
                gameManager.character.transform.position = GameObject.FindGameObjectWithTag("SpawnPoint").transform.position;
                gameManager.gameState = GameManager.GameState.Gameplay;
            }
        }
    }
}
