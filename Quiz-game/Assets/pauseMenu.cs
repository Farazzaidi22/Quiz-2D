using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseMenu : MonoBehaviour
{
    
    public static bool GameIsPaused = false;
    
    
    public void LoadMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
    public void quitGame()
    {
        Application.Quit();

    }
}
