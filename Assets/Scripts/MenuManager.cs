using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string MainMenu = "MainMenu";

    public void GoMainMenu() //Para exit o home
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
}
