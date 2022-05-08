using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    // Once win
    // dumb: restart the Game scene 
    // easier: clear the score, but record it - next level 
    // next level - add more butterflies 
    // should make butterflies spawn accordingly - have level threshold for each 
    // once select exit, pop up UI - quit the game 
    // once select continue, continue with higher level of difficulty 
    public string gameScene;

    void Start()
    {

        // reset all the variables 
        // increase the amount of butterflies 
    }

    public void ReloadTheScene()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    void Update()
    {

    }
}
