using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void GoMainMenu() //Para exit o home
    {
        SceneManager.LoadScene(0);
    }

    public void GoToPlay() //Para exit o home
    {
        SceneManager.LoadScene(1);
    }

    public GameObject pauseMenu;

    public void pauseButton()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void playButton()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
