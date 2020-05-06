using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;

    void start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void playGame()
    {
        audioSource.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       

    }
    public void quitGame()
    {
        Application.Quit();

    }
}
